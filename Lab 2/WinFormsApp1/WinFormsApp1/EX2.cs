using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EX2 : Form
    {
        OpenFileDialog ofd;
        FileStream fs;
        public EX2()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
        }

        private void readClick(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            using (StreamReader read = new StreamReader(ofd.FileName))
            {
                string fileText = read.ReadToEnd();
                fileContent.Text = fileText;
                fileNameResult.Text = ofd.SafeFileName.ToString();
                filePathResult.Text = ofd.FileName.ToString();
                long length = new System.IO.FileInfo(filePathResult.Text).Length;
                fileSizeResult.Text = length.ToString();
                int count = 0;
                read.BaseStream.Position = 0; // move the pointer to starting position
                while (read.ReadLine() != null)
                {
                    count++;
                }
                lineCountResult.Text = count.ToString();
                count = 0;
                for (int i = 0; i < fileText.Length; i++) {
                    ++count;
                }
                charCountResult.Text = count.ToString();
                count = 0;
                string[] words = fileText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                wordCountResult.Text = words.Length.ToString();
            }
        }
    }
}
