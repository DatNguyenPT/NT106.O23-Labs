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
    public partial class Bai5 : Form
    {
        private List<Bai5_Client> bai5list = new List<Bai5_Client>();
        Bai5_Server server = new Bai5_Server();
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Bai5_Client bai5 = new Bai5_Client(bai5list.Count + 1);
            bai5list.Add(bai5);
            bai5.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            server.Show();
        }
    }
}