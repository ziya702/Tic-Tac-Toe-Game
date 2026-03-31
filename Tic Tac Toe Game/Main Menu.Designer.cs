using System.Drawing.Drawing2D;

namespace Tic_Tac_Toe_Game
{
    partial class Main_Menu
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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(140, 180, 230);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 65);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(316, 216);
            button1.Name = "button1";
            button1.Padding = new Padding(8);
            button1.Size = new Size(210, 65);
            button1.TabIndex = 0;
            button1.Text = "2 Players";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 90, 90);
            label1.Location = new Point(249, 47);
            label1.Name = "label1";
            label1.Size = new Size(354, 81);
            label1.TabIndex = 2;
            label1.Text = "Tic-Tac-Toe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main_Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(250, 248, 235);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(label1);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimizeBox = false;
            MinimumSize = new Size(800, 500);
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe Game";
            Paint += Main_Menu_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}