using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai4_Client : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Bai4_Client(int v)
        {
            InitializeComponent();
        }

        private void Bai4_Client_Load(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;
            string text = button.Text;
            string FilmName = comboBox1.SelectedItem.ToString();
            labelInfo.Text = FilmName + " " + text;
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
                MessageBox.Show("Error: " + ex.Message + "\n");
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
                MessageBox.Show("Error: " + ex.Message + "\n");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (labelInfo.Text != "")
            {
                try
                {
                    string message = labelInfo.Text;
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    labelInfo.Text = "";

                    ReceiveData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\n");
                }
            }
            else
            {
                MessageBox.Show("Error: Vui lòng chọn vé và ghế");
            }

        }

        private void ReceiveData()
        {
            try
            {
                // Tạo mảng byte để lưu trữ dữ liệu nhận được
                byte[] buffer = new byte[1024];
                int bytesRead = 0;

                // Đọc dữ liệu từ stream
                if ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    // Chuyển đổi dữ liệu từ byte sang string
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Hiển thị thông báo nhận được từ server
                    MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n");
            }
        }
    }
}