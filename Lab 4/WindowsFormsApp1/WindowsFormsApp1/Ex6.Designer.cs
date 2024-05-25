namespace WindowsFormsApp1
{
    partial class Ex6
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.getInfo = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.username.Location = new System.Drawing.Point(33, 39);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(103, 19);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.password.Location = new System.Drawing.Point(33, 81);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 22);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            // 
            // url
            // 
            this.url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.url.Location = new System.Drawing.Point(33, 120);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(473, 27);
            this.url.TabIndex = 4;
            this.url.Text = "url";
            // 
            // getInfo
            // 
            this.getInfo.Location = new System.Drawing.Point(660, 50);
            this.getInfo.Name = "getInfo";
            this.getInfo.Size = new System.Drawing.Size(97, 79);
            this.getInfo.TabIndex = 5;
            this.getInfo.Text = "Get Info";
            this.getInfo.UseVisualStyleBackColor = true;
            // 
            // userInfo
            // 
            this.userInfo.BackColor = System.Drawing.Color.White;
            this.userInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfo.Location = new System.Drawing.Point(39, 204);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(700, 228);
            this.userInfo.TabIndex = 6;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(214, 35);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(292, 22);
            this.usernameInput.TabIndex = 7;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(214, 81);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(292, 22);
            this.passwordInput.TabIndex = 8;
            // 
            // Ex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.getInfo);
            this.Controls.Add(this.url);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Ex6";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Button getInfo;
        private System.Windows.Forms.Label userInfo;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
    }
}

