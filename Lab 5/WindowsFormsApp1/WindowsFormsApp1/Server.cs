using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WindowsFormsApp1
{
    public partial class Server : Form
    {
        private ImapClient imapClient;
        private string email;
        private string password;
        private Sqlite sqlite;
        string databasePath = @"E:\UIT\Sophomore\Network Programming\Lab\Lab 5\database\FoodData.db";

        public string ServerEmail
        {
            get { return email; }
        }

        public string ServerPassword
        {
            get { return password; }
        }

        public Server(string emailAddress, string password)
        {
            InitializeComponent();
            sqlite = new Sqlite();
            email = emailAddress;
            this.password = password;
            imapClient = new ImapClient();
            imapClient.Connect("imap.gmail.com", 993, true);
            imapClient.Authenticate(email, password);
            if (imapClient.IsAuthenticated)
            {
                MessageBox.Show("IMAP is connected\n" + $"{email}, {password}");
                FetchEmails();
            }
        }

        private void FetchEmails()
        {
            try
            {
                // Clear existing items in the ListView
                mailList.Items.Clear();
                mailList.FullRowSelect = true;

                mailList.View = View.Details;
                mailList.Columns.Add("Sender", 150);
                mailList.Columns.Add("Subject", 150);
                mailList.Columns.Add("Food", 150);
                mailList.Columns.Add("Read", 50);

                imapClient.Inbox.Open(FolderAccess.ReadOnly);

                // Fetch the message summaries
                var messageSummaries = imapClient.Inbox.Fetch(0, -1, MessageSummaryItems.UniqueId | MessageSummaryItems.Flags);

                foreach (var summary in messageSummaries)
                {
                    var message = imapClient.Inbox.GetMessage(summary.UniqueId);
                    string senderEmail = message.From.ToString();
                    string subject = message.Subject;
                    string readStatus = (summary.Flags ?? MessageFlags.None).HasFlag(MessageFlags.Seen) ? "Yes" : "No";

                    if (subject.Equals("Đóng góp món ăn"))
                    {
                        if (string.IsNullOrEmpty(senderEmail))
                        {
                            senderEmail = "Người ẩn danh";
                        }

                        // Extract food text from the message body
                        string foodText = GetFoodTextFromMessage(message);

                        ListViewItem item = new ListViewItem(senderEmail);
                        item.SubItems.Add(subject);
                        item.SubItems.Add(foodText);
                        item.SubItems.Add(readStatus);
                        mailList.Items.Add(item);
                    }
                }
                mailList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching emails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFoodTextFromMessage(MimeMessage message)
        {
            string body = message.TextBody ?? message.HtmlBody ?? "";
            string foodText = "";
            int startIndex = 0;
            int endIndex = body.IndexOf("\n", startIndex);
            if (endIndex == -1)
            {
                endIndex = body.Length;
            }
            foodText = body.Substring(startIndex, endIndex - startIndex).Trim();

            return foodText;
        }

        private void readAndSaveClick(object sender, EventArgs e)
        {
            try
            {
                int count = 1;
                foreach (ListViewItem item in mailList.Items)
                {
                    // Get the full message
                    var message = imapClient.Inbox.GetMessage(item.Index);

                    // Retrieve all attachments recursively
                    var attachments = GetAttachments(message.Body);

                    if (!attachments.Any())
                    {
                        MessageBox.Show($"No attachment found in mail {count}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        foreach (var attachment in attachments)
                        {
                            if (attachment is MimePart mimePart)
                            {
                                if (mimePart.ContentType.MimeType == "image/jpeg" || mimePart.ContentType.MimeType == "image/png" || mimePart.ContentType.MimeType == "image/jpg")
                                {
                                    // Convert attachment into base64 string
                                    string imageDataBase64;
                                    using (var memoryStream = new MemoryStream())
                                    {
                                        mimePart.Content.DecodeTo(memoryStream);
                                        imageDataBase64 = Convert.ToBase64String(memoryStream.ToArray());
                                    }

                                    // Extract food text from the message body
                                    string foodText = GetFoodTextFromMessage(message);

                                    string senderEmail = item.SubItems[0].Text;

                                    // Insert both image data and food text into the database
                                    string query = "INSERT INTO food (sender, image, food) VALUES (@senderEmail, @imageDataBase64, @foodText)";

                                    if (!IsFoodTextExistInDatabase(foodText))
                                    {
                                        try
                                        {
                                            var connection = new SqliteConnection($"Data Source={databasePath}");
                                            connection.Open();
                                            var command = new SqliteCommand(query, connection);
                                            command.Parameters.AddWithValue("@senderEmail", senderEmail);
                                            command.Parameters.AddWithValue("@imageDataBase64", imageDataBase64);
                                            command.Parameters.AddWithValue("@foodText", foodText);
                                            var rowInserted = command.ExecuteNonQuery();
                                            if (rowInserted != 0)
                                            {
                                                MessageBox.Show("New foods saved to the database successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                            {
                                                MessageBox.Show("No foods are saved to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        catch (SqliteException ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No attachment found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No attachment found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving unread emails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IEnumerable<MimeEntity> GetAttachments(MimeEntity entity)
        {
            if (entity is Multipart multipart)
            {
                foreach (var part in multipart)
                {
                    foreach (var attachment in GetAttachments(part))
                    {
                        yield return attachment;
                    }
                }
            }
            else if (entity is MessagePart)
            {
                var messagePart = (MessagePart)entity;
                foreach (var attachment in GetAttachments(messagePart.Message.Body))
                {
                    yield return attachment;
                }
            }
            else if (entity is MimePart mimePart)
            {
                if (mimePart.IsAttachment || mimePart.ContentDisposition?.Disposition == ContentDisposition.Inline)
                {
                    yield return mimePart;
                }
            }
        }

        private bool IsFoodTextExistInDatabase(string foodText)
        {
            string query = $"SELECT COUNT(*) FROM food WHERE food = '{foodText}'";
            DataTable result = sqlite.dataQuery(query);
            int count = Convert.ToInt32(result.Rows[0][0]);
            return count > 0;
        }

        private void random(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT sender, image, food FROM food ORDER BY RANDOM() LIMIT 1";

                DataTable foodResult = sqlite.dataQuery(query);

                if (foodResult.Rows.Count > 0)
                {
                    string senderEmail = foodResult.Rows[0]["sender"].ToString();
                    string imageUrlBase64 = foodResult.Rows[0]["image"].ToString();
                    string foodText = foodResult.Rows[0]["food"].ToString();

                    // Convert base64 into image again
                    byte[] imageDataBytes = Convert.FromBase64String(imageUrlBase64);

                    MessageBox.Show($"Sender: {senderEmail}\nFood Text: {foodText}");
                    using (var memoryStream = new MemoryStream(imageDataBytes))
                    {
                        Image image = Image.FromStream(memoryStream);
                        imageResult.Image = image;
                        result.Text += foodText + $" Provided by {senderEmail}";
                    }
                }
                else
                {
                    MessageBox.Show("No foods found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving random email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
