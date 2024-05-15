namespace Lab3
{
    partial class Bai3_TCP_Server
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
            this.listen = new System.Windows.Forms.Button();
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listen
            // 
            this.listen.AutoSize = true;
            this.listen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listen.Location = new System.Drawing.Point(460, 55);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(107, 32);
            this.listen.TabIndex = 0;
            this.listen.Text = "Listen ";
            this.listen.UseVisualStyleBackColor = false;
            // 
            // listViewCommand
            // 
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(22, 104);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(545, 325);
            this.listViewCommand.TabIndex = 1;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.View = System.Windows.Forms.View.List;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(674, 304);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(474, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(234, 65);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(474, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(234, 65);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Bai3_TCP_Server
            // 
            this.ClientSize = new System.Drawing.Size(720, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.listView1);
            this.Name = "Bai3_TCP_Server";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnClose;
    }
}