namespace Lab3
{
    partial class Bai1
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
            this.btnUDP_Client = new System.Windows.Forms.Button();
            this.btnUDP_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUDP_Client
            // 
            this.btnUDP_Client.Location = new System.Drawing.Point(89, 173);
            this.btnUDP_Client.Name = "btnUDP_Client";
            this.btnUDP_Client.Size = new System.Drawing.Size(200, 51);
            this.btnUDP_Client.TabIndex = 0;
            this.btnUDP_Client.Text = "UDP Client";
            this.btnUDP_Client.UseVisualStyleBackColor = true;
            this.btnUDP_Client.Click += new System.EventHandler(this.btnUDP_Click);
            // 
            // btnUDP_server
            // 
            this.btnUDP_server.Location = new System.Drawing.Point(458, 173);
            this.btnUDP_server.Name = "btnUDP_server";
            this.btnUDP_server.Size = new System.Drawing.Size(200, 51);
            this.btnUDP_server.TabIndex = 1;
            this.btnUDP_server.Text = "UDP Server";
            this.btnUDP_server.UseVisualStyleBackColor = true;
            this.btnUDP_server.Click += new System.EventHandler(this.btnUDP_server_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUDP_server);
            this.Controls.Add(this.btnUDP_Client);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.Bai1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUDP_Client;
        private System.Windows.Forms.Button btnUDP_server;
    }
}