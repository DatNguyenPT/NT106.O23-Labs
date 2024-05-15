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
    public partial class Bai4 : Form
    {
        private List<Bai4_Client> bai4list = new List<Bai4_Client>();
        Bai4_Server server = new Bai4_Server();
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Bai4_Client bai4 = new Bai4_Client(bai4list.Count + 1);
            bai4list.Add(bai4);
            bai4.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            server.Show();
        }
    }
}