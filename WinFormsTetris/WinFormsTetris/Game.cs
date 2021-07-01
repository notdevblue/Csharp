using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WinFormsTetris
{
    class Game
    {        
        Board gboard = Board.GameBoard;
        Diagram now;
        Diagram next;
        Diagram preview;

        public int score = 0;

        public Point NowPosition
        {
            get { return new Point(now.X, now.Y); }
        }
        public int BlockNum
        {
            get { return now.BlockNum; }
        }        
        public int NextBlockNum
        {
            get { return now.NextBlockNum; }
        } 
        
        public int HoldBlockNum { get; private set; }
        public int Turn
        {
            get { return now.Turn; }
        }

        public static Game Singleton { get; }

        public int this[int x, int y]
        {
            get { return gboard[x, y]; }
        }

        static Game()
        {
            Singleton = new Game();
        }
        Game()
        {
            HoldBlockNum = -1;
            now = new Diagram();
            next = new Diagram();
            preview = new Diagram();
        }

        public bool MoveLeft()
        {
            if (gboard.MoveEnable(now.BlockNum, Turn, now.X - 1, now.Y))
            {
                now.MoveLeft();
                return true;
            }
            return false;
        }

        public bool MoveRight()
        {
            if (gboard.MoveEnable(now.BlockNum, Turn, now.X + 1, now.Y))
            {
                now.MoveRight();
                return true;
            }
            return false;
        }

        public bool MoveDown()
        {
            if (gboard.MoveEnable(now.BlockNum, Turn, now.X, now.Y + 1))
            {
                now.MoveDown();
                return true;
            }
            gboard.Store(now.BlockNum, Turn, now.X, now.Y); //보드 정보 갱신
            return false;
        }

        public bool BottomBlock()
        {
            if (gboard.MoveEnable(now.BlockNum, Turn, now.X, now.Y + 1))
            {
                now.MoveDown();
                return true;
            }
            return false;
        }

        public bool MoveTurn()
        {
            if (gboard.MoveEnable(now.BlockNum, (Turn + 1) % 4, now.X, now.Y))
            {
                now.MoveTurn();
                return true;
            }
            return false;
        }

        public bool Next()
        {
            now.Reset();
            return gboard.MoveEnable(now.BlockNum, Turn, now.X, now.Y);
        }

        Diagram holdBlock = new Diagram();
        bool isHold = false;
        Diagram temp = null;

        public void Hold()
        {
            if (isHold)
            {
                temp.Copy(now);

                now.Copy(holdBlock);
                temp.ResetPos();
                holdBlock.Copy(temp);
            }
            else
            {
                if (temp == null)
                {
                    now.ResetPos();
                    holdBlock.Copy(now);

                    Next();
                    temp = new Diagram();
                    HoldBlockNum = holdBlock.BlockNum;
                    return;
                }

                temp.Copy(holdBlock);

                now.ResetPos();
                holdBlock.Copy(now);
                now.Copy(temp);
            }
            isHold = !isHold;
            HoldBlockNum = holdBlock.BlockNum;
        }

        public void ReStart()
        {
            score = 0;
            gboard.ClearBoard();
        }
    }
}
