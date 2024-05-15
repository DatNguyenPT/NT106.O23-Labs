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
    public partial class Bai6 : Form
    {
        private List<Bai6_Client> bai6list = new List<Bai6_Client>();
        Bai6_Server server = new Bai6_Server();
        public Bai6()
        {
            InitializeComponent();
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Bai6_Client bai6 = new Bai6_Client(bai6list.Count + 1);
            bai6list.Add(bai6);
            bai6.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            server.Show();
        }
    }
}