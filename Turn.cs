using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public partial class main : Form
    {
        bool userTurn = false; //false 흑, True 백
        int checkBlackCount = -1;
        int checkWhiteCount = -1;

        int blackCount = 0;
        int whiteCount = 0;
        
        public void changeTurn()
        {
            if(checkWhiteCount == 0 && checkBlackCount == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (b[i, j].ImageIndex.ToString().Equals(WHITE.ToString()))
                            whiteCount++;

                        if (b[i,j].ImageIndex.ToString().Equals(BLACK.ToString()))
                            blackCount++;
                    }
                }

                if (blackCount > whiteCount)
                {
                    lb_player.Text = "1플레이어\n우승";
                    lb_black.ImageIndex = BLACK;
                    lb_white.ImageIndex = EMPTY;
                }
                else if(whiteCount > blackCount)
                {
                    lb_player.Text = "2플레이어\n우승";
                    lb_black.ImageIndex = EMPTY;
                    lb_white.ImageIndex = WHITE;
                }
                else
                {
                    lb_player.Text = "무승부";
                    lb_black.ImageIndex = BLACK;
                    lb_white.ImageIndex = WHITE;
                }

                lb_bc.Text = blackCount.ToString();
                lb_wc.Text = whiteCount.ToString();

                return;
            }

            if(userTurn)    //백 
            {
                checkWhiteCount = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (b[i, j].ImageIndex.ToString().Equals(WHITE.ToString()))
                        {
                            checkWhite(i, j);
                        }
                    }
                }

                if (checkWhiteCount == 0)
                {
                    resetText();
                    userTurn = false;
                    
                    lb_player.Text = "1플레이어";
                    lb_black.ImageIndex = BLACK;
                    lb_white.ImageIndex = EMPTY;
                    changeTurn();

                    return;
                }
            }
            else            //흑
            {
                checkBlackCount = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (b[i, j].ImageIndex.ToString().Equals(BLACK.ToString()))
                        {
                            checkBlack(i,j);
                        }
                    }
                }

                if (checkBlackCount == 0)
                {
                    resetText();
                    userTurn = true;

                    lb_player.Text = "2플레이어";
                    lb_black.ImageIndex = EMPTY;
                    lb_white.ImageIndex = WHITE;
                    changeTurn();

                    return;
                }
            }
            
        }

        public void ClickLabelEvent(int x, int y)
        {
            if(userTurn)
            {
                b[x, y].ImageIndex = WHITE;
                reverseWhite(x, y);
                resetText();
                userTurn = false;

                lb_player.Text = "1플레이어";
                lb_black.ImageIndex = BLACK;
                lb_white.ImageIndex = EMPTY;

                changeTurn();
            }
            else
            {
                b[x, y].ImageIndex = BLACK;
                reverseBlack(x, y);
                resetText();
                userTurn = true;

                lb_player.Text = "2플레이어";
                lb_black.ImageIndex = EMPTY;
                lb_white.ImageIndex = WHITE;

                changeTurn();
            }
        }

        public void resetText()
        {
            for (int i = 0;i < 8;i++)
            {
                for(int j = 0;j < 8;j++)
                {
                    b[i, j].Text = "";
                }
            }
        }

        public void reverseBlack(int x, int y)
        {
            if (x - 1 < 0 || y - 1 < 0) { }
            else if (b[x - 1, y - 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0 || y - i < 0)
                        break;

                    if (b[x - i, y - i].ImageIndex == BLACK)
                    {
                        for(int j = 1; j < i; j++)
                        {
                            b[x-j,y-j].ImageIndex = BLACK;
                        }
                        break;
                    }

                    if (b[x - i, y - i].ImageIndex == WHITE)
                        continue;

                    if (b[x - i, y - i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x - 1 < 0) { }
            else if (b[x - 1, y].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0)
                        break;

                    if (b[x - i, y].ImageIndex == BLACK)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x - j, y].ImageIndex = BLACK;
                        }
                        break;
                    }

                    if (b[x - i, y].ImageIndex == WHITE)
                        continue;

                    if (b[x - i, y].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x - 1 < 0 || y + 1 > 7) { }
            else if (b[x - 1, y + 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0 || y + i > 7)
                        break;

                    if (b[x - i, y + i].ImageIndex == BLACK)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x - j, y + j].ImageIndex = BLACK;
                        }
                        break;
                    }

                    if (b[x - i, y + i].ImageIndex == WHITE)
                        continue;

                    if (b[x - i, y + i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (y + 1 > 7) { }
            else if (b[x, y + 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (y + i > 7)
                        break;

                    if (b[x, y + i].ImageIndex == BLACK)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x , y + j].ImageIndex = BLACK;
                        }
                        break;
                    }

                    if (b[x, y + i].ImageIndex == WHITE)
                        continue;

                    if (b[x, y + i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x + 1 > 7 || y + 1 > 7) { }
            else if (b[x + 1, y + 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7 || y + i > 7)
                        break;

                    if (b[x + i, y + i].ImageIndex == BLACK)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x + j, y + j].ImageIndex = BLACK;
                        }
                        break;
                    }

                    if (b[x + i, y + i].ImageIndex == WHITE)
                        continue;

                    if (b[x + i, y + i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x + 1 > 7) { }
            else if (b[x + 1, y].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7)
                        break;

                    if (b[x + i, y].ImageIndex == BLACK)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x + j, y].ImageIndex = BLACK;
                        }
                        break;
                    }

                    if (b[x + i, y].ImageIndex == WHITE)
                        continue;

                    if (b[x + i, y].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x + 1 > 7 || y - 1 < 0) { }
            else if (b[x + 1, y - 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7 || y - i < 0)
                        break;

                    if (b[x + i, y - i].ImageIndex == BLACK)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x + j, y - j].ImageIndex = BLACK;
                        }
                        break;
                    };

                    if (b[x + i, y - i].ImageIndex == WHITE)
                        continue;

                    if (b[x + i, y - i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (y - 1 < 0) { }
            else if (b[x, y - 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (y - i < 0)
                        break;

                    if (b[x, y - i].ImageIndex == BLACK)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x, y - j].ImageIndex = BLACK;
                        }
                        break;
                    }

                    if (b[x, y - i].ImageIndex == WHITE)
                        continue;

                    if (b[x, y - i].ImageIndex == EMPTY)
                        break;

                }
            }
        }

        public void reverseWhite(int x, int y)
        {
            if (x - 1 < 0 || y - 1 < 0) { }
            else if (b[x - 1, y - 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0 || y - i < 0)
                        break;

                    if (b[x - i, y - i].ImageIndex == WHITE)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x - j, y - j].ImageIndex = WHITE;
                        }
                        break;
                    }

                    if (b[x - i, y - i].ImageIndex == BLACK)
                        continue;

                    if (b[x - i, y - i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x - 1 < 0) { }
            else if (b[x - 1, y].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0)
                        break;

                    if (b[x - i, y].ImageIndex == WHITE)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x - j, y].ImageIndex = WHITE;
                        }
                        break;
                    }

                    if (b[x - i, y].ImageIndex == BLACK)
                        continue;

                    if (b[x - i, y].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x - 1 < 0 || y + 1 > 7) { }
            else if (b[x - 1, y + 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0 || y + i > 7)
                        break;

                    if (b[x - i, y + i].ImageIndex == WHITE)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x - j, y + j].ImageIndex = WHITE;
                        }
                        break;
                    }

                    if (b[x - i, y + i].ImageIndex == BLACK)
                        continue;

                    if (b[x - i, y + i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (y + 1 > 7) { }
            else if (b[x, y + 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (y + i > 7)
                        break;

                    if (b[x, y + i].ImageIndex == WHITE)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x, y + j].ImageIndex = WHITE;
                        }
                        break;
                    }

                    if (b[x, y + i].ImageIndex == BLACK)
                        continue;

                    if (b[x, y + i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x + 1 > 7 || y + 1 > 7) { }
            else if (b[x + 1, y + 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7 || y + i > 7)
                        break;

                    if (b[x + i, y + i].ImageIndex == WHITE)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x + j, y + j].ImageIndex = WHITE;
                        }
                        break;
                    }

                    if (b[x + i, y + i].ImageIndex == BLACK)
                        continue;

                    if (b[x + i, y + i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x + 1 > 7) { }
            else if (b[x + 1, y].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7)
                        break;

                    if (b[x + i, y].ImageIndex == WHITE)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x + j, y].ImageIndex = WHITE;
                        }
                        break;
                    }

                    if (b[x + i, y].ImageIndex == BLACK)
                        continue;

                    if (b[x + i, y].ImageIndex == EMPTY)
                        break;

                }
            }

            if (x + 1 > 7 || y - 1 < 0) { }
            else if (b[x + 1, y - 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7 || y - i < 0)
                        break;

                    if (b[x + i, y - i].ImageIndex == WHITE)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x + j, y - j].ImageIndex = WHITE;
                        }
                        break;
                    };

                    if (b[x + i, y - i].ImageIndex == BLACK)
                        continue;

                    if (b[x + i, y - i].ImageIndex == EMPTY)
                        break;

                }
            }

            if (y - 1 < 0) { }
            else if (b[x, y - 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (y - i < 0)
                        break;

                    if (b[x, y - i].ImageIndex == WHITE)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            b[x, y - j].ImageIndex = WHITE;
                        }
                        break;
                    }

                    if (b[x, y - i].ImageIndex == BLACK)
                        continue;

                    if (b[x, y - i].ImageIndex == EMPTY)
                        break;

                }
            }
        }

        public void checkBlack(int x, int y)// 행 열
        {
            
            if (x - 1 < 0 || y - 1 < 0) { }
            else if (b[x - 1, y - 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0 || y - i < 0)
                        break;

                    if (b[x - i, y - i].ImageIndex == BLACK)
                        break;

                    if (b[x - i, y - i].ImageIndex == WHITE)
                        continue;

                    if (b[x - i, y - i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x - i, y - i].Text = "●";
                        checkBlackCount++;
                        break;
                    }

                }
            }

            if (x - 1 < 0) { }
            else if (b[x - 1, y].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0)
                        break;

                    if (b[x - i, y].ImageIndex == BLACK)
                        break;

                    if (b[x - i, y].ImageIndex == WHITE)
                        continue;

                    if (b[x - i, y].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x - i, y].Text = "●";
                        checkBlackCount++;
                        break;
                    }

                }
            }

            if (x - 1 < 0 || y + 1 > 7) { }
            else if (b[x - 1, y + 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0 || y + i > 7)
                        break;

                    if (b[x - i, y + i].ImageIndex == BLACK)
                        break;

                    if (b[x - i, y + i].ImageIndex == WHITE)
                        continue;

                    if (b[x - i, y + i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x - i, y + i].Text = "●";
                        checkBlackCount++;
                        break;
                    }

                }
            }

            if (y + 1 > 7) { }
            else if (b[x, y + 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (y + i > 7)
                        break;

                    if (b[x, y + i].ImageIndex == BLACK)
                        break;

                    if (b[x, y + i].ImageIndex == WHITE)
                        continue;

                    if (b[x, y + i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x, y + i].Text = "●";
                        checkBlackCount++;
                        break;
                    }

                }
            }

            if (x + 1 > 7 || y + 1 > 7) { }
            else if (b[x + 1, y + 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7 || y + i > 7)
                        break;

                    if (b[x + i, y + i].ImageIndex == BLACK)
                        break;

                    if (b[x + i, y + i].ImageIndex == WHITE)
                        continue;

                    if (b[x + i, y + i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x + i, y + i].Text = "●";
                        checkBlackCount++;
                        break;
                    }

                }
            }

            if (x + 1 > 7) { }
            else if (b[x + 1, y].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7)
                        break;

                    if (b[x + i, y].ImageIndex == BLACK)
                        break;

                    if (b[x + i, y].ImageIndex == WHITE)
                        continue;

                    if (b[x + i, y].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x + i, y].Text = "●";
                        checkBlackCount++;
                        break;
                    }

                }
            }

            if (x + 1 > 7 || y - 1 < 0) { }
            else if (b[x + 1, y - 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7 || y - i < 0)
                        break;

                    if (b[x + i, y - i].ImageIndex == BLACK)
                        break;

                    if (b[x + i, y - i].ImageIndex == WHITE)
                        continue;

                    if (b[x + i, y - i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x + i, y - i].Text = "●";
                        checkBlackCount++;
                        break;
                    }

                }
            }

            if (y - 1 < 0) { }
            else if (b[x, y - 1].ImageIndex == WHITE)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (y - i < 0)
                        break;

                    if (b[x , y - i].ImageIndex == BLACK)
                        break;

                    if (b[x , y - i].ImageIndex == WHITE)
                        continue;

                    if (b[x , y - i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x , y - i].Text = "●";
                        checkBlackCount++;
                        break;
                    }

                }
            }
        }

        public void checkWhite(int x, int y)
        {
            if (x - 1 < 0 || y - 1 < 0) { }
            else if (b[x - 1, y - 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0 || y - i < 0)
                        break;

                    if (b[x - i, y - i].ImageIndex == WHITE)
                        break;

                    if (b[x - i, y - i].ImageIndex == BLACK)
                        continue;

                    if (b[x - i, y - i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x - i, y - i].Text = "●";
                        checkWhiteCount++;
                        break;
                    }

                }
            }

            if (x - 1 < 0) { }
            else if (b[x - 1, y].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0)
                        break;

                    if (b[x - i, y].ImageIndex == WHITE)
                        break;

                    if (b[x - i, y].ImageIndex == BLACK)
                        continue;

                    if (b[x - i, y].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x - i, y].Text = "●";
                        checkWhiteCount++;
                        break;
                    }

                }
            }

            if (x - 1 < 0 || y + 1 > 7) { }
            else if (b[x - 1, y + 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x - i < 0 || y + i > 7)
                        break;

                    if (b[x - i, y + i].ImageIndex == WHITE)
                        break;

                    if (b[x - i, y + i].ImageIndex == BLACK)
                        continue;

                    if (b[x - i, y + i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x - i, y + i].Text = "●";
                        checkWhiteCount++;
                        break;
                    }

                }
            }

            if (y + 1 > 7) { }
            else if (b[x, y + 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (y + i > 7)
                        break;

                    if (b[x, y + i].ImageIndex == WHITE)
                        break;

                    if (b[x, y + i].ImageIndex == BLACK)
                        continue;

                    if (b[x, y + i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x, y + i].Text = "●";
                        checkWhiteCount++;
                        break;
                    }

                }
            }

            if (x + 1 > 7 || y + 1 > 7) { }
            else if (b[x + 1, y + 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7 || y + i > 7)
                        break;

                    if (b[x + i, y + i].ImageIndex == WHITE)
                        break;

                    if (b[x + i, y + i].ImageIndex == BLACK)
                        continue;

                    if (b[x + i, y + i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x + i, y + i].Text = "●";
                        checkWhiteCount++;
                        break;
                    }

                }
            }

            if (x + 1 > 7) { }
            else if (b[x + 1, y].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7)
                        break;

                    if (b[x + i, y].ImageIndex == WHITE)
                        break;

                    if (b[x + i, y].ImageIndex == BLACK)
                        continue;

                    if (b[x + i, y].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x + i, y].Text = "●";
                        checkWhiteCount++;
                        break;
                    }

                }
            }

            if (x + 1 > 7 || y - 1 < 0) { }
            else if (b[x + 1, y - 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (x + i > 7 || y - i < 0)
                        break;

                    if (b[x + i, y - i].ImageIndex == WHITE)
                        break;

                    if (b[x + i, y - i].ImageIndex == BLACK)
                        continue;

                    if (b[x + i, y - i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x + i, y - i].Text = "●";
                        checkWhiteCount++;
                        break;
                    }

                }
            }

            if (y - 1 < 0) { }
            else if (b[x, y - 1].ImageIndex == BLACK)
            {
                for (int i = 2; i < 8; i++)
                {
                    if (y - i < 0)
                        break;

                    if (b[x, y - i].ImageIndex == WHITE)
                        break;

                    if (b[x, y - i].ImageIndex == BLACK)
                        continue;

                    if (b[x, y - i].ImageIndex == EMPTY)
                    {
                        // 좌표 표시하는 작업
                        b[x, y - i].Text = "●";
                        checkWhiteCount++;
                        break;
                    }

                }
            }
        }
        
    }
}
