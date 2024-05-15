using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai1 : Form
    {
        Bai1_UDP_Client client = new Bai1_UDP_Client();
        Bai1_UDP_Server server = new Bai1_UDP_Server();
        public Bai1()
        {
            InitializeComponent();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void btnUDP_Click(object sender, EventArgs e)
        {
            client.Show();
        }

        private void btnUDP_server_Click(object sender, EventArgs e)
        {
            server.Show();
        }
    }
}