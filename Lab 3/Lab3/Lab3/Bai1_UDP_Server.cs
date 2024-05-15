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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace Lab3
{
    public partial class Bai1_UDP_Server : Form
    {
        UdpClient udpServer;
        Thread serverThread;


        public Bai1_UDP_Server()
        {
            InitializeComponent();
            udpServer = new UdpClient();
        }

        private void Bai1_UDP_Server_Load(object sender, EventArgs e)
        {

        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            int port;
            if (int.TryParse(txt_ip_add.Text, out port))
            {
                StartListening(port);
            }
            else
            {
                MessageBox.Show("Số cổng không hợp lệ!");
            }
        }

        private void StartListening(int port)
        {
            udpServer = new UdpClient(port);
            serverThread = new Thread(new ThreadStart(ServerThreadMethod));     // tạo luồng mới để lắng nghe kết nối từ máy khách 
            serverThread.Start();
            UpdateListView("Server started listening on port " + port);
        }

        private void ServerThreadMethod()
        {
            try
            {
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    byte[] receiveBytes = udpServer.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    string message = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();    //tạo message gồm địa chỉ IP + dữ liệu nhận được 
                    UpdateListView(message);
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("SocketException: " + ex.Message);
            }
            finally
            {
                udpServer.Close();
            }
        }
        delegate void UpdateTextDelegate(string text);
        private void UpdateListView(string text)
        {
            if (listView.InvokeRequired)
            {
                listView.Invoke(new UpdateTextDelegate(UpdateListView), text);
            }
            else
            {
                listView.Items.Add(text);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            udpServer.Close();
            serverThread.Join();
            serverThread.Abort();
            this.Close();
        }
    }
}