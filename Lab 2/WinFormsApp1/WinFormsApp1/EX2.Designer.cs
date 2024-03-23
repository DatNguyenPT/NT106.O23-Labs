namespace WinFormsApp1
{
    partial class EX2
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
            read = new Button();
            fileName = new Label();
            fileSize = new Label();
            filePath = new Label();
            lineCount = new Label();
            wordCount = new Label();
            charCount = new Label();
            fileNameResult = new Label();
            fileSizeResult = new Label();
            filePathResult = new Label();
            lineCountResult = new Label();
            wordCountResult = new Label();
            charCountResult = new Label();
            fileContent = new Label();
            SuspendLayout();
            // 
            // read
            // 
            read.Location = new Point(74, 27);
            read.Name = "read";
            read.Size = new Size(244, 41);
            read.TabIndex = 0;
            read.Text = "read";
            read.UseVisualStyleBackColor = true;
            // 
            // fileName
            // 
            fileName.Location = new Point(12, 112);
            fileName.Name = "fileName";
            fileName.Size = new Size(98, 26);
            fileName.TabIndex = 1;
            fileName.Text = "fileName";
            // 
            // fileSize
            // 
            fileSize.Location = new Point(12, 175);
            fileSize.Name = "fileSize";
            fileSize.Size = new Size(70, 23);
            fileSize.TabIndex = 2;
            fileSize.Text = "fileSize";
            // 
            // filePath
            // 
            filePath.Location = new Point(12, 229);
            filePath.Name = "filePath";
            filePath.Size = new Size(77, 24);
            filePath.TabIndex = 3;
            filePath.Text = "filePath";
            // 
            // lineCount
            // 
            lineCount.Location = new Point(12, 270);
            lineCount.Name = "lineCount";
            lineCount.Size = new Size(82, 25);
            lineCount.TabIndex = 4;
            lineCount.Text = "lineCount";
            // 
            // wordCount
            // 
            wordCount.Location = new Point(12, 316);
            wordCount.Name = "wordCount";
            wordCount.Size = new Size(97, 25);
            wordCount.TabIndex = 5;
            wordCount.Text = "wordCount";
            // 
            // charCount
            // 
            charCount.Location = new Point(8, 370);
            charCount.Name = "charCount";
            charCount.Size = new Size(101, 20);
            charCount.TabIndex = 6;
            charCount.Text = "charCount";
            // 
            // fileNameResult
            // 
            fileNameResult.BorderStyle = BorderStyle.FixedSingle;
            fileNameResult.Location = new Point(129, 112);
            fileNameResult.Name = "fileNameResult";
            fileNameResult.Size = new Size(168, 26);
            fileNameResult.TabIndex = 7;
            // 
            // fileSizeResult
            // 
            fileSizeResult.BorderStyle = BorderStyle.FixedSingle;
            fileSizeResult.Location = new Point(129, 168);
            fileSizeResult.Name = "fileSizeResult";
            fileSizeResult.Size = new Size(168, 30);
            fileSizeResult.TabIndex = 8;
            // 
            // filePathResult
            // 
            filePathResult.BorderStyle = BorderStyle.FixedSingle;
            filePathResult.Location = new Point(129, 219);
            filePathResult.Name = "filePathResult";
            filePathResult.Size = new Size(168, 33);
            filePathResult.TabIndex = 9;
            // 
            // lineCountResult
            // 
            lineCountResult.BorderStyle = BorderStyle.FixedSingle;
            lineCountResult.Location = new Point(129, 270);
            lineCountResult.Name = "lineCountResult";
            lineCountResult.Size = new Size(168, 25);
            lineCountResult.TabIndex = 10;
            // 
            // wordCountResult
            // 
            wordCountResult.BorderStyle = BorderStyle.FixedSingle;
            wordCountResult.Location = new Point(129, 310);
            wordCountResult.Name = "wordCountResult";
            wordCountResult.Size = new Size(168, 31);
            wordCountResult.TabIndex = 11;
            // 
            // charCountResult
            // 
            charCountResult.BorderStyle = BorderStyle.FixedSingle;
            charCountResult.Location = new Point(129, 362);
            charCountResult.Name = "charCountResult";
            charCountResult.Size = new Size(168, 28);
            charCountResult.TabIndex = 12;
            // 
            // fileContent
            // 
            fileContent.BorderStyle = BorderStyle.FixedSingle;
            fileContent.Location = new Point(393, 27);
            fileContent.Name = "fileContent";
            fileContent.Size = new Size(381, 400);
            fileContent.TabIndex = 13;
            // 
            // EX2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fileContent);
            Controls.Add(charCountResult);
            Controls.Add(wordCountResult);
            Controls.Add(lineCountResult);
            Controls.Add(filePathResult);
            Controls.Add(fileSizeResult);
            Controls.Add(fileNameResult);
            Controls.Add(charCount);
            Controls.Add(wordCount);
            Controls.Add(lineCount);
            Controls.Add(filePath);
            Controls.Add(fileSize);
            Controls.Add(fileName);
            Controls.Add(read);
            Name = "EX2";
            Text = "EX2";
            ResumeLayout(false);
        }

        #endregion

        private Button read;
        private Label fileName;
        private Label fileSize;
        private Label filePath;
        private Label lineCount;
        private Label wordCount;
        private Label charCount;
        private Label fileNameResult;
        private Label fileSizeResult;
        private Label filePathResult;
        private Label lineCountResult;
        private Label wordCountResult;
        private Label charCountResult;
        private Label fileContent;
    }
}