namespace WinFormsApp1
{
    partial class EX5Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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
            name = new Label();
            nameInput = new TextBox();
            ticketInfo = new Label();
            finish = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(37, 65);
            name.Name = "name";
            name.Size = new Size(105, 45);
            name.TabIndex = 0;
            name.Text = "Họ Tên";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(180, 74);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(376, 27);
            nameInput.TabIndex = 1;
            // 
            // ticketInfo
            // 
            ticketInfo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ticketInfo.Location = new Point(86, 110);
            ticketInfo.Name = "ticketInfo";
            ticketInfo.Size = new Size(628, 209);
            ticketInfo.TabIndex = 2;
            // 
            // finish
            // 
            finish.Location = new Point(580, 368);
            finish.Name = "finish";
            finish.Size = new Size(115, 50);
            finish.TabIndex = 3;
            finish.Text = "Tính Tiền";
            finish.UseVisualStyleBackColor = true;
            finish.Click += FinishButton_Click;
            // 
            // back
            // 
            back.Location = new Point(76, 368);
            back.Name = "back";
            back.Size = new Size(129, 50);
            back.TabIndex = 4;
            back.Text = "Trở Về";
            back.UseVisualStyleBackColor = true;
            back.Click += back_click;
            // 
            // Bai5Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back);
            Controls.Add(finish);
            Controls.Add(ticketInfo);
            Controls.Add(nameInput);
            Controls.Add(name);
            Name = "Bai5Payment";
            Text = "Bai5Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private TextBox nameInput;
        private Label ticketInfo;
        private Button finish;
        private Button back;
    }
}