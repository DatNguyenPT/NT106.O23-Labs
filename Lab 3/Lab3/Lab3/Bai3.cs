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
    public partial class Bai3 : Form
    {
        Bai3_TCP_Client client = new Bai3_TCP_Client();
        Bai3_TCP_Server server = new Bai3_TCP_Server();
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnTCP_Client_Click(object sender, EventArgs e)
        {
            client.Show();
        }

        private void btnTCP_Server_Click(object sender, EventArgs e)
        {
            server.Show();
        }
    }
}