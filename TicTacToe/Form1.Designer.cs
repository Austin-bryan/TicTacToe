namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topRow = new FlowLayoutPanel();
            topRowButton_Left = new TicTacToeButton();
            topRowButton_Middle = new TicTacToeButton();
            topRowButton_Right = new TicTacToeButton();
            middleRow = new FlowLayoutPanel();
            middleRowButton_Left = new TicTacToeButton();
            middleRowButton_Middle = new TicTacToeButton();
            middleRowButton_Right = new TicTacToeButton();
            bottomRow = new FlowLayoutPanel();
            bottomRowButton_Left = new TicTacToeButton();
            bottomRowButton_Middle = new TicTacToeButton();
            bottomRowButton_Right = new TicTacToeButton();
            topRow.SuspendLayout();
            middleRow.SuspendLayout();
            bottomRow.SuspendLayout();
            SuspendLayout();
            // 
            // topRow
            // 
            topRow.Controls.Add(topRowButton_Left);
            topRow.Controls.Add(topRowButton_Middle);
            topRow.Controls.Add(topRowButton_Right);
            topRow.Location = new Point(12, 12);
            topRow.Name = "topRow";
            topRow.Size = new Size(248, 80);
            topRow.TabIndex = 3;
            // 
            // topRowButton_Left
            // 
            topRowButton_Left.ForeColor = SystemColors.ControlText;
            topRowButton_Left.Location = new Point(3, 3);
            topRowButton_Left.Name = "topRowButton_Left";
            topRowButton_Left.Size = new Size(75, 75);
            topRowButton_Left.TabIndex = 0;
            // 
            // topRowButton_Middle
            // 
            topRowButton_Middle.ForeColor = SystemColors.ControlText;
            topRowButton_Middle.Location = new Point(84, 3);
            topRowButton_Middle.Name = "topRowButton_Middle";
            topRowButton_Middle.Size = new Size(75, 75);
            topRowButton_Middle.TabIndex = 1;
            // 
            // topRowButton_Right
            // 
            topRowButton_Right.ForeColor = SystemColors.ControlText;
            topRowButton_Right.Location = new Point(165, 3);
            topRowButton_Right.Name = "topRowButton_Right";
            topRowButton_Right.Size = new Size(75, 75);
            topRowButton_Right.TabIndex = 2;
            // 
            // middleRow
            // 
            middleRow.Controls.Add(middleRowButton_Left);
            middleRow.Controls.Add(middleRowButton_Middle);
            middleRow.Controls.Add(middleRowButton_Right);
            middleRow.Location = new Point(12, 92);
            middleRow.Name = "middleRow";
            middleRow.Size = new Size(248, 80);
            middleRow.TabIndex = 4;
            // 
            // middleRowButton_Left
            // 
            middleRowButton_Left.ForeColor = SystemColors.ControlText;
            middleRowButton_Left.Location = new Point(3, 3);
            middleRowButton_Left.Name = "middleRowButton_Left";
            middleRowButton_Left.Size = new Size(75, 75);
            middleRowButton_Left.TabIndex = 0;
            // 
            // middleRowButton_Middle
            // 
            middleRowButton_Middle.ForeColor = SystemColors.ControlText;
            middleRowButton_Middle.Location = new Point(84, 3);
            middleRowButton_Middle.Name = "middleRowButton_Middle";
            middleRowButton_Middle.Size = new Size(75, 75);
            middleRowButton_Middle.TabIndex = 1;
            // 
            // middleRowButton_Right
            // 
            middleRowButton_Right.ForeColor = SystemColors.ControlText;
            middleRowButton_Right.Location = new Point(165, 3);
            middleRowButton_Right.Name = "middleRowButton_Right";
            middleRowButton_Right.Size = new Size(75, 75);
            middleRowButton_Right.TabIndex = 2;
            // 
            // bottomRow
            // 
            bottomRow.Controls.Add(bottomRowButton_Left);
            bottomRow.Controls.Add(bottomRowButton_Middle);
            bottomRow.Controls.Add(bottomRowButton_Right);
            bottomRow.Location = new Point(12, 172);
            bottomRow.Name = "bottomRow";
            bottomRow.Size = new Size(248, 80);
            bottomRow.TabIndex = 5;
            // 
            // bottomRowButton_Left
            // 
            bottomRowButton_Left.ForeColor = SystemColors.ControlText;
            bottomRowButton_Left.Location = new Point(3, 3);
            bottomRowButton_Left.Name = "bottomRowButton_Left";
            bottomRowButton_Left.Size = new Size(75, 75);
            bottomRowButton_Left.TabIndex = 0;
            // 
            // bottomRowButton_Middle
            // 
            bottomRowButton_Middle.ForeColor = SystemColors.ControlText;
            bottomRowButton_Middle.Location = new Point(84, 3);
            bottomRowButton_Middle.Name = "bottomRowButton_Middle";
            bottomRowButton_Middle.Size = new Size(75, 75);
            bottomRowButton_Middle.TabIndex = 1;
            // 
            // bottomRowButton_Right
            // 
            bottomRowButton_Right.ForeColor = SystemColors.ControlText;
            bottomRowButton_Right.Location = new Point(165, 3);
            bottomRowButton_Right.Name = "bottomRowButton_Right";
            bottomRowButton_Right.Size = new Size(75, 75);
            bottomRowButton_Right.TabIndex = 2;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 270);
            Controls.Add(middleRow);
            Controls.Add(topRow);
            Controls.Add(bottomRow);
            Name = "TicTacToe";
            Text = "Form1";
            Load += Form1_Load;
            topRow.ResumeLayout(false);
            middleRow.ResumeLayout(false);
            bottomRow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel topRow;
        private TicTacToeButton topRowButton_Left;
        private TicTacToeButton topRowButton_Middle;
        private TicTacToeButton topRowButton_Right;
        private FlowLayoutPanel middleRow;
        private TicTacToeButton middleRowButton_Left;
        private TicTacToeButton middleRowButton_Middle;
        private TicTacToeButton middleRowButton_Right;
        private FlowLayoutPanel bottomRow;
        private TicTacToeButton bottomRowButton_Left;
        private TicTacToeButton bottomRowButton_Middle;
        private TicTacToeButton bottomRowButton_Right;
    }
}
