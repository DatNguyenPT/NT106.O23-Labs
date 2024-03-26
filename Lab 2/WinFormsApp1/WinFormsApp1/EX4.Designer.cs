namespace WinFormsApp1
{
    partial class EX4
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
            view = new Label();
            writeName = new Label();
            writeID = new Label();
            writePhone = new Label();
            writeScore1 = new Label();
            writeScore2 = new Label();
            writeScore3 = new Label();
            writeAverage = new Label();
            writeNameInput = new TextBox();
            writeIDInput = new TextBox();
            writePhoneInput = new TextBox();
            writeScore1Input = new TextBox();
            writeScore2Input = new TextBox();
            writeScore3Input = new TextBox();
            writeAverageInput = new TextBox();
            addButton = new Button();
            writeFileButton = new Button();
            filePathInput = new TextBox();
            readName = new Label();
            readID = new Label();
            readPhone = new Label();
            readScore1 = new Label();
            readScore2 = new Label();
            readScore3 = new Label();
            readAverage = new Label();
            nameResult = new Label();
            idResult = new Label();
            phoneResult = new Label();
            score1Result = new Label();
            score2Result = new Label();
            score3Result = new Label();
            averageResult = new Label();
            readFileButton = new Button();
            studentOrder = new Label();
            nextButton = new Button();
            backButton = new Button();
            SuspendLayout();
            // 
            // view
            // 
            view.BorderStyle = BorderStyle.FixedSingle;
            view.Location = new Point(263, 26);
            view.Name = "view";
            view.Size = new Size(278, 382);
            view.TabIndex = 0;
            // 
            // writeName
            // 
            writeName.Location = new Point(189, 79);
            writeName.Name = "writeName";
            writeName.Size = new Size(48, 15);
            writeName.TabIndex = 1;
            writeName.Text = "Name";
            // 
            // writeID
            // 
            writeID.Location = new Point(189, 118);
            writeID.Name = "writeID";
            writeID.Size = new Size(48, 16);
            writeID.TabIndex = 2;
            writeID.Text = "ID";
            // 
            // writePhone
            // 
            writePhone.Location = new Point(189, 177);
            writePhone.Name = "writePhone";
            writePhone.Size = new Size(48, 17);
            writePhone.TabIndex = 3;
            writePhone.Text = "Phone";
            // 
            // writeScore1
            // 
            writeScore1.Location = new Point(189, 221);
            writeScore1.Name = "writeScore1";
            writeScore1.Size = new Size(56, 15);
            writeScore1.TabIndex = 4;
            writeScore1.Text = "Course 1";
            // 
            // writeScore2
            // 
            writeScore2.Location = new Point(189, 270);
            writeScore2.Name = "writeScore2";
            writeScore2.Size = new Size(56, 23);
            writeScore2.TabIndex = 5;
            writeScore2.Text = "Course 2";
            // 
            // writeScore3
            // 
            writeScore3.Location = new Point(189, 325);
            writeScore3.Name = "writeScore3";
            writeScore3.Size = new Size(56, 15);
            writeScore3.TabIndex = 6;
            writeScore3.Text = "Course 3";
            // 
            // writeAverage
            // 
            writeAverage.Location = new Point(189, 365);
            writeAverage.Name = "writeAverage";
            writeAverage.Size = new Size(56, 15);
            writeAverage.TabIndex = 7;
            writeAverage.Text = "Average";
            // 
            // writeNameInput
            // 
            writeNameInput.Location = new Point(12, 71);
            writeNameInput.Name = "writeNameInput";
            writeNameInput.Size = new Size(171, 23);
            writeNameInput.TabIndex = 8;
            // 
            // writeIDInput
            // 
            writeIDInput.Location = new Point(12, 115);
            writeIDInput.Name = "writeIDInput";
            writeIDInput.Size = new Size(171, 23);
            writeIDInput.TabIndex = 9;
            // 
            // writePhoneInput
            // 
            writePhoneInput.Location = new Point(12, 171);
            writePhoneInput.Name = "writePhoneInput";
            writePhoneInput.Size = new Size(171, 23);
            writePhoneInput.TabIndex = 10;
            // 
            // writeScore1Input
            // 
            writeScore1Input.Location = new Point(12, 218);
            writeScore1Input.Name = "writeScore1Input";
            writeScore1Input.Size = new Size(171, 23);
            writeScore1Input.TabIndex = 11;
            // 
            // writeScore2Input
            // 
            writeScore2Input.Location = new Point(12, 267);
            writeScore2Input.Name = "writeScore2Input";
            writeScore2Input.Size = new Size(171, 23);
            writeScore2Input.TabIndex = 12;
            // 
            // writeScore3Input
            // 
            writeScore3Input.Location = new Point(12, 317);
            writeScore3Input.Name = "writeScore3Input";
            writeScore3Input.Size = new Size(171, 23);
            writeScore3Input.TabIndex = 13;
            // 
            // writeAverageInput
            // 
            writeAverageInput.Enabled = false;
            writeAverageInput.Location = new Point(12, 362);
            writeAverageInput.Name = "writeAverageInput";
            writeAverageInput.Size = new Size(171, 23);
            writeAverageInput.TabIndex = 14;
            // 
            // addButton
            // 
            addButton.Location = new Point(38, 404);
            addButton.Name = "addButton";
            addButton.Size = new Size(111, 34);
            addButton.TabIndex = 15;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addStudent;
            // 
            // writeFileButton
            // 
            writeFileButton.Location = new Point(27, 23);
            writeFileButton.Name = "writeFileButton";
            writeFileButton.Size = new Size(141, 42);
            writeFileButton.TabIndex = 16;
            writeFileButton.Text = "Write File";
            writeFileButton.UseVisualStyleBackColor = true;
            writeFileButton.Click += writeStudentFile;
            // 
            // filePathInput
            // 
            filePathInput.Location = new Point(246, 422);
            filePathInput.Name = "filePathInput";
            filePathInput.Size = new Size(316, 23);
            filePathInput.TabIndex = 17;
            // 
            // readName
            // 
            readName.Location = new Point(724, 74);
            readName.Name = "readName";
            readName.Size = new Size(39, 15);
            readName.TabIndex = 18;
            readName.Text = "Name";
            // 
            // readID
            // 
            readID.Location = new Point(724, 119);
            readID.Name = "readID";
            readID.Size = new Size(64, 15);
            readID.TabIndex = 19;
            readID.Text = "ID";
            // 
            // readPhone
            // 
            readPhone.Location = new Point(724, 179);
            readPhone.Name = "readPhone";
            readPhone.Size = new Size(64, 15);
            readPhone.TabIndex = 20;
            readPhone.Text = "Phone";
            // 
            // readScore1
            // 
            readScore1.Location = new Point(724, 221);
            readScore1.Name = "readScore1";
            readScore1.Size = new Size(64, 15);
            readScore1.TabIndex = 21;
            readScore1.Text = "Course 1";
            // 
            // readScore2
            // 
            readScore2.Location = new Point(724, 270);
            readScore2.Name = "readScore2";
            readScore2.Size = new Size(64, 15);
            readScore2.TabIndex = 22;
            readScore2.Text = "Course 2";
            // 
            // readScore3
            // 
            readScore3.Location = new Point(724, 325);
            readScore3.Name = "readScore3";
            readScore3.Size = new Size(73, 15);
            readScore3.TabIndex = 23;
            readScore3.Text = "Course 3";
            // 
            // readAverage
            // 
            readAverage.Location = new Point(724, 370);
            readAverage.Name = "readAverage";
            readAverage.Size = new Size(73, 15);
            readAverage.TabIndex = 24;
            readAverage.Text = "Average";
            // 
            // nameResult
            // 
            nameResult.BorderStyle = BorderStyle.FixedSingle;
            nameResult.Location = new Point(559, 69);
            nameResult.Name = "nameResult";
            nameResult.Size = new Size(153, 20);
            nameResult.TabIndex = 25;
            // 
            // idResult
            // 
            idResult.BorderStyle = BorderStyle.FixedSingle;
            idResult.Location = new Point(559, 119);
            idResult.Name = "idResult";
            idResult.Size = new Size(153, 20);
            idResult.TabIndex = 26;
            // 
            // phoneResult
            // 
            phoneResult.BorderStyle = BorderStyle.FixedSingle;
            phoneResult.Location = new Point(559, 171);
            phoneResult.Name = "phoneResult";
            phoneResult.Size = new Size(153, 20);
            phoneResult.TabIndex = 27;
            // 
            // score1Result
            // 
            score1Result.BorderStyle = BorderStyle.FixedSingle;
            score1Result.Location = new Point(559, 220);
            score1Result.Name = "score1Result";
            score1Result.Size = new Size(153, 20);
            score1Result.TabIndex = 28;
            // 
            // score2Result
            // 
            score2Result.BorderStyle = BorderStyle.FixedSingle;
            score2Result.Location = new Point(559, 265);
            score2Result.Name = "score2Result";
            score2Result.Size = new Size(153, 20);
            score2Result.TabIndex = 29;
            // 
            // score3Result
            // 
            score3Result.BorderStyle = BorderStyle.FixedSingle;
            score3Result.Location = new Point(559, 324);
            score3Result.Name = "score3Result";
            score3Result.Size = new Size(153, 20);
            score3Result.TabIndex = 30;
            // 
            // averageResult
            // 
            averageResult.BorderStyle = BorderStyle.FixedSingle;
            averageResult.Location = new Point(559, 364);
            averageResult.Name = "averageResult";
            averageResult.Size = new Size(153, 20);
            averageResult.TabIndex = 31;
            // 
            // readFileButton
            // 
            readFileButton.Location = new Point(571, 12);
            readFileButton.Name = "readFileButton";
            readFileButton.Size = new Size(141, 40);
            readFileButton.TabIndex = 32;
            readFileButton.Text = "Read File";
            readFileButton.UseVisualStyleBackColor = true;
            readFileButton.Click += readClick;
            // 
            // studentOrder
            // 
            studentOrder.BorderStyle = BorderStyle.FixedSingle;
            studentOrder.Location = new Point(652, 416);
            studentOrder.Name = "studentOrder";
            studentOrder.Size = new Size(38, 15);
            studentOrder.TabIndex = 33;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(714, 411);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(49, 26);
            nextButton.TabIndex = 34;
            nextButton.Text = "->";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextClick;
            // 
            // backButton
            // 
            backButton.Location = new Point(571, 411);
            backButton.Name = "backButton";
            backButton.Size = new Size(45, 26);
            backButton.TabIndex = 35;
            backButton.Text = "<-";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backClick;
            // 
            // EX4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(nextButton);
            Controls.Add(studentOrder);
            Controls.Add(readFileButton);
            Controls.Add(averageResult);
            Controls.Add(score3Result);
            Controls.Add(score2Result);
            Controls.Add(score1Result);
            Controls.Add(phoneResult);
            Controls.Add(idResult);
            Controls.Add(nameResult);
            Controls.Add(readAverage);
            Controls.Add(readScore3);
            Controls.Add(readScore2);
            Controls.Add(readScore1);
            Controls.Add(readPhone);
            Controls.Add(readID);
            Controls.Add(readName);
            Controls.Add(filePathInput);
            Controls.Add(writeFileButton);
            Controls.Add(addButton);
            Controls.Add(writeAverageInput);
            Controls.Add(writeScore3Input);
            Controls.Add(writeScore2Input);
            Controls.Add(writeScore1Input);
            Controls.Add(writePhoneInput);
            Controls.Add(writeIDInput);
            Controls.Add(writeNameInput);
            Controls.Add(writeAverage);
            Controls.Add(writeScore3);
            Controls.Add(writeScore2);
            Controls.Add(writeScore1);
            Controls.Add(writePhone);
            Controls.Add(writeID);
            Controls.Add(writeName);
            Controls.Add(view);
            Name = "EX4";
            Text = "EX4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label view;
        private Label writeName;
        private Label writeID;
        private Label writePhone;
        private Label writeScore1;
        private Label writeScore2;
        private Label writeScore3;
        private Label writeAverage;
        private TextBox writeNameInput;
        private TextBox writeIDInput;
        private TextBox writePhoneInput;
        private TextBox writeScore1Input;
        private TextBox writeScore2Input;
        private TextBox writeScore3Input;
        private TextBox writeAverageInput;
        private Button addButton;
        private Button writeFileButton;
        private TextBox filePathInput;
        private Label readName;
        private Label readID;
        private Label readPhone;
        private Label readScore1;
        private Label readScore2;
        private Label readScore3;
        private Label readAverage;
        private Label nameResult;
        private Label idResult;
        private Label phoneResult;
        private Label score1Result;
        private Label score2Result;
        private Label score3Result;
        private Label averageResult;
        private Button readFileButton;
        private Label studentOrder;
        private Button nextButton;
        private Button backButton;
    }
}