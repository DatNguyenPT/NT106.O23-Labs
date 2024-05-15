using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lab3
{
    public partial class Bai3_TCP_Client : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Bai3_TCP_Client()
        {
            InitializeComponent();
        }

        private void Bai3_TCP_Client_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo và kết nối tới server
                client = new TcpClient();
                client.Connect("127.0.0.1", 8080);
                stream = client.GetStream();
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("Error: " + ex.Message + "\n");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtName.Text;
                string message = userName + ":" + richTextBox1.Text + "\n";
                // Gửi dữ liệu đã nhập từ richTextBox1 đến server
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
                richTextBox1.Clear();
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("Error: " + ex.Message + "\n");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtName.Text;
                string message = userName + ": quit\n";
                // Gửi chuỗi "quit" đến server để thông báo ngắt kết nối 
                byte[] data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
                this.Close();
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("Error: " + ex.Message + "\n");
            }
        }
    }
}

