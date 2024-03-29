namespace WinFormsApp1
{
    partial class EX7
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
            components = new System.ComponentModel.Container();
            TreeDirectory = new System.Windows.Forms.TreeView();
            FilePictureContent = new System.Windows.Forms.PictureBox();
            txtFileContent = new System.Windows.Forms.RichTextBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)(FilePictureContent)).BeginInit();
            SuspendLayout();
            // 
            // TreeDirectory
            // 
            TreeDirectory.Location = new System.Drawing.Point(13, 12);
            TreeDirectory.Name = "TreeDirectory";
            TreeDirectory.Size = new System.Drawing.Size(764, 891);
            TreeDirectory.TabIndex = 0;
            TreeDirectory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(treeDirectory_NodeMouseClick);
            TreeDirectory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(treeDirectory_NodeMouseDoubleClick);
            // 
            // FilePictureContent
            // 
            FilePictureContent.Location = new System.Drawing.Point(783, 12);
            FilePictureContent.Name = "FilePictureContent";
            FilePictureContent.Size = new System.Drawing.Size(806, 891);
            FilePictureContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            FilePictureContent.TabIndex = 3;
            FilePictureContent.TabStop = false;
            FilePictureContent.Visible = false;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new System.Drawing.Point(783, 12);
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ReadOnly = true;
            txtFileContent.Size = new System.Drawing.Size(806, 891);
            txtFileContent.TabIndex = 4;
            txtFileContent.Text = "";
            txtFileContent.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Bai06
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(1601, 915);
            Controls.Add(FilePictureContent);
            Controls.Add(TreeDirectory);
            Controls.Add(txtFileContent);
            Name = "EX7";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(FilePictureContent)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TreeDirectory;
        private System.Windows.Forms.PictureBox FilePictureContent;
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}