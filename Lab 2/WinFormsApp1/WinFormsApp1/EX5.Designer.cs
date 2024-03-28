namespace WinFormsApp1
{
    partial class EX5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EX5));
            filmList = new ComboBox();
            section = new ComboBox();
            pay = new Button();
            reset = new Button();
            exit = new Button();
            theatreAccess = new Button();
            loadInfo = new Button();
            SuspendLayout();
            // 
            // filmList
            // 
            filmList.DataSource = resources.GetObject("filmList.DataSource");
            filmList.DropDownStyle = ComboBoxStyle.DropDownList;
            filmList.FormattingEnabled = true;
            filmList.Location = new Point(264, 67);
            filmList.Name = "filmList";
            filmList.Size = new Size(246, 28);
            filmList.TabIndex = 0;
            // 
            // section
            // 
            section.DataSource = resources.GetObject("section.DataSource");
            section.DropDownStyle = ComboBoxStyle.DropDownList;
            section.FormattingEnabled = true;
            section.Location = new Point(613, 67);
            section.Name = "section";
            section.Size = new Size(151, 28);
            section.TabIndex = 1;
            // 
            // pay
            // 
            pay.Location = new Point(613, 139);
            pay.Name = "pay";
            pay.Size = new Size(151, 41);
            pay.TabIndex = 2;
            pay.Text = "Thanh Toán";
            pay.UseVisualStyleBackColor = true;
            pay.Click += pay_btn_click;
            // 
            // reset
            // 
            reset.Location = new Point(613, 205);
            reset.Name = "reset";
            reset.Size = new Size(151, 42);
            reset.TabIndex = 3;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_click;
            // 
            // exit
            // 
            exit.Location = new Point(613, 277);
            exit.Name = "exit";
            exit.Size = new Size(151, 40);
            exit.TabIndex = 4;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_form;
            // 
            // theatreAccess
            // 
            theatreAccess.Location = new Point(334, 124);
            theatreAccess.Name = "theatreAccess";
            theatreAccess.Size = new Size(94, 29);
            theatreAccess.TabIndex = 5;
            theatreAccess.Text = "->";
            theatreAccess.UseVisualStyleBackColor = true;
            theatreAccess.Click += theatreAccess_Click;
            // 
            // loadInfo
            // 
            loadInfo.Location = new Point(44, 67);
            loadInfo.Name = "loadInfo";
            loadInfo.Size = new Size(165, 28);
            loadInfo.TabIndex = 6;
            loadInfo.Text = "Load thông tin film";
            loadInfo.UseVisualStyleBackColor = true;
            loadInfo.Click += loadInfoClick;
            // 
            // EX5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadInfo);
            Controls.Add(theatreAccess);
            Controls.Add(exit);
            Controls.Add(reset);
            Controls.Add(pay);
            Controls.Add(section);
            Controls.Add(filmList);
            Name = "EX5";
            Text = "Bai5";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox filmList;
        private ComboBox section;
        private int seatRows = 3;
        private int seatCols = 5;
        int seatWidth = 40;
        int seatHeight = 40;
        int labelX;
        int labelY;
        public CheckBox[,] seatStatus;
        int gap = 10;
        int startX;
        int startY;
        private void createSeats(CheckBox[,] seatArray)
        {
            if (seatArray.GetLength(0) != seatRows || seatArray.GetLength(1) != seatCols)
            {
                seatStatus = new CheckBox[seatRows, seatCols];
                seatStatus = seatArray;
            }
            int rows = seatArray.GetLength(0);
            int cols = seatArray.GetLength(1);

            int startXTemp = (this.ClientSize.Width - (seatCols * (seatWidth + gap) - gap)) / 2;
            int startYTemp = 240;
            startX = startXTemp;
            startY = startYTemp;
            string[] alphabet = { "A", "B", "C" };
            for (int i = 0; i < rows; i++)
            {
                int y = startYTemp + (seatHeight + gap) * i;
                Label label = new Label();
                label.Text = alphabet[i];
                label.AutoSize = true;
                label.Location = new Point(startX - 30, y + seatHeight / 2 - label.Height / 2);
                this.Controls.Add(label);
                for (int j = 0; j < cols; j++)
                {
                    int x = startXTemp + (seatWidth + gap) * j;
                    CheckBox seat = seatArray[i, j];
                    if (seatArray[i, j] == null)
                    {
                        seatArray[i, j] = new CheckBox();
                        seat.Size = new Size(seatWidth, seatHeight);
                        seat.Location = new Point(x, y);
                        seat.Enabled = true;
                        seat.Checked = true;

                    }
                    else
                    {
                        seat.Size = new Size(seatWidth, seatHeight);
                        seat.Location = new Point(x, y);
                        seat.Enabled = seatArray[i, j].Enabled;
                        seat.Checked = seatArray[i, j].Checked;
                    }

                    this.Controls.Add(seat);
                }
            }
        }
        public bool[,] saveSeatState()
        {
            bool[,] currentSeatState = new bool[seatRows, seatCols];
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox currentSeat = (CheckBox)control;
                    if (currentSeat.Parent == this)
                    {
                        int i = (currentSeat.Top - startY) / (seatHeight + gap);
                        int j = (currentSeat.Left - startX) / (seatWidth + gap);
                        currentSeatState[i, j] = currentSeat.Checked;
                    }
                }
            }
            return currentSeatState;
        }

        private List<Tuple<int, int>> tickets()
        {
            List<Tuple<int, int>> buying = new List<Tuple<int, int>>();
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox currentSeat = (CheckBox)control;
                    if (currentSeat.Parent == this)
                    {
                        int i = (currentSeat.Top - startY) / (seatHeight + gap);
                        int j = (currentSeat.Left - startX) / (seatWidth + gap);
                        if (currentSeat.Checked && currentSeat.Enabled == true)
                        {
                            Tuple<int, int> temp = Tuple.Create(i, j);
                            buying.Add(temp);
                        }
                    }
                }
            }
            return buying;
        }


        private void pay_btn_click(object sender, EventArgs e)
        {
            EX5Payment ex5Payment = new EX5Payment();
            ex5Payment.Owner = this;
            ex5Payment.filmName = getFilmName();
            ex5Payment.ShowDialog();
        }

        private Button pay;
        private Button reset;
        private Button exit;
        private Button theatreAccess;
        private Button loadInfo;
    }
}