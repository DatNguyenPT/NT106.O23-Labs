namespace WinFormsApp1
{
    partial class EX1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            read = new Button();
            write = new Button();
            result = new RichTextBox();
            filePathInput = new TextBox();
            SuspendLayout();
            // 
            // read
            // 
            read.Location = new Point(51, 87);
            read.Name = "read";
            read.Size = new Size(157, 51);
            read.TabIndex = 0;
            read.Text = "Đọc File";
            read.UseVisualStyleBackColor = true;
            read.Click += readClick;
            // 
            // write
            // 
            write.Location = new Point(51, 255);
            write.Name = "write";
            write.Size = new Size(157, 51);
            write.TabIndex = 1;
            write.Text = "Ghi FIle";
            write.UseVisualStyleBackColor = true;
            write.Click += writeClick;
            // 
            // result
            // 
            result.Location = new Point(382, 57);
            result.Name = "result";
            result.Size = new Size(359, 285);
            result.TabIndex = 2;
            result.Text = "";
            // 
            // filePathInput
            // 
            filePathInput.Location = new Point(51, 384);
            filePathInput.Name = "filePathInput";
            filePathInput.Size = new Size(690, 27);
            filePathInput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(filePathInput);
            Controls.Add(result);
            Controls.Add(write);
            Controls.Add(read);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button read;
        private Button write;
        private RichTextBox result;
        private TextBox filePathInput;
    }
}