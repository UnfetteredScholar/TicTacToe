using System;
using System.Collections.Generic;
using System.Text;

//PLAYER 1= X
//PLAYER 2= O

namespace TicTacToe
{
    enum GVALUE { FREE=0, X=1, O=2};
    enum PLAYER { P0=0, P1=1, P2=2};
    class Grid
    {
        //public
        public Grid()
        {
            int i, j;
            //set all grid boxes to free
            for(i=0; i<3; i++)
            {
                for(j=0; j<3; j++)
                {
                    gBoxes[i, j] = GVALUE.FREE;
                }
            }
        }

        public PLAYER CheckWinner()
        {
            //ROW 1
            if((gBoxes[0,0]== gBoxes[0, 1]) && (gBoxes[0, 0] == gBoxes[0, 2]) && (gBoxes[0, 1] == gBoxes[0, 2]) && (gBoxes[0,0]!=GVALUE.FREE))
            {
                if(gBoxes[0, 0]==GVALUE.X)
                {
                    return PLAYER.P1;
                }
                else if(gBoxes[0, 0] == GVALUE.O)
                {
                    return PLAYER.P2;
                }
            }//ROW 2
            else if ((gBoxes[1, 0] == gBoxes[1, 1]) && (gBoxes[1, 0] == gBoxes[1, 2]) && (gBoxes[1, 1] == gBoxes[1, 2]) && (gBoxes[1, 0] != GVALUE.FREE))
            {
                if (gBoxes[1, 0] == GVALUE.X)
                {
                    return PLAYER.P1;
                }
                else if (gBoxes[1, 0] == GVALUE.O)
                {
                    return PLAYER.P2;
                }
            }//ROW 2
            else if ((gBoxes[2, 0] == gBoxes[2, 1]) && (gBoxes[2, 0] == gBoxes[2, 2]) && (gBoxes[2, 1] == gBoxes[2, 2]) && (gBoxes[2, 0] != GVALUE.FREE))
            {
                if (gBoxes[2, 0] == GVALUE.X)
                {
                    return PLAYER.P1;
                }
                else if (gBoxes[2, 0] == GVALUE.O)
                {
                    return PLAYER.P2;
                }
            }//COLUMN 1
            else if ((gBoxes[0, 0] == gBoxes[1, 0]) && (gBoxes[0, 0] == gBoxes[2, 0]) && (gBoxes[1, 0] == gBoxes[2, 0]) && (gBoxes[0, 0] != GVALUE.FREE))
            {
                if (gBoxes[0, 0] == GVALUE.X)
                {
                    return PLAYER.P1;
                }
                else if (gBoxes[0, 0] == GVALUE.O)
                {
                    return PLAYER.P2;
                }
            }//COLUMN 2
            else if ((gBoxes[0, 1] == gBoxes[1, 1]) && (gBoxes[0, 1] == gBoxes[2, 1]) && (gBoxes[1, 1] == gBoxes[2, 1]) && (gBoxes[0, 1] != GVALUE.FREE))
            {
                if (gBoxes[0, 1] == GVALUE.X)
                {
                    return PLAYER.P1;
                }
                else if (gBoxes[0, 1] == GVALUE.O)
                {
                    return PLAYER.P2;
                }
            }//COLUMN 3
            else if ((gBoxes[0, 2] == gBoxes[1, 2]) && (gBoxes[0, 2] == gBoxes[2, 2]) && (gBoxes[1, 2] == gBoxes[2, 2]) && (gBoxes[0, 2] != GVALUE.FREE))
            {
                if (gBoxes[0, 2] == GVALUE.X)
                {
                    return PLAYER.P1;
                }
                else if (gBoxes[0, 2] == GVALUE.O)
                {
                    return PLAYER.P2;
                }
            }//DIAGONAL 1
           else if ((gBoxes[0, 0] == gBoxes[1, 1]) && (gBoxes[0, 0] == gBoxes[2, 2]) && (gBoxes[1, 1] == gBoxes[2, 2]) && (gBoxes[0, 0] != GVALUE.FREE))
            {
                if (gBoxes[0, 0] == GVALUE.X)
                {
                    return PLAYER.P1;
                }
                else if (gBoxes[0, 0] == GVALUE.O)
                {
                    return PLAYER.P2;
                }
            }//DIAGONAL 2
            else if((gBoxes[0, 2] == gBoxes[1, 1]) && (gBoxes[0, 2] == gBoxes[2, 0]) && (gBoxes[1, 1] == gBoxes[2, 0]) && (gBoxes[0, 2] != GVALUE.FREE))
            {
                if (gBoxes[0, 2] == GVALUE.X)
                {
                    return PLAYER.P1;
                }
                else if (gBoxes[0, 2] == GVALUE.O)
                {
                    return PLAYER.P2;
                }
            }
           else
            {
                return PLAYER.P0;
            }

            return PLAYER.P0;
        }

        public bool CheckDraw()
        {
            int i,j;
            bool result= true;

            //checks for a free space
            for(i=0; i<3; i++)
            {
                for(j=0; j<3; j++)
                {
                    if(gBoxes[i,j]==GVALUE.FREE)
                    {
                        //if there is still a free space it is not a draw
                        result = false;
                        return result;
                    }
                }
            }

            return result;
        }

        private void SwitchPlayer()
        {
            if (currentPlayer == PLAYER.P1)
            {
                currentPlayer = PLAYER.P2;
            }
            else if(currentPlayer==PLAYER.P2)
            {
                currentPlayer = PLAYER.P1;
            }
        }
       
        public PLAYER GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public void SetGridBox(int i, int j)
        {
            if(currentPlayer==PLAYER.P1)
            {
                gBoxes[i, j] = GVALUE.X;
            }
            else if(currentPlayer==PLAYER.P2)
            {
                gBoxes[i, j] = GVALUE.O;
            }

            SwitchPlayer();
        }

        public GVALUE GetBoxValue(int i, int j)
        {
            return gBoxes[i, j];
        }

        public void ResetGrid()
        {
            int i, j;

            currentPlayer = PLAYER.P1;

            //set all grid boxes to free
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    gBoxes[i, j] = GVALUE.FREE;
                }
            }

        }

        //private
        GVALUE[,] gBoxes = new GVALUE[3,3]; //MULTIDIMENTIONAL ARRAY DECLARATION
        PLAYER currentPlayer = PLAYER.P1;
    }
}
