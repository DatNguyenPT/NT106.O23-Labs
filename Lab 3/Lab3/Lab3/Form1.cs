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
    public partial class Menu : Form
    {
        Bai1 bai1 = new Bai1();
        Bai2 bai2 = new Bai2();
        Bai3 bai3 = new Bai3();
        Bai4 bai4 = new Bai4();
        Bai5 bai5 = new Bai5();
        Bai6 bai6 = new Bai6();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            bai1.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            bai2.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            bai3.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            bai4.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            bai5.Show();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            bai6.Show();
        }
    }
}