using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace WinFormsTetris
{
    class Board     //테트리스 보드
    {
        public static Board GameBoard { get; }
        static Board()
        {
            GameBoard = new Board();
        }
        Board()
        {
        }

        int[,] board        = new int[GameRule.BX, GameRule.BY]; // TODO : 색 저장
        static Brush[,] boardColor   = new Brush[GameRule.BX, GameRule.BY];

        public int this[int x, int y]
        {
            get { return board[x, y]; }
        }

        static public Brush GetColor(int x, int y)
        {
            return boardColor[x, y];
        }

        public bool MoveEnable(int bn, int tn, int x, int y)
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        if (((x + xx) < 0) || ((x + xx) >= GameRule.BX) || ((y + yy) >= GameRule.BY))
                        {
                            return false;
                        }
                        if (board[x + xx, y + yy] != 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void Store(int bn, int turn, int x, int y)
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (((x + xx) >= 0) && (x + xx < GameRule.BX) && (y + yy >= 0) && (y + yy < GameRule.BY))
                    {
                        board[x + xx, y + yy] += BlockValue.bvals[bn, turn, xx, yy];
                        boardColor[x, y] = BlockValue.bcolors[bn]; // TODO : Changed, TODO : ERR
                    }
                }
            }
            CheckLines(y + 3);
        }

        private void CheckLines(int y)
        {
            int yy = 0;
            for (yy = 0; yy < 4; yy++)
            {
                if (y - yy < GameRule.BY)
                {
                    if (CheckLine(y - yy))
                    {
                        ++Game.Singleton.score;
                        ClearLine(y - yy);
                        y++;
                    }
                }
            }
        }

        private void ClearLine(int y)
        {
            for (; y > 0; y--)
            {
                for (int xx = 0; xx < GameRule.BX; xx++)
                {
                    board[xx, y] = board[xx, y - 1];
                }
            }
        }

        private bool CheckLine(int y)
        {
            for (int xx = 0; xx < GameRule.BX; xx++)
            {
                if (board[xx, y] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void ClearBoard()
        {
            for (int xx = 0; xx < GameRule.BX; xx++)
            {
                for (int yy = 0; yy < GameRule.BY; yy++)
                {
                    board[xx, yy] = 0;
                }
            }
        }
    }
}
