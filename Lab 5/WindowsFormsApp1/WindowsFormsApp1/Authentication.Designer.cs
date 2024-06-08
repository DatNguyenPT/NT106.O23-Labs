namespace WindowsFormsApp1
{
    partial class Authentication
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
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.RichTextBox();
            this.passwordInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.email.Location = new System.Drawing.Point(60, 109);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(169, 38);
            this.email.TabIndex = 0;
            this.email.Text = "EMAIL";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.password.Location = new System.Drawing.Point(60, 169);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(218, 62);
            this.password.TabIndex = 1;
            this.password.Text = "PASSWORD";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(288, 285);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(140, 74);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += connectToServer;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(334, 109);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(418, 38);
            this.emailInput.TabIndex = 5;
            this.emailInput.Text = "";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(334, 169);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(418, 38);
            this.passwordInput.TabIndex = 6;
            this.passwordInput.Text = "";
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Name = "Authentication";
            this.Text = "Authentication";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.RichTextBox emailInput;
        private System.Windows.Forms.RichTextBox passwordInput;
    }
}