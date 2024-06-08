using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Server : Form   
    {
        // Pop3 => Only unread mails
        // Imap => All mails
        private ImapClient imapClient;
        private string email;
        private string password;
        private Sqlite sqlite;

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
            finally
            {
                imapClient.Disconnect(true);
            }
        }


        private string GetFoodTextFromMessage(MimeMessage message)
        {
            string body = message.TextBody ?? message.HtmlBody ?? ""; 
            string foodText = ""; // Initialize food text

            if (body.Contains("Food:"))
            {
                int startIndex = body.IndexOf("Food:") + "Food:".Length;
                int endIndex = body.IndexOf("\n", startIndex);
                if (endIndex != -1)
                {
                    foodText = body.Substring(startIndex, endIndex - startIndex).Trim();
                }
            }

            return foodText;
        }


        private void readAndSaveClick(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in mailList.Items)
                {
                    var message = imapClient.Inbox.GetMessage(item.Index);
                    var attachments = message.Attachments;

                    var imageAttachment = attachments.FirstOrDefault(a => a is MimePart) as MimePart;

                    if (imageAttachment != null)
                    {
                        string imageDataBase64;
                        using (var memoryStream = new MemoryStream())
                        {
                            imageAttachment.Content.DecodeTo(memoryStream);
                            imageDataBase64 = Convert.ToBase64String(memoryStream.ToArray());
                        }

                        // Extract food text from the message body
                        string foodText = GetFoodTextFromMessage(message);

                        string senderEmail = item.SubItems[0].Text;

                        // Insert both image data and food text into the database
                        string query = $"INSERT INTO food (sender, image, food) VALUES ('{senderEmail}', '{imageDataBase64}', '{foodText}')";
                        if (!IsFoodTextExistInDatabase(foodText))
                        {
                            sqlite.dataQuery(query);
                        }
                    }
                }

                MessageBox.Show("Unread emails saved to the database successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving unread emails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string senderEmail = foodResult.Rows[0]["Sender"].ToString();
                    string imageUrlBase64 = foodResult.Rows[0]["ImageData"].ToString();
                    string foodText = foodResult.Rows[0]["FoodText"].ToString();

                    byte[] imageDataBytes = Convert.FromBase64String(imageUrlBase64);

                    MessageBox.Show($"Sender: {senderEmail}\nFood Text: {foodText}");
                    using (var memoryStream = new MemoryStream(imageDataBytes))
                    {
                        Image image = Image.FromStream(memoryStream);
                        imageResult.Image = image;
                        result.Text += foodText + $"Provided by {senderEmail}";
                    }
                }
                else
                {
                    MessageBox.Show("No emails found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving random email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
