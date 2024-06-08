using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApp1
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void selectImage(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    // Display image in images
                    images.Image = Image.FromFile(file);

                    // Store image path in Tag property for later use
                    images.Tag = file;
                }
                catch (IOException)
                {
                    // Handle exception
                }
            }
        }

        private void sendEmailClick(object sender, EventArgs e)
        {
            if (!titleInput.Text.Equals("Đóng góp món ăn"))
            {
                MessageBox.Show("Đây là ứng dụng đóng góp món ăn" +
                                "\n" +
                                "Hãy sửa lại tiêu đề email",
                                "Lỗi tiêu đề");
            }
            else
            {
                try
                {
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(fromInput.Text);
                    msg.To.Add(toInput.Text);
                    msg.Subject = titleInput.Text;
                    msg.Body = bodyInput.Text;

                    // Attach the image to the email
                    if (images.Image != null && images.Tag != null)
                    {
                        string imagePath = images.Tag.ToString();
                        Attachment attachment = new Attachment(imagePath);
                        msg.Attachments.Add(attachment);
                    }

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    smt.EnableSsl = true;

                    smt.Credentials = new NetworkCredential("22520217@gm.uit.edu.vn", "1805709989");

                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Your Mail is sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
