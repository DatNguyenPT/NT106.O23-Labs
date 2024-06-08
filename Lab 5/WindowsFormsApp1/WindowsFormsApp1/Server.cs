using OpenPop.Pop3;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Server : Form
    {
        private Pop3Client pop3Client;
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
            pop3Client = new Pop3Client();
            Load += Server_Load;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            FetchEmails();
        }

        private void FetchEmails()
        {
            try
            {
                pop3Client.Connect("pop.gmail.com", 995, true);
                pop3Client.Authenticate(email, password);

                // Clear existing items in the ListView
                mailList.Items.Clear();

                mailList.View = View.Details;
                mailList.Columns.Add("Sender", 200);
                mailList.Columns.Add("Subject", 300);
                int messageCount = pop3Client.GetMessageCount();
                for (int i = 1; i <= messageCount; i++)
                {
                    var message = pop3Client.GetMessage(i);
                    string senderEmail = message.Headers.From.Address;
                    string subject = message.Headers.Subject;
                    if (subject.Equals("Đóng góp món ăn", StringComparison.OrdinalIgnoreCase))
                    {
                        ListViewItem item = new ListViewItem(senderEmail);
                        item.SubItems.Add(subject);
                        mailList.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching emails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (pop3Client.Connected)
                {
                    pop3Client.Disconnect();
                }
            }
        }

    }
}
