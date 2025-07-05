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
        byte[,] TicTacToe = new byte[3, 3];
        void IncrementClickCounter()
        {
            ClickCounter++;
            if (ClickCounter == 9)
            {
                MessageBox.Show("Game Over!");
                l_Winner.Text = "Draw";
                ClickCounter = 0;
            }
        }
         byte Game(System.Windows.Forms.PictureBox picture)
        {
            if (picture.Image?.Tag?.ToString() =="question"  )
            {
                if (ClickCounter % 2 == 0)
                {
                    l_Players.Text = "Player 1";
                    picture.Image = Properties.Resources.X;
                    picture.Tag = "X";
                    IncrementClickCounter();
                    return 1;
                }
                else
                {
                    l_Players.Text = "Player 2";
                    picture.Image = Properties.Resources.O;
                    picture.Tag = "O";
                    IncrementClickCounter();
                    return 2;
                }
            }
            else
            {
                if (picture.Image?.Tag?.ToString()=="X")
                {
                    return 1;
                }
                else if (picture.Image?.Tag?.ToString() == "O")
                {
                    return 2;
                }
            }
            return 0;
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
            TicTacToe[0, 0] = Game(pb00);
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            TicTacToe[0, 1] = Game(pb01);
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            TicTacToe[0, 2] = Game(pb02);
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            TicTacToe[1, 0] = Game(pb10);
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            TicTacToe[1, 1] = Game(pb11);
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            TicTacToe[1, 2] = Game(pb12);
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            TicTacToe[2, 0] = Game(pb20);
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            TicTacToe[2, 1] = Game(pb21);
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            TicTacToe[2, 2] = Game(pb22);
        }
    }
}
