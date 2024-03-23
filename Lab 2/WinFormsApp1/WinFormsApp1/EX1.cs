using System.Text;

namespace WinFormsApp1
{
    public partial class EX1 : Form
    {
        OpenFileDialog ofd;
        FileStream fs;
        public EX1()
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
                result.Text = fileText;
            }
        }

        private void writeClick(object sender, EventArgs e)
        {
            string path = filePathInput.Text;
            if (path.Equals("") || !IsValidPath(path))
            {
                MessageBox.Show("Đường dẫn không hợp lệ");
            }
            else
            {
                writeFile(path);
            }
        }

        static bool IsValidPath(string path)
        {
            try
            {
                bool isValid = !string.IsNullOrEmpty(path) && Path.GetFullPath(path) == path;
                return isValid;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void writeFile(string filePath)
        {
            string content = result.Text;
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(content);
            }
            MessageBox.Show("Nội dung đã được lưu vào tệp tin mới.");
        }

    }
}