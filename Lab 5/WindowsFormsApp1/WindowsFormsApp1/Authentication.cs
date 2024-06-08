using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private async void connectToServer(object sender, EventArgs e)
        {
            string emailAddress = emailInput.Text;
            string password = passwordInput.Text;
            string smtpHost = "smtp.gmail.com";
            int smtpPort = 587;

            try
            {
                using (SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential(emailAddress, password);
                    //await smtpClient.SendMailAsync("datnpt2004@gmail.com", emailAddress, "Test", "Test");

                    MessageBox.Show("Connected successfully");

                    Timer timer = new Timer();
                    timer.Interval = 2000;
                    timer.Tick += (timerSender, args) =>
                    {
                        timer.Stop();
                        timer.Dispose();
                        this.Hide();
                        using (Server serverForm = new Server(emailAddress, password)) // Pass email and password to Server form
                        {
                            serverForm.ShowDialog();
                        }
                    };
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the email server: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
