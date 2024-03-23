namespace WinFormsApp1
{
    partial class EX3
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
            read = new Button();
            write = new Button();
            fileContents = new Label();
            filePathInput = new TextBox();
            filePath = new Label();
            SuspendLayout();
            // 
            // read
            // 
            read.Location = new Point(94, 89);
            read.Name = "read";
            read.Size = new Size(139, 51);
            read.TabIndex = 0;
            read.Text = "Đọc";
            read.UseVisualStyleBackColor = true;
            read.Click += readClick;
            // 
            // write
            // 
            write.Location = new Point(94, 243);
            write.Name = "write";
            write.Size = new Size(139, 53);
            write.TabIndex = 1;
            write.Text = "Ghi";
            write.UseVisualStyleBackColor = true;
            write.Click += writeClick;
            // 
            // fileContents
            // 
            fileContents.BorderStyle = BorderStyle.FixedSingle;
            fileContents.Location = new Point(358, 37);
            fileContents.Name = "fileContents";
            fileContents.Size = new Size(413, 274);
            fileContents.TabIndex = 3;
            // 
            // filePathInput
            // 
            filePathInput.Location = new Point(76, 392);
            filePathInput.Name = "filePathInput";
            filePathInput.Size = new Size(661, 27);
            filePathInput.TabIndex = 4;
            // 
            // filePath
            // 
            filePath.AutoSize = true;
            filePath.Location = new Point(365, 347);
            filePath.Name = "filePath";
            filePath.Size = new Size(50, 20);
            filePath.TabIndex = 5;
            filePath.Text = "Đường dẫn file";
            // 
            // Ex3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(filePath);
            Controls.Add(filePathInput);
            Controls.Add(fileContents);
            Controls.Add(write);
            Controls.Add(read);
            Name = "Ex3";
            Text = "Ex3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button read;
        private Button write;
        private Label fileContents;
        private TextBox filePathInput;
        private Label filePath;
    }
}