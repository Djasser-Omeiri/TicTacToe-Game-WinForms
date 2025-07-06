using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte ClickCounter = 0;
        void IncrementClickCounter()
        {
            ClickCounter++;
            if (ClickCounter == 9)
            {
                l_Players.Text = "Game Over";
                l_Winner.Text = "Draw";
            }
        }
        void Game(PictureBox picture)
        {
            if (picture.Tag != null && picture.Tag.ToString() == "question")
            {
                if (ClickCounter % 2 == 0)
                {
                    l_Players.Text = "Player 2";
                    picture.Image = Properties.Resources.X;
                    picture.Tag = "X";
                    IncrementClickCounter();
                }
                else
                {
                    l_Players.Text = "Player 1";
                    picture.Image = Properties.Resources.O;
                    picture.Tag = "O";
                    IncrementClickCounter();
                }
            }
        }
        void ChangeBackColor(PictureBox picture, PictureBox picture2, PictureBox picture3)
        {
            picture.BackColor = Color.WhiteSmoke;
            picture2.BackColor = Color.WhiteSmoke;
            picture3.BackColor = Color.WhiteSmoke;
        }
        void WinnerPlayer(PictureBox picture)
        {
            if (picture.Tag != null && picture.Tag.ToString() == "X")
            {
                l_playerwhowon.Text = "Player 1";

            }
            else if (picture.Tag != null && picture.Tag.ToString() == "O")
            {
                l_playerwhowon.Text = "Player 2";
            }
            l_Players.Text = "Game Over";
            l_Winner.Text = "Winner";
        }
        bool IsEqual(PictureBox picture, PictureBox picture2, PictureBox picture3)
        {
            if (picture.Tag != "question")
            {
                return picture.Tag == picture2.Tag && picture2.Tag == picture3.Tag;
            }
            return false;
        }
        void CheckWinner()
        {

            if (IsEqual(pb00, pb01, pb02))
            {
                ChangeBackColor(pb00, pb01, pb02);
                WinnerPlayer(pb00);
            }
            if (IsEqual(pb10, pb11, pb12))
            {
                ChangeBackColor(pb10, pb11, pb12);
                WinnerPlayer(pb10);
            }
            if (IsEqual(pb20, pb21, pb22))
            {
                ChangeBackColor(pb20, pb21, pb22);
                WinnerPlayer(pb20);
            }
            if (IsEqual(pb00, pb10, pb20))
            {
                ChangeBackColor(pb00, pb10, pb20);
                WinnerPlayer(pb00);
            }
            if (IsEqual(pb01, pb11, pb21))
            {
                ChangeBackColor(pb01, pb11, pb21);
                WinnerPlayer(pb01);
            }
            if (IsEqual(pb02, pb12, pb22))
            {
                ChangeBackColor(pb02, pb12, pb22);
                WinnerPlayer(pb02);
            }
            if (IsEqual(pb00, pb11, pb22))
            {
                ChangeBackColor(pb00, pb11, pb22);
                WinnerPlayer(pb00);
            }
            if (IsEqual(pb02, pb11, pb20))
            {
                ChangeBackColor(pb02, pb11, pb20);
                WinnerPlayer(pb02);
            }


        }
        void ResetOneBouton(PictureBox picture)
        {
            picture.Image = Properties.Resources.question_mark_96;
            picture.Tag = "question";
            picture.BackColor = Color.Transparent;
        }
        void ResetAllBoutons()
        {
            ResetOneBouton(pb00);
            ResetOneBouton(pb01);
            ResetOneBouton(pb02);
            ResetOneBouton(pb10);
            ResetOneBouton(pb11);
            ResetOneBouton(pb12);
            ResetOneBouton(pb20);
            ResetOneBouton(pb21);
            ResetOneBouton(pb22);
            l_Players.Text = "Player1";
            l_Winner.Text = " ";
            l_playerwhowon.Text = " ";
            ClickCounter = 0;


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = new Color();
            white = Color.FromArgb(255, 255, 255);
            Pen pen = new Pen(white, 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 250, 180, 700, 180);
            e.Graphics.DrawLine(pen, 250, 290, 700, 290);
            e.Graphics.DrawLine(pen, 400, 70, 400, 400);
            e.Graphics.DrawLine(pen, 550, 70, 550, 400);
        }

        private void pb_Click(object sender, EventArgs e)
        {
            Game((PictureBox)sender);
            CheckWinner();
        }

        private void b_restart_Click(object sender, EventArgs e)
        {
            ResetAllBoutons();
        }


    }
}
