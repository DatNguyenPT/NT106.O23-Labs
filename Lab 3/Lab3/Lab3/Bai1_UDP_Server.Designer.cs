using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    partial class Bai1_UDP_Server
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
            this.lb_ipadd = new System.Windows.Forms.Label();
            this.txt_ip_add = new System.Windows.Forms.TextBox();
            this.btn_listen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lb_ipadd
            // 
            this.lb_ipadd.AutoSize = true;
            this.lb_ipadd.Location = new System.Drawing.Point(33, 36);
            this.lb_ipadd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ipadd.Name = "lb_ipadd";
            this.lb_ipadd.Size = new System.Drawing.Size(34, 16);
            this.lb_ipadd.TabIndex = 11;
            this.lb_ipadd.Text = "Port:";
            // 
            // txt_ip_add
            // 
            this.txt_ip_add.Location = new System.Drawing.Point(71, 30);
            this.txt_ip_add.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ip_add.Name = "txt_ip_add";
            this.txt_ip_add.Size = new System.Drawing.Size(115, 22);
            this.txt_ip_add.TabIndex = 8;
            // 
            // btn_listen
            // 
            this.btn_listen.Location = new System.Drawing.Point(483, 22);
            this.btn_listen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(120, 39);
            this.btn_listen.TabIndex = 6;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(483, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 33);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(24, 84);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(579, 163);
            this.listView.TabIndex = 13;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // Bai1_UDP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 332);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lb_ipadd);
            this.Controls.Add(this.txt_ip_add);
            this.Controls.Add(this.btn_listen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai1_UDP_Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Bai1_UDP_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_ipadd;
        private TextBox txt_ip_add;
        private Button btn_listen;
        private Button btnClose;
        private ListView listView;
    }
}