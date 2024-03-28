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
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class EX5 : Form
    {
        public Dictionary<string, double> seatPrices { get; }
        public Dictionary<Tuple<string, double>, List<string>> filmPrices { get; }
        public Dictionary<Tuple<string, string>, Tuple<long, long>> quantityList { get; } // with the value is a tuple wher
        // item1 is default quantity and item2 is remaining quantity
        public System.Windows.Forms.CheckBox[,] seatStatusList;
        public Dictionary<Tuple<string, string>, System.Windows.Forms.CheckBox[,]> filmWithSeatState { get; }
        public Dictionary<Tuple<string, string>, double> revenue { get; }
        List<string> filmNameList; 
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
            quantityList = new Dictionary<Tuple<string, string>, Tuple<long, long>>();
            filmNameList = new List<string>();
            revenue = new Dictionary<Tuple<string, string>, double>();
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
                    Dictionary<string, List<string>> filmSections = new Dictionary<string, List<string>>();
                    
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        var field = line.Split(';');
                        if (field.Length < 4)
                        {
                            throw new Exception("Thiếu thông tin về film");
                        }
                        else
                        {
                            string filmName = field[0].ToString();
                            filmNameList.Add(filmName);
                            double price = Double.Parse(field[1]);
                            List<string> theatres = new List<string>(field[2].Split(','));
                            long quantity = long.Parse(field[3]);
                            filmSections.Add(filmName, theatres);
                            Tuple<string, double> tuple = new Tuple<string, double>(filmName, price);
                            for (int i = 0; i < theatres.Count; i++)
                            {
                                System.Windows.Forms.CheckBox[,] seatArray = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                                InitializeSeatArray(seatArray);
                                filmWithSeatState.Add(Tuple.Create(filmName, theatres[i]), seatArray);
                                quantityList.Add(Tuple.Create(filmName, theatres[i]), Tuple.Create(quantity, (long)0));
                                revenue.Add(Tuple.Create(filmName, theatres[i]), (double)0);
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
            int count = 0;
            if (filmWithSeatState.ContainsKey(temp))
            {
                System.Windows.Forms.CheckBox[,] currentStatus = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                currentStatus = filmWithSeatState[temp];
                for (int i = 0; i < seatRows; i++)
                {
                    for (int j = 0; j < seatCols; j++)
                    {
                        currentStatus[i, j].Checked = newStatus[i, j];
                        if (newStatus[i, j] == true)
                        {
                            count++;
                        }
                        currentStatus[i, j].Enabled = !newStatus[i, j];
                    }
                }
                filmWithSeatState[temp] = currentStatus;
                long remaining = quantityList[temp].Item2;
                long def = quantityList[temp].Item1;
                remaining -= def;
                quantityList[temp] = Tuple.Create(def, remaining);
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

        public void write(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                using (StreamWriter writer = new StreamWriter(ofd.FileName))
                {
                    foreach (var entry in quantityList)
                    {
                        writer.Write("Film Name: " + entry.Key.Item1 + "; ");
                        writer.Write("Theatre: " + entry.Key.Item2 + "; ");
                        writer.Write("Number of sold tickets: " + (entry.Value.Item1 - entry.Value.Item2) + "; ");
                        writer.Write("Number of remaining tickets: " + entry.Value.Item2 + "; ");
                        writer.Write("Selling Percentage: " + ((double)entry.Value.Item2 / entry.Value.Item1) + "; ");
                        writer.Write("Revenue: " + revenue[entry.Key] + "\n");
                    }
                    List <Tuple<string, double>>filmRevenue = new List<Tuple<string, double>>();
                    string sameName = filmNameList[0];
                    double total = 0;
                    foreach(var entry in revenue)
                    {
                        if (entry.Key.Item1.Equals(sameName))
                        {
                            total += revenue[entry.Key];
                            sameName = entry.Key.Item2;
                        }
                        else
                        {
                            filmRevenue.Add(Tuple.Create(sameName, total));
                            total = 0;
                        }
                    }
                    writer.Write("Total revenue each film: \n");
                    foreach(Tuple<string, double>tuple in filmRevenue)
                    {
                        writer.Write(tuple.Item1 + ": " + tuple.Item2 + "\n");
                    }
                    writer.Write("Revenue ranking: \n");
                    filmRevenue = filmRevenue.OrderByDescending(x => x.Item2).ToList();
                    long rank = 1;
                    foreach (Tuple<string, double> tuple in filmRevenue)
                    {
                        writer.Write($"{rank++}"+ tuple.Item1 + "\n");
                    }
                    writer.Close();
                }
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
