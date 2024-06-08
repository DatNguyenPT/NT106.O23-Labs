using System;

namespace WindowsFormsApp1
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
            this.serverBtn = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverBtn
            // 
            this.serverBtn.Location = new System.Drawing.Point(158, 146);
            this.serverBtn.Name = "serverBtn";
            this.serverBtn.Size = new System.Drawing.Size(155, 96);
            this.serverBtn.TabIndex = 0;
            this.serverBtn.Text = "SERVER";
            this.serverBtn.UseVisualStyleBackColor = true;
            this.serverBtn.Click += ServerAuth;
            // 
            // clientBtn
            // 
            this.clientBtn.Location = new System.Drawing.Point(466, 146);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(155, 96);
            this.clientBtn.TabIndex = 1;
            this.clientBtn.Text = "CLIENT";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += ClientForm;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.serverBtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button serverBtn;
        private System.Windows.Forms.Button clientBtn;

        private void ServerAuth(object sender, EventArgs e)
        {
            Authentication auth = new Authentication();
            auth.Show();
        }

        private void ClientForm(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

    }
}