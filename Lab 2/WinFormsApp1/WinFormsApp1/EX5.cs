using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EX5 : Form
    {
        public Dictionary<string, double> seatPrices { get; }
        public Dictionary<Tuple<string, double>, List<string>> filmPrices { get; }
        public System.Windows.Forms.CheckBox[,] seatStatusList;
        public Dictionary<Tuple<string, string>, System.Windows.Forms.CheckBox[,]> filmWithSeatState { get; }
        public EX5()
        {
            System.Windows.Forms.CheckBox[,] mySeatArray = new System.Windows.Forms.CheckBox[seatRows, seatCols];
            for (int i = 0; i < seatRows; i++)
            {
                for (int j = 0; j < seatCols; j++)
                {
                    mySeatArray[i, j] = new System.Windows.Forms.CheckBox();
                }
            }
            EX5Payment EX5Payment = new EX5Payment();
            EX5Payment.PaymentFormClosed += EX5Payment_FormClosed;
            seatPrices = new Dictionary<string, double>();
            filmPrices = new Dictionary<Tuple<string, double>, List<string>>();
            seatStatusList = new System.Windows.Forms.CheckBox[seatRows, seatCols];
            filmWithSeatState = new Dictionary<Tuple<string, string>, System.Windows.Forms.CheckBox[,]>();
            InitializeComponent();
            Load += Bai5_Load;
            createSeats(mySeatArray);

        }

        public void loadInfoClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            filmWithSeatState.Clear();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                using (StreamReader read = new StreamReader(ofd.FileName))
                {
                    Dictionary<string, List<string>> filmSections = new Dictionary<string, List<string>>(); // Lưu trữ các phòng chiếu cho mỗi phim
                    List<string> filmNameList = new List<string>();
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        var field = line.Split(';');
                        if (field.Length < 3)
                        {
                            throw new Exception("Thiếu thông tin về film");
                        }
                        else
                        {
                            string filmName = field[0].ToString();
                            filmNameList.Add(filmName);
                            double price = Double.Parse(field[1]);
                            List<string> theatres = new List<string>(field[2].Split(','));
                            filmSections.Add(filmName, theatres); // Thêm danh sách các phòng chiếu cho phim vào từ điển
                            Tuple<string, double> tuple = new Tuple<string, double>(filmName, price);
                            System.Windows.Forms.CheckBox[,] seatArray = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                            InitializeSeatArray(seatArray);
                            for (int i = 0; i < theatres.Count; i++)
                            {
                                filmWithSeatState.Add(Tuple.Create(filmName, theatres[i]), seatArray);
                            }
                            filmPrices.Add(tuple, theatres);
                        }
                    }

                    filmList.DataSource = filmNameList;

                    // Set DataSource for section based on the selected film
                    filmList.SelectedIndexChanged += (obj, args) =>
                    {
                        string selectedFilm = filmList.SelectedItem as string;
                        if (selectedFilm != null && filmSections.ContainsKey(selectedFilm))
                        {
                            section.DataSource = filmSections[selectedFilm];
                        }
                    };
                }
            }
        }




        private void Bai5_Load(object sender, EventArgs e)
        {
            // Set seat prices
            seatPrices.Clear();
            seatPrices.Add("A1", 0.25);
            seatPrices.Add("A5", 0.25);
            seatPrices.Add("C1", 0.25);
            seatPrices.Add("C5", 0.25);
            seatPrices.Add("A2", 1);
            seatPrices.Add("A3", 1);
            seatPrices.Add("A4", 1);
            seatPrices.Add("C2", 1);
            seatPrices.Add("C3", 1);
            seatPrices.Add("C4", 1);
            seatPrices.Add("B1", 2);
            seatPrices.Add("B2", 2);
            seatPrices.Add("B3", 2);
            seatPrices.Add("B4", 2);
            seatPrices.Add("B5", 2);
        }

        private void InitializeSeatArray(System.Windows.Forms.CheckBox[,] seatArray)
        {
            for (int i = 0; i < seatRows; i++)
            {
                for (int j = 0; j < seatCols; j++)
                {
                    seatArray[i, j] = new System.Windows.Forms.CheckBox();
                }
            }
        }

        public List<Tuple<int, int>> buyTickets()
        {
            return tickets();
        }
        private void EX5Payment_FormClosed(object sender, EventArgs e) { }
        // Only called when finish payment
        public void updateSeatState()
        {
            Tuple<string, string> temp = Tuple.Create(filmList.SelectedItem.ToString(), section.SelectedItem.ToString());
            bool[,] newStatus = saveSeatState();
            if (filmWithSeatState.ContainsKey(temp))
            {
                System.Windows.Forms.CheckBox[,] currentStatus = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                currentStatus = filmWithSeatState[temp];
                for (int i = 0; i < seatRows; i++)
                {
                    for (int j = 0; j < seatCols; j++)
                    {
                        currentStatus[i, j].Checked = newStatus[i, j];
                        currentStatus[i, j].Enabled = !newStatus[i, j];
                    }
                }
                filmWithSeatState[temp] = currentStatus;
            }
        }

        public void disableCheckedSeats()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox currentSeat = (System.Windows.Forms.CheckBox)control;
                    if (currentSeat.Checked)
                    {
                        currentSeat.Enabled = false;
                    }
                }
            }
        }
        private void ClearSeatCheckboxes()
        {
            List<Control> controlsToRemove = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.CheckBox)
                {
                    controlsToRemove.Add(control);
                }
            }

            foreach (Control control in controlsToRemove)
            {
                this.Controls.Remove(control);
            }
        }




        private void theatreAccess_Click(object sender, EventArgs e)
        {
            string selectedFilm = filmList.SelectedItem?.ToString();
            string selectedSection = section.SelectedItem?.ToString();

            if (selectedFilm != null && selectedSection != null)
            {
                Tuple<string, string> temp = Tuple.Create(selectedFilm, selectedSection);

                if (filmWithSeatState.ContainsKey(temp))
                {
                    ClearSeatCheckboxes();
                    System.Windows.Forms.CheckBox[,] seatArray = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                    seatArray = filmWithSeatState[temp];
                    createSeats(seatArray);
                }
                else
                {
                    MessageBox.Show("No seat information found for the selected film and section.");
                }
            }
            else
            {
                MessageBox.Show("Please select both film and section.");
            }
        }



        public string getFilmName()
        {
            return filmList.SelectedItem?.ToString();
        }

        public string getSection()
        {
            return section.SelectedItem?.ToString();
        }

        public int getSeatRows()
        {
            return this.seatRows;
        }

        public int getSeatCols()
        {
            return this.seatCols;
        }

        private void exit_form(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_click(object sender, EventArgs e)
        {
            foreach (var key in filmWithSeatState.Keys)
            {
                foreach (var state in filmWithSeatState[key])
                {
                    state.Checked = false;
                    state.Enabled = true;
                }
            }
        }
    }
}
