using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool FirstPlayer = true;
        Image Ximage = Properties.Resources.X;
        Image Oimage = Properties.Resources.O;
        Image QuestionMark = Properties.Resources.question_mark_96;

        void UpdateInfo(object sender)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                if (FirstPlayer)
                {
                    lbPlayers.Text = "Player 2";
                    pictureBox.Image = Ximage;
                }
                else
                {
                    lbPlayers.Text = "Player 1";
                    pictureBox.Image = Oimage;
                }
                pictureBox.Enabled = false; 
                FirstPlayer = !FirstPlayer; 
                CheckWinner(); 
            }
        }

        void CheckWinner()
        {
            if (CheckWin(Ximage))
            {
                ChangeColorLine(Ximage);
                lbWinner.Text = "Player 1";
                lbPlayers.Text = "Game Over";
                if(MessageBox.Show("Player 1 wins! ,Do you Want reset a game ?" , "Game Over" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
                {
ResetGame();
                }
                    
            }
            else if (CheckWin(Oimage))
            {
                ChangeColorLine(Oimage);
                lbWinner.Text = "Player 2";
                lbPlayers.Text = "Game Over";

                if (MessageBox.Show("Player 2 wins! ,Do you Want reset a game ?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetGame();
                }
                ResetGame(); 
            }
            else if(DrawGame())
            {
                lbWinner.Text = "Draw";
                lbPlayers.Text = "Game Over";
                if (MessageBox.Show("No Player wins! ,Do you Want reset a game ?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetGame();
                }
            }
        }
        bool DrawGame()
        {
            return (Position1.Enabled == false && Position2.Enabled == false && Position3.Enabled == false &&
                Position4.Enabled == false && Position5.Enabled == false && Position6.Enabled == false &&
                Position7.Enabled == false && Position8.Enabled == false && Position9.Enabled == false);
        }
        bool CheckWin(Image imageR)
        {
            return ((Position1.Image == imageR && Position2.Image == imageR && Position3.Image == imageR) ||
                    (Position4.Image == imageR && Position5.Image == imageR && Position6.Image == imageR) ||
                    (Position7.Image == imageR && Position8.Image == imageR && Position9.Image == imageR) ||
                    (Position1.Image == imageR && Position4.Image == imageR && Position7.Image == imageR) ||
                    (Position2.Image == imageR && Position5.Image == imageR && Position8.Image == imageR) ||
                    (Position3.Image == imageR && Position6.Image == imageR && Position9.Image == imageR) ||
                    (Position1.Image == imageR && Position5.Image == imageR && Position9.Image == imageR) ||
                    (Position3.Image == imageR && Position5.Image == imageR && Position7.Image == imageR));
        }
        void ChangeColorLine(Image imageR)
        {
            if (Position1.Image == imageR && Position2.Image == imageR && Position3.Image == imageR)
            {
                Position1.BackColor = System.Drawing.Color.Green;
                Position2.BackColor = System.Drawing.Color.Green;
                Position3.BackColor = System.Drawing.Color.Green;
            }
            else if (Position4.Image == imageR && Position5.Image == imageR && Position6.Image == imageR)
            {
                Position4.BackColor = System.Drawing.Color.Green;
                Position5.BackColor = System.Drawing.Color.Green;
                Position6.BackColor = System.Drawing.Color.Green;
            }
            else if (Position7.Image == imageR && Position8.Image == imageR && Position9.Image == imageR)
            {
                Position7.BackColor = System.Drawing.Color.Green;
                Position8.BackColor = System.Drawing.Color.Green;
                Position9.BackColor = System.Drawing.Color.Green;
            }
            else if (Position1.Image == imageR && Position4.Image == imageR && Position7.Image == imageR)
            {
                Position1.BackColor = System.Drawing.Color.Green;
                Position4.BackColor = System.Drawing.Color.Green;
                Position7.BackColor = System.Drawing.Color.Green;
            }
            else if (Position2.Image == imageR && Position5.Image == imageR && Position8.Image == imageR)
            {
                Position2.BackColor = System.Drawing.Color.Green;
                Position5.BackColor = System.Drawing.Color.Green;
                Position8.BackColor = System.Drawing.Color.Green;
            }
            else if (Position3.Image == imageR && Position6.Image == imageR && Position9.Image == imageR)
            {
                Position3.BackColor = System.Drawing.Color.Green;
                Position6.BackColor = System.Drawing.Color.Green;
                Position9.BackColor = System.Drawing.Color.Green;
            }
            else if (Position1.Image == imageR && Position5.Image == imageR && Position9.Image == imageR)
            {
                Position1.BackColor = System.Drawing.Color.Green;
                Position5.BackColor = System.Drawing.Color.Green;
                Position9.BackColor = System.Drawing.Color.Green;
            }
            else if (Position3.Image == imageR && Position5.Image == imageR && Position7.Image == imageR)
            {
                Position3.BackColor = System.Drawing.Color.Green;
                Position5.BackColor = System.Drawing.Color.Green;
                Position7.BackColor = System.Drawing.Color.Green;
            }
        }

        private void ResetGame()
        {
            
            Position1.Image = QuestionMark;
            Position1.Enabled = true;
            Position2.Image = QuestionMark;
            Position2.Enabled = true;
            Position3.Image = QuestionMark;
            Position3.Enabled = true;
            Position4.Image = QuestionMark;
            Position4.Enabled = true;
            Position5.Image = QuestionMark;
            Position5.Enabled = true;
            Position6.Image = QuestionMark;
            Position6.Enabled = true;
            Position7.Image = QuestionMark;
            Position7.Enabled = true;
            Position8.Image = QuestionMark;
            Position8.Enabled = true;
            Position9.Image = QuestionMark;
            Position9.Enabled = true;
            Position1.BackColor = System.Drawing.Color.Transparent;
            Position2.BackColor = System.Drawing.Color.Transparent;
            Position3.BackColor = System.Drawing.Color.Transparent;
            Position4.BackColor = System.Drawing.Color.Transparent;
            Position5.BackColor = System.Drawing.Color.Transparent;
            Position6.BackColor = System.Drawing.Color.Transparent;
            Position7.BackColor = System.Drawing.Color.Transparent;
            Position8.BackColor = System.Drawing.Color.Transparent;
            Position9.BackColor = System.Drawing.Color.Transparent;


            FirstPlayer = true;
            lbWinner.Text = "In Progress";
            lbPlayers.Text = "Player 1";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

           
            e.Graphics.DrawLine(pen, new Point(450, 80), new Point(450, 450));
            e.Graphics.DrawLine(pen, new Point(580, 80), new Point(580, 450));

            
            e.Graphics.DrawLine(pen, new Point(320, 200), new Point(700, 200));
            e.Graphics.DrawLine(pen, new Point(320, 340), new Point(700, 340));
        }

     
        private void Position1_Click(object sender, EventArgs e) { UpdateInfo(sender); }
        private void Position2_Click(object sender, EventArgs e) { UpdateInfo(sender); }
        private void Position3_Click(object sender, EventArgs e) { UpdateInfo(sender); }
        private void Position4_Click(object sender, EventArgs e) { UpdateInfo(sender); }
        private void Position5_Click(object sender, EventArgs e) { UpdateInfo(sender); }
        private void Position6_Click(object sender, EventArgs e) { UpdateInfo(sender); }
        private void Position7_Click(object sender, EventArgs e) { UpdateInfo(sender); }
        private void Position8_Click(object sender, EventArgs e) { UpdateInfo(sender); }
        private void Position9_Click(object sender, EventArgs e) { UpdateInfo(sender); }

        private void Form1_Load(object sender, EventArgs e) { }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/benhamida24244");
        }

    }
}
