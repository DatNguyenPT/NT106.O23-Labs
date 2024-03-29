using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EX6 : Form
    {
        DataClass dataClass;

        public EX6()
        {
            InitializeComponent();
            dataClass = new DataClass();
            loadData();
        }

        public void loadData()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new System.Drawing.Size(64, 64);

            string getFoodList = "SELECT TenMonAn FROM MonAn";
            DataTable dt = dataClass.dataQuery(getFoodList);
            List<string> foodList = new List<string>();
            foreach (DataRow dataRow in dt.Rows)
            {
                foodList.Add(dataRow["TenMonAn"].ToString());
            }
            dt.Clear();

            string getAllFoods = $"SELECT * FROM MonAn";
            dt = dataClass.dataQuery(getAllFoods);
            int count = 0;
            foreach (DataRow dataRow in dt.Rows)
            {
                MonAn monAn = new MonAn();
                monAn.foodID = Convert.ToInt32(dataRow["IDMA"]);
                monAn.foodName = dataRow["TenMonAn"].ToString();
                monAn.img = dataRow["HinhAnh"].ToString();
                monAn.providerID = Convert.ToInt32(dataRow["IDNCC"]);
                string url = monAn.img;
                WebClient client = new WebClient();
                byte[] imageBytes = client.DownloadData(url);
                // Create image keys
                string key = "key" + count.ToString();
                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    imageList.Images.Add(key, Image.FromStream(stream));
                }

                ListViewItem item = new ListViewItem();
                item.ImageKey = key;
                foodBoard.Items.Add(item);
                count++;
            }
            foodBoard.LargeImageList = imageList;
        }



        private void randomClick(object sender, EventArgs e)
        {
            string getFoodList = "SELECT TenMonAn FROM MonAn";
            DataTable dt = dataClass.dataQuery(getFoodList);
            List<string> foodList = new List<string>();
            foreach (DataRow dataRow in dt.Rows)
            {
                foodList.Add(dataRow["TenMonAn"].ToString());
            }
            dt.Clear();
            Random random = new Random();
            int randomIndex = random.Next(0, foodList.Count);
            string foodResult = foodList[randomIndex];
            MonAn monAn = new MonAn();
            string getRandomFood = $"SELECT * FROM MonAn WHERE TenMonAn='{foodResult}'";
            dt = dataClass.dataQuery(getRandomFood);
            foreach (DataRow dataRow in dt.Rows)
            {
                monAn.foodID = Convert.ToInt32(dataRow["IDMA"]);
                monAn.foodName = dataRow["TenMonAn"].ToString();
                monAn.img = dataRow["HinhAnh"].ToString();
                monAn.providerID = Convert.ToInt32(dataRow["IDNCC"]);
            }
            result.Text = "";
            result.Text = $"Hôm nay ăn: {monAn.foodName.ToString()}";
            string url = monAn.img;
            WebClient client = new WebClient();
            byte[] imageBytes = client.DownloadData(url);
            ImageList imageList = new ImageList();
            imageList.ImageSize = foodBoardResult.Size;
            using (MemoryStream stream = new MemoryStream(imageBytes))
            {
                imageList.Images.Add("key", Image.FromStream(stream));
            }
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = foodBoardResult.ClientSize;
            pictureBox.Image = imageList.Images["key"];
            foodBoardResult.Controls.Clear();
            foodBoardResult.Controls.Add(pictureBox);
        }
    }

    public class MonAn
    {
        public int foodID { get; set; }
        public string foodName { get; set; }
        public string img { get; set; }
        public int providerID { get; set; }
    }

    public class NguoiDung
    {
        public int providerID { get; set; }
        public string name { get; set; }
        public string authority { get; set; }
    }
}

