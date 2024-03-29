using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EX5Payment : Form
    {
        public EX5Payment()
        {
            InitializeComponent();
        }
            private void DisplayTicketInfo(List<Tuple<int, int>> list, Dictionary<Tuple<string, double>, List<string>> filmPrices, Dictionary<string, double> seatPrices, string filmName, string section)
            {
                EX5 ex5 = (EX5)this.Owner;
                string result = $"Họ tên: {nameInput.Text}\n" +
                    $"Đã mua {list.Count} vé\n";
                List<string> seatPosition = new List<string>();
                foreach (var seat in list)
                {
                    string type = "";
                    switch (seat.Item1)
                    {
                        case 0:
                            type = "A";
                            break;
                        case 1:
                            type = "B";
                            break;
                        case 2:
                            type = "C";
                            break;
                    }
                    seatPosition.Add(type + (seat.Item2 + 1)); // Start with index 0
                }
                result += $"Các vé lần lượt là: {string.Join(", ", seatPosition)}\n";

                double total = 0;
                double ticketPrice = 0;
                foreach(var film in  filmPrices)
                {
                    if (film.Key.Item1.Equals(filmName))
                    {
                        ticketPrice = film.Key.Item2;
                        break;
                    }
                }
                foreach (var seat in seatPosition)
                {
                    total += ticketPrice * seatPrices[seat];
                }
                result += $"Tổng tiền: {total}";
                ticketInfo.Text = result;
                Tuple<string, string> tuple = Tuple.Create(filmName, section);
                ex5.revenue[tuple] += total;
            }

        // Event handler for Finish button click
        public event EventHandler PaymentFormClosed;
        public int count = 0;
        private void FinishButton_Click(object sender, EventArgs e)
        {
            ++count;
            EX5 ex5 = (EX5)this.Owner; // Access to current Bai5 instance
            if (ex5 != null)
            {
                List<Tuple<int, int>> selectedSeats = ex5.buyTickets();
                Dictionary<Tuple<string, double>, List<string>> filmPrices = ex5.filmPrices;
                Dictionary<string, double> seatPrices = ex5.seatPrices;
                string filmName = this.filmName;
                string section = ex5.getSection();
                DisplayTicketInfo(selectedSeats, filmPrices, seatPrices, filmName, section);
                
                finish.Text = "Kết thúc";
                if (count == 2)
                {
                    ex5.disableCheckedSeats();
                    ex5.updateSeatState();
                    this.Close();
                }
            }
        }

        private void Bai5Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            PaymentFormClosed?.Invoke(this, EventArgs.Empty);
        }

        public string filmName { get; set; }

        private void back_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
