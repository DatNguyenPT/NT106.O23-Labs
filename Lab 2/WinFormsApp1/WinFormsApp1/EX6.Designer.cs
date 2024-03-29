namespace WinFormsApp1
{
    partial class EX6
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
            foodBoard = new ListView();
            foodImage = new ImageList(components);
            randomButton = new Button();
            result = new Label();
            foodBoardResult = new ListView();
            foodImageResult = new ImageList(components);
            SuspendLayout();
            // 
            // foodBoard
            // 
            foodBoard.Location = new Point(61, 12);
            foodBoard.Name = "foodBoard";
            foodBoard.Size = new Size(656, 278);
            foodBoard.TabIndex = 0;
            foodBoard.UseCompatibleStateImageBehavior = false;
            // 
            // foodImage
            // 
            foodImage.ColorDepth = ColorDepth.Depth8Bit;
            foodImage.ImageSize = new Size(16, 16);
            foodImage.TransparentColor = Color.Transparent;
            // 
            // randomButton
            // 
            randomButton.Location = new Point(325, 296);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(136, 34);
            randomButton.TabIndex = 1;
            randomButton.Text = "Random";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomClick;
            // 
            // result
            // 
            result.Location = new Point(267, 333);
            result.Name = "result";
            result.Size = new Size(272, 22);
            result.TabIndex = 2;
            result.Text = "Hôm nay ăn: ";
            // 
            // foodBoardResult
            // 
            foodBoardResult.Location = new Point(545, 317);
            foodBoardResult.Name = "foodBoardResult";
            foodBoardResult.Size = new Size(151, 121);
            foodBoardResult.TabIndex = 3;
            foodBoardResult.UseCompatibleStateImageBehavior = false;
            // 
            // foodImageResult
            // 
            foodImageResult.ColorDepth = ColorDepth.Depth8Bit;
            foodImageResult.ImageSize = new Size(16, 16);
            foodImageResult.TransparentColor = Color.Transparent;
            // 
            // EX6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(foodBoardResult);
            Controls.Add(result);
            Controls.Add(randomButton);
            Controls.Add(foodBoard);
            Name = "EX6";
            Text = "EX6";
            ResumeLayout(false);
        }

        #endregion

        private ListView foodBoard;
        private ImageList foodImage;
        private Button randomButton;
        private Label result;
        private ListView foodBoardResult;
        private ImageList foodImageResult;
    }
}