using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai1_UDP_Client : Form
    {
        UdpClient udpClient;

        public Bai1_UDP_Client()
        {
            InitializeComponent();
            udpClient = new UdpClient();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {

        }

        private void Bai1_UDP_Client_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click_1(object sender, EventArgs e)
        {
            string IPaddr = txt_ip_add.Text;
            int port;
            if (int.TryParse(txt_port.Text, out port))
            {
                string message = txt_send.Text;

                byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                try
                {
                    udpClient.Send(sendBytes, sendBytes.Length, IPaddr, port);
                    MessageBox.Show("Đã gửi thành công !", "Thông báo");
                    txt_send.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Số cổng không hợp lệ !", "Lỗi");
            }
        }
    }
}