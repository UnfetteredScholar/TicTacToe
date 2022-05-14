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
        Bitmap imageD = Properties.Resources.imgDefault;
        Bitmap imageO = Properties.Resources.imgO;
        Bitmap imageX = Properties.Resources.imgX;
        Grid grid = new Grid();

        public Form1()
        {
            InitializeComponent();

        }

        private void ResetGame()
        { 
            grid.ResetGrid();
            lb_cPlayer.Text = "Player 1";
            pb_GB00.Image = Properties.Resources.imgDefault;
            pb_GB01.Image = Properties.Resources.imgDefault;
            pb_GB02.Image = Properties.Resources.imgDefault;
            pb_GB10.Image = Properties.Resources.imgDefault;
            pb_GB11.Image = Properties.Resources.imgDefault;
            pb_GB12.Image = Properties.Resources.imgDefault;
            pb_GB20.Image = Properties.Resources.imgDefault;
            pb_GB21.Image = Properties.Resources.imgDefault;
            pb_GB22.Image = Properties.Resources.imgDefault;
        }

        private void pb_GB00_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB00.SizeMode = PictureBoxSizeMode.CenterImage;

            if(grid.GetBoxValue(0,0)==GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB00.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(0, 0);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB00.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(0, 0);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if(winner== PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if(winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if(winner ==PLAYER.P0)
            {
                if(grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }

        }
        private void pb_GB01_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB01.SizeMode = PictureBoxSizeMode.CenterImage;

            if (grid.GetBoxValue(0, 1) == GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB01.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(0, 1);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB01.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(0, 1);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if (winner == PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P0)
            {
                if (grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }
        }
        private void pb_GB02_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB02.SizeMode = PictureBoxSizeMode.CenterImage;

            if (grid.GetBoxValue(0, 2) == GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB02.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(0, 2);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB02.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(0, 2);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if (winner == PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P0)
            {
                if (grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }

        }
        private void pb_GB10_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB10.SizeMode = PictureBoxSizeMode.CenterImage;

            if (grid.GetBoxValue(1, 0) == GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB10.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(1, 0);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB10.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(1, 0);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if (winner == PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P0)
            {
                if (grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }

        }
        private void pb_GB11_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB11.SizeMode = PictureBoxSizeMode.CenterImage;

            if (grid.GetBoxValue(1, 1) == GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB11.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(1, 1);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB11.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(1, 1);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if (winner == PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P0)
            {
                if (grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }
        }
        private void pb_GB12_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB12.SizeMode = PictureBoxSizeMode.CenterImage;

            if (grid.GetBoxValue(1, 2) == GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB12.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(1, 2);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB12.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(1, 2);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if (winner == PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P0)
            {
                if (grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }

        }
        private void pb_GB20_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB20.SizeMode = PictureBoxSizeMode.CenterImage;

            if (grid.GetBoxValue(2, 0) == GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB20.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(2, 0);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB20.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(2, 0);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if (winner == PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P0)
            {
                if (grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }
        }
        private void pb_GB21_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB21.SizeMode = PictureBoxSizeMode.CenterImage;

            if (grid.GetBoxValue(2, 1) == GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB21.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(2, 1);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB21.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(2, 1);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if (winner == PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P0)
            {
                if (grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }
        }
        private void pb_GB22_Click(object sender, EventArgs e)
        {
            PLAYER winner;
            pb_GB22.SizeMode = PictureBoxSizeMode.CenterImage;

            if (grid.GetBoxValue(2, 2) == GVALUE.FREE)
            {
                if (grid.GetCurrentPlayer() == PLAYER.P1)
                {
                    pb_GB22.Image = imageX;
                    lb_cPlayer.Text = "Player 2";
                    grid.SetGridBox(2, 2);

                }
                else if (grid.GetCurrentPlayer() == PLAYER.P2)
                {
                    pb_GB22.Image = imageO;
                    lb_cPlayer.Text = "Player 1";
                    grid.SetGridBox(2, 2);
                }
            }
            else
            {
                MessageBox.Show("Box Not Free!!");
            }

            winner = grid.CheckWinner();

            if (winner == PLAYER.P1)
            {
                MessageBox.Show("Player 1 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P2)
            {
                MessageBox.Show("Player 2 Wins!");
                ResetGame();
            }
            else if (winner == PLAYER.P0)
            {
                if (grid.CheckDraw() == true)
                {
                    MessageBox.Show("Draw!");
                    ResetGame();
                }
            }
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            grid.ResetGrid();
            lb_cPlayer.Text = "Player 1";
            pb_GB00.Image = Properties.Resources.imgDefault;
            pb_GB01.Image = Properties.Resources.imgDefault;
            pb_GB02.Image = Properties.Resources.imgDefault;
            pb_GB10.Image = Properties.Resources.imgDefault;
            pb_GB11.Image = Properties.Resources.imgDefault;
            pb_GB12.Image = Properties.Resources.imgDefault;
            pb_GB20.Image = Properties.Resources.imgDefault;
            pb_GB21.Image = Properties.Resources.imgDefault;
            pb_GB22.Image = Properties.Resources.imgDefault;

        }
    }
}
