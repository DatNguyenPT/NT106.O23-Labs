using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class Bai4_Server : Form
    {
        private Thread serverThread;
        private Socket listenerSocket;
        private List<string> strings = new List<string>();
        public Bai4_Server()
        {
            InitializeComponent();
        }

        private void Bai4_Server_Load(object sender, EventArgs e)
        {

        }

        private void ReceiveData(Socket clientSocket)
        {
            int bytesReceived = 0;
            byte[] receive = new byte[1024];

            if (listView1.InvokeRequired)
            {
                listView1.Invoke((MethodInvoker)delegate
                {
                    listView1.Items.Add("Server started!");
                    string clientAddress = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                    int clientPort = ((IPEndPoint)clientSocket.RemoteEndPoint).Port;
                    listView1.Items.Add($"Connection accepted from {clientAddress}:{clientPort}");
                });
            }

            while (clientSocket.Connected)
            {
                string text = "";

                bytesReceived = clientSocket.Receive(receive);
                text += Encoding.UTF8.GetString(receive, 0, bytesReceived);

                bool itemFound = strings.Contains(text);
                if (!itemFound)
                {
                    clientSocket.Send(Encoding.UTF8.GetBytes("Successful"));
                    strings.Add(text);
                    if (listView1.InvokeRequired)
                    {
                        listView1.Invoke((MethodInvoker)delegate
                        {
                            listView1.Items.Add(text);
                        });
                    }
                }
                else
                {
                    clientSocket.Send(Encoding.UTF8.GetBytes("The seat has been booked"));
                }
            }
        }
        private void StartListen()
        {
            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            // Lắng nghe tại tất cả các địa chỉ IP trên máy và cổng 8080
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 8080);

            listenerSocket.Bind(iPEndPoint);
            listenerSocket.Listen(5);

            while (true)
            {
                var clientSocket = listenerSocket.Accept();
                Thread thread = new Thread(() => ReceiveData(clientSocket));
                thread.Start();
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            listenerSocket.Close();
            serverThread.Join();
            serverThread.Abort();
            this.Close();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            // Bắt đầu lắng nghe kết nối 
            serverThread = new Thread(StartListen);
            serverThread.Start();
            btnListen.Text = "Listening...";
        }
    }
}

