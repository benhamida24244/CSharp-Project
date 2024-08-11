
namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            this.rjButton1 = new WindowsFormsApp3.Controls.RJButton();
            this.Turn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton2 = new WindowsFormsApp3.Controls.RJButton();
            this.lbPlayers = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Position9 = new System.Windows.Forms.PictureBox();
            this.Position8 = new System.Windows.Forms.PictureBox();
            this.Position7 = new System.Windows.Forms.PictureBox();
            this.Position6 = new System.Windows.Forms.PictureBox();
            this.Position5 = new System.Windows.Forms.PictureBox();
            this.Position4 = new System.Windows.Forms.PictureBox();
            this.Position3 = new System.Windows.Forms.PictureBox();
            this.Position2 = new System.Windows.Forms.PictureBox();
            this.Position1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Position9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton1.BackColor = System.Drawing.Color.Black;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Black;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 25;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(30, 664);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(287, 89);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Follow Me X";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Turn
            // 
            this.Turn.AutoSize = true;
            this.Turn.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Turn.Location = new System.Drawing.Point(96, 271);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(147, 75);
            this.Turn.TabIndex = 2;
            this.Turn.Text = "Turn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(96, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "Winner";
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rjButton2.BackColor = System.Drawing.Color.Gainsboro;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.rjButton2.BorderColor = System.Drawing.Color.Black;
            this.rjButton2.BorderRadius = 25;
            this.rjButton2.BorderSize = 5;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(340, 664);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(287, 89);
            this.rjButton2.TabIndex = 4;
            this.rjButton2.Text = "Restart Game";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // lbPlayers
            // 
            this.lbPlayers.AutoSize = true;
            this.lbPlayers.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold);
            this.lbPlayers.ForeColor = System.Drawing.Color.Black;
            this.lbPlayers.Location = new System.Drawing.Point(101, 360);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(153, 48);
            this.lbPlayers.TabIndex = 5;
            this.lbPlayers.Text = "Player 1";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold);
            this.lbWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbWinner.Location = new System.Drawing.Point(110, 525);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(0, 48);
            this.lbWinner.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(480, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 75);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tic Tac Toe Game";
            // 
            // Position9
            // 
            this.Position9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position9.Location = new System.Drawing.Point(893, 516);
            this.Position9.Name = "Position9";
            this.Position9.Size = new System.Drawing.Size(149, 142);
            this.Position9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position9.TabIndex = 16;
            this.Position9.TabStop = false;
            this.Position9.Tag = "9";
            this.Position9.Click += new System.EventHandler(this.Position9_Click);
            // 
            // Position8
            // 
            this.Position8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position8.Location = new System.Drawing.Point(699, 516);
            this.Position8.Name = "Position8";
            this.Position8.Size = new System.Drawing.Size(149, 142);
            this.Position8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position8.TabIndex = 15;
            this.Position8.TabStop = false;
            this.Position8.Tag = "8";
            this.Position8.Click += new System.EventHandler(this.Position8_Click);
            // 
            // Position7
            // 
            this.Position7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position7.Location = new System.Drawing.Point(510, 516);
            this.Position7.Name = "Position7";
            this.Position7.Size = new System.Drawing.Size(149, 142);
            this.Position7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position7.TabIndex = 14;
            this.Position7.TabStop = false;
            this.Position7.Tag = "7";
            this.Position7.Click += new System.EventHandler(this.Position7_Click);
            // 
            // Position6
            // 
            this.Position6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position6.Location = new System.Drawing.Point(893, 329);
            this.Position6.Name = "Position6";
            this.Position6.Size = new System.Drawing.Size(149, 142);
            this.Position6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position6.TabIndex = 13;
            this.Position6.TabStop = false;
            this.Position6.Tag = "6";
            this.Position6.Click += new System.EventHandler(this.Position6_Click);
            // 
            // Position5
            // 
            this.Position5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position5.Location = new System.Drawing.Point(699, 329);
            this.Position5.Name = "Position5";
            this.Position5.Size = new System.Drawing.Size(149, 142);
            this.Position5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position5.TabIndex = 12;
            this.Position5.TabStop = false;
            this.Position5.Tag = "5";
            this.Position5.Click += new System.EventHandler(this.Position5_Click);
            // 
            // Position4
            // 
            this.Position4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position4.Location = new System.Drawing.Point(510, 329);
            this.Position4.Name = "Position4";
            this.Position4.Size = new System.Drawing.Size(149, 142);
            this.Position4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position4.TabIndex = 11;
            this.Position4.TabStop = false;
            this.Position4.Tag = "4";
            this.Position4.Click += new System.EventHandler(this.Position4_Click);
            // 
            // Position3
            // 
            this.Position3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position3.Location = new System.Drawing.Point(893, 136);
            this.Position3.Name = "Position3";
            this.Position3.Size = new System.Drawing.Size(149, 142);
            this.Position3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position3.TabIndex = 10;
            this.Position3.TabStop = false;
            this.Position3.Tag = "3";
            this.Position3.Click += new System.EventHandler(this.Position3_Click);
            // 
            // Position2
            // 
            this.Position2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position2.Location = new System.Drawing.Point(699, 136);
            this.Position2.Name = "Position2";
            this.Position2.Size = new System.Drawing.Size(149, 142);
            this.Position2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position2.TabIndex = 9;
            this.Position2.TabStop = false;
            this.Position2.Tag = "2";
            this.Position2.Click += new System.EventHandler(this.Position2_Click);
            // 
            // Position1
            // 
            this.Position1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.Position1.Location = new System.Drawing.Point(510, 136);
            this.Position1.Name = "Position1";
            this.Position1.Size = new System.Drawing.Size(149, 142);
            this.Position1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Position1.TabIndex = 8;
            this.Position1.TabStop = false;
            this.Position1.Tag = "1";
            this.Position1.Click += new System.EventHandler(this.Position1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.eL5YUMU__400x400;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1210, 787);
            this.Controls.Add(this.Position9);
            this.Controls.Add(this.Position8);
            this.Controls.Add(this.Position7);
            this.Controls.Add(this.Position6);
            this.Controls.Add(this.Position5);
            this.Controls.Add(this.Position4);
            this.Controls.Add(this.Position3);
            this.Controls.Add(this.Position2);
            this.Controls.Add(this.Position1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Turn);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.Position9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsApp3.Controls.RJButton rjButton1;
        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApp3.Controls.RJButton rjButton2;
        private System.Windows.Forms.Label lbPlayers;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Position1;
        private System.Windows.Forms.PictureBox Position2;
        private System.Windows.Forms.PictureBox Position3;
        private System.Windows.Forms.PictureBox Position4;
        private System.Windows.Forms.PictureBox Position5;
        private System.Windows.Forms.PictureBox Position6;
        private System.Windows.Forms.PictureBox Position7;
        private System.Windows.Forms.PictureBox Position8;
        private System.Windows.Forms.PictureBox Position9;
    }
}

