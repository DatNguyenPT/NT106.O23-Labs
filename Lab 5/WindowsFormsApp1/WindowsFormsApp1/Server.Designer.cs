namespace WindowsFormsApp1
{
    partial class Server
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
            this.WelcomeText = new System.Windows.Forms.Label();
            this.mailList = new System.Windows.Forms.ListView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.imageResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageResult)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeText
            // 
            this.WelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WelcomeText.Location = new System.Drawing.Point(286, 24);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(226, 60);
            this.WelcomeText.TabIndex = 0;
            this.WelcomeText.Text = "HÔM NAY ĂN GÌ ?";
            // 
            // mailList
            // 
            this.mailList.HideSelection = false;
            this.mailList.Location = new System.Drawing.Point(12, 76);
            this.mailList.Name = "mailList";
            this.mailList.Size = new System.Drawing.Size(663, 629);
            this.mailList.TabIndex = 1;
            this.mailList.UseCompatibleStateImageBehavior = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(782, 136);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(123, 84);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "READ AND SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += readAndSaveClick;
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(782, 240);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(123, 84);
            this.randomBtn.TabIndex = 3;
            this.randomBtn.Text = "RANDOM";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += random;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(699, 378);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(85, 16);
            this.result.TabIndex = 4;
            this.result.Text = "Hôm nay ăn: ";
            // 
            // imageResult
            // 
            this.imageResult.Location = new System.Drawing.Point(702, 409);
            this.imageResult.Name = "imageResult";
            this.imageResult.Size = new System.Drawing.Size(265, 222);
            this.imageResult.TabIndex = 5;
            this.imageResult.TabStop = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 717);
            this.Controls.Add(this.imageResult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.mailList);
            this.Controls.Add(this.WelcomeText);
            this.Name = "Server";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.ListView mailList;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox imageResult;
    }
}

