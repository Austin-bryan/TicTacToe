namespace TicTacToe
{
    partial class TicTacToeButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainButton = new Button();
            SuspendLayout();
            // 
            // MainButton
            // 
            MainButton.FlatAppearance.BorderSize = 0;
            MainButton.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            MainButton.Location = new Point(0, 0);
            MainButton.Name = "MainButton";
            MainButton.Size = new Size(75, 75);
            MainButton.TabIndex = 0;
            MainButton.Text = "-";
            MainButton.UseVisualStyleBackColor = true;
            MainButton.Click += MainButton_Click;
            // 
            // TicTacToeButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainButton);
            Name = "TicTacToeButton";
            Size = new Size(75, 75);
            ResumeLayout(false);
        }

        #endregion

        private Button MainButton;
    }
}
