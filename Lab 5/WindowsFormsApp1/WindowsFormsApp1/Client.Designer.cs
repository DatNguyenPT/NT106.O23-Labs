namespace WindowsFormsApp1
{
    partial class Client
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
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.fromInput = new System.Windows.Forms.TextBox();
            this.toInput = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.Label();
            this.bodyInput = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.selectImageBtn = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(47, 58);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(76, 21);
            this.from.TabIndex = 0;
            this.from.Text = "FROM";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(47, 96);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(118, 21);
            this.to.TabIndex = 1;
            this.to.Text = "TO";
            // 
            // fromInput
            // 
            this.fromInput.Location = new System.Drawing.Point(129, 57);
            this.fromInput.Name = "fromInput";
            this.fromInput.Size = new System.Drawing.Size(258, 22);
            this.fromInput.TabIndex = 2;
            // 
            // toInput
            // 
            this.toInput.Location = new System.Drawing.Point(129, 93);
            this.toInput.Name = "toInput";
            this.toInput.Size = new System.Drawing.Size(258, 22);
            this.toInput.TabIndex = 3;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(47, 144);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(44, 16);
            this.title.TabIndex = 4;
            this.title.Text = "TITLE";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(129, 138);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(258, 22);
            this.titleInput.TabIndex = 5;
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(47, 186);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(54, 15);
            this.body.TabIndex = 6;
            this.body.Text = "BODY";
            // 
            // bodyInput
            // 
            this.bodyInput.Location = new System.Drawing.Point(129, 183);
            this.bodyInput.Name = "bodyInput";
            this.bodyInput.Size = new System.Drawing.Size(497, 282);
            this.bodyInput.TabIndex = 8;
            this.bodyInput.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(641, 240);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(119, 71);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += sendEmailClick;
            // 
            // selectImageBtn
            // 
            this.selectImageBtn.Location = new System.Drawing.Point(641, 336);
            this.selectImageBtn.Name = "selectImageBtn";
            this.selectImageBtn.Size = new System.Drawing.Size(119, 68);
            this.selectImageBtn.TabIndex = 10;
            this.selectImageBtn.Text = "IMAGE";
            this.selectImageBtn.UseVisualStyleBackColor = true;
            this.selectImageBtn.Click += selectImage;
            // 
            // images
            // 
            this.images.Location = new System.Drawing.Point(129, 471);
            this.images.Name = "images";
            this.images.Size = new System.Drawing.Size(497, 239);
            this.images.TabIndex = 11;
            this.images.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 735);
            this.Controls.Add(this.images);
            this.Controls.Add(this.selectImageBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.bodyInput);
            this.Controls.Add(this.body);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.title);
            this.Controls.Add(this.toInput);
            this.Controls.Add(this.fromInput);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.TextBox fromInput;
        private System.Windows.Forms.TextBox toInput;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label body;
        private System.Windows.Forms.RichTextBox bodyInput;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button selectImageBtn;
        private System.Windows.Forms.PictureBox images;
    }
}