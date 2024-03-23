namespace WinFormsApp1
{
    partial class Menu
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
            Ex1 = new Button();
            Ex2 = new Button();
            Ex3 = new Button();
            Ex4 = new Button();
            Ex5 = new Button();
            Ex6 = new Button();
            Ex7 = new Button();
            SuspendLayout();
            // 
            // Ex1
            // 
            Ex1.Location = new Point(186, 60);
            Ex1.Name = "Ex1";
            Ex1.Size = new Size(123, 44);
            Ex1.TabIndex = 0;
            Ex1.Text = "Ex1";
            Ex1.UseVisualStyleBackColor = true;
            Ex1.Click += Bai1;
            // 
            // Ex2
            // 
            Ex2.Location = new Point(186, 159);
            Ex2.Name = "Ex2";
            Ex2.Size = new Size(123, 49);
            Ex2.TabIndex = 1;
            Ex2.Text = "Ex2";
            Ex2.UseVisualStyleBackColor = true;
            // 
            // Ex3
            // 
            Ex3.Location = new Point(186, 253);
            Ex3.Name = "Ex3";
            Ex3.Size = new Size(123, 44);
            Ex3.TabIndex = 2;
            Ex3.Text = "Ex3";
            Ex3.UseVisualStyleBackColor = true;
            // 
            // Ex4
            // 
            Ex4.Location = new Point(493, 60);
            Ex4.Name = "Ex4";
            Ex4.Size = new Size(128, 44);
            Ex4.TabIndex = 3;
            Ex4.Text = "Ex4";
            Ex4.UseVisualStyleBackColor = true;
            // 
            // Ex5
            // 
            Ex5.Location = new Point(493, 159);
            Ex5.Name = "Ex5";
            Ex5.Size = new Size(128, 49);
            Ex5.TabIndex = 4;
            Ex5.Text = "Ex5";
            Ex5.UseVisualStyleBackColor = true;
            // 
            // Ex6
            // 
            Ex6.Location = new Point(493, 253);
            Ex6.Name = "Ex6";
            Ex6.Size = new Size(128, 44);
            Ex6.TabIndex = 5;
            Ex6.Text = "Ex6";
            Ex6.UseVisualStyleBackColor = true;
            // 
            // Ex7
            // 
            Ex7.Location = new Point(329, 344);
            Ex7.Name = "Ex7";
            Ex7.Size = new Size(128, 43);
            Ex7.TabIndex = 6;
            Ex7.Text = "Ex7";
            Ex7.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ex7);
            Controls.Add(Ex6);
            Controls.Add(Ex5);
            Controls.Add(Ex4);
            Controls.Add(Ex3);
            Controls.Add(Ex2);
            Controls.Add(Ex1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button Ex1;
        private Button Ex2;
        private Button Ex3;
        private Button Ex4;
        private Button Ex5;
        private Button Ex6;
        private Button Ex7;

        private void Bai1(object sender, EventArgs e)
        {
            EX1 ex1 = new EX1();
            ex1.Show();
        }
    }
}