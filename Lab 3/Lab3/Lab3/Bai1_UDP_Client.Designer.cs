using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    partial class Bai1_UDP_Client
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
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_ip_add = new System.Windows.Forms.TextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.lb_ipadd = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.labelmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(29, 161);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(147, 38);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click_1);
            // 
            // txt_ip_add
            // 
            this.txt_ip_add.Location = new System.Drawing.Point(29, 27);
            this.txt_ip_add.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ip_add.Name = "txt_ip_add";
            this.txt_ip_add.Size = new System.Drawing.Size(169, 22);
            this.txt_ip_add.TabIndex = 2;
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(29, 115);
            this.txt_send.Margin = new System.Windows.Forms.Padding(2);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(498, 22);
            this.txt_send.TabIndex = 3;
            // 
            // lb_ipadd
            // 
            this.lb_ipadd.AutoSize = true;
            this.lb_ipadd.Location = new System.Drawing.Point(26, 9);
            this.lb_ipadd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ipadd.Name = "lb_ipadd";
            this.lb_ipadd.Size = new System.Drawing.Size(75, 16);
            this.lb_ipadd.TabIndex = 5;
            this.lb_ipadd.Text = "IP address:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(255, 9);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(34, 16);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Port:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(258, 27);
            this.txt_port.Margin = new System.Windows.Forms.Padding(2);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(169, 22);
            this.txt_port.TabIndex = 7;
            // 
            // labelmessage
            // 
            this.labelmessage.AutoSize = true;
            this.labelmessage.Location = new System.Drawing.Point(35, 87);
            this.labelmessage.Name = "labelmessage";
            this.labelmessage.Size = new System.Drawing.Size(64, 16);
            this.labelmessage.TabIndex = 8;
            this.labelmessage.Text = "Message";
            // 
            // Bai1_UDP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 247);
            this.Controls.Add(this.labelmessage);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lb_ipadd);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.txt_ip_add);
            this.Controls.Add(this.btn_send);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai1_UDP_Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Bai1_UDP_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_send;
        private TextBox txt_ip_add;
        private TextBox txt_send;
        private Label lb_ipadd;
        private Label lblPort;
        private TextBox txt_port;
        private Label labelmessage;
    }
}