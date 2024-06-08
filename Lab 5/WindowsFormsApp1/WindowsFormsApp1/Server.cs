using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using System;
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

                mailList.View = View.Details;
                mailList.Columns.Add("Sender", 200);
                mailList.Columns.Add("Subject", 300);

                imapClient.Inbox.Open(FolderAccess.ReadOnly);
                var messageCount = imapClient.Inbox.Count;
                for (int i = 0; i < messageCount; i++)
                {
                    var message = imapClient.Inbox.GetMessage(i);
                    string senderEmail = message.From.ToString();
                    string subject = message.Subject;
                    if (subject.Equals("Đóng góp món ăn"))
                    {
                        if (string.IsNullOrEmpty(senderEmail))
                        {
                            senderEmail = "Người ẩn danh";
                        }
                        ListViewItem item = new ListViewItem(senderEmail);
                        item.SubItems.Add(subject);
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
    }
}
