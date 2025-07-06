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
        void CheckWinner()
        {
            
                if (pb00.Tag == pb01.Tag && pb01.Tag == pb02.Tag && pb00.Tag!="question")
                {
                    ChangeBackColor(pb00, pb01, pb02);
                    WinnerPlayer(pb00);
                }
                if (pb10.Tag == pb11.Tag && pb11.Tag == pb12.Tag && pb10.Tag!="question")
                {
                    ChangeBackColor(pb10, pb11, pb12);
                    WinnerPlayer(pb10);
                }
                if (pb20.Tag == pb21.Tag && pb21.Tag == pb22.Tag && pb20.Tag!="question")
                {
                    ChangeBackColor(pb20, pb21, pb22);
                    WinnerPlayer(pb20);
                }
                if (pb00.Tag == pb10.Tag && pb10.Tag == pb20.Tag && pb00.Tag!="question")
                {
                    ChangeBackColor(pb00, pb10, pb20);
                    WinnerPlayer(pb00);
                }
                if (pb01.Tag == pb11.Tag && pb11.Tag == pb21.Tag && pb01.Tag != "question")
                {
                    ChangeBackColor(pb01, pb11, pb21);
                    WinnerPlayer(pb01);
                }
                if (pb02.Tag == pb12.Tag && pb12.Tag == pb22.Tag && pb02.Tag != "question")
                {
                    ChangeBackColor(pb02, pb12, pb22);
                    WinnerPlayer(pb02);
                }
                if (pb00.Tag == pb11.Tag && pb11.Tag == pb22.Tag && pb00.Tag != "question")
                {
                    ChangeBackColor(pb00, pb11, pb22);
                    WinnerPlayer(pb00);
                }
                if (pb02.Tag == pb11.Tag && pb11.Tag == pb20.Tag && pb02.Tag != "question")
                {
                    ChangeBackColor(pb02, pb11, pb20);
                    WinnerPlayer(pb02);
                }
            

        }
        void ResetBouton()
        {
            pb00.Image = Properties.Resources.question_mark_96;
            pb00.Tag = "question";
            pb00.BackColor = Color.Transparent;
            pb01.Image = Properties.Resources.question_mark_96;
            pb01.Tag = "question";
            pb01.BackColor = Color.Transparent;
            pb02.Image = Properties.Resources.question_mark_96;
            pb02.Tag = "question";
            pb02.BackColor = Color.Transparent;
            pb10.Image = Properties.Resources.question_mark_96;
            pb10.Tag = "question";
            pb10.BackColor = Color.Transparent;
            pb11.Image = Properties.Resources.question_mark_96;
            pb11.Tag = "question";
            pb11.BackColor = Color.Transparent;
            pb12.Image = Properties.Resources.question_mark_96;
            pb12.Tag = "question";
            pb12.BackColor = Color.Transparent;
            pb20.Image = Properties.Resources.question_mark_96;
            pb20.Tag = "question";
            pb20.BackColor = Color.Transparent;
            pb21.Image = Properties.Resources.question_mark_96;
            pb21.Tag = "question";
            pb21.BackColor = Color.Transparent;
            pb22.Image = Properties.Resources.question_mark_96;
            pb22.Tag = "question";
            pb22.BackColor = Color.Transparent;
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

        private void pb00_Click(object sender, EventArgs e)
        {
            Game(pb00);
            CheckWinner();
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            Game(pb01);
            CheckWinner();
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            Game(pb02);
            CheckWinner();
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            Game(pb10);
            CheckWinner();
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            Game(pb11);
            CheckWinner();
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            Game(pb12);
            CheckWinner();
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            Game(pb20);
            CheckWinner();
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            Game(pb21);
            CheckWinner();
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            Game(pb22);
            CheckWinner();
        }

        private void b_restart_Click(object sender, EventArgs e)
        {
            ResetBouton();
        }


    }
}
