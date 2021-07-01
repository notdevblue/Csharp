using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsTetris
{
    class Diagram       //테트리스 떨어지는 블럭, 다이아그램
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Turn { get; private set; }
        public int BlockNum { get; private set; }
        public int NextBlockNum { get; private set; }
        public int HoldBlockNum { get; private set; }
        public Diagram()
        {
            SetBlockList();
            Reset();
        }

        // 블럭 나오는 순서
        private int[] blockList = new int[7];
        private List<int> arr   = new List<int>() { 0, 1, 2, 3, 4, 5, 6 };

        int turn = 0;
        public void Reset()   // 다이아그램 생성
        {
            Random rand = new Random();
            X = GameRule.SX;
            Y = GameRule.SY;
            Turn = rand.Next() % 4;
            BlockNum = blockList[turn++ % 7];
            NextBlockNum = blockList[turn % 7];
            
        }

        public void SetBlockList()
        {
            for(int i = 0; i < blockList.Length; ++i)
            {
                int rndidx = new Random().Next(0, arr.Count);
                blockList[i] = arr[rndidx];
                arr.RemoveAt(rndidx);
            }
        }

        public void Copy(Diagram dg)
        {
            X        = dg.X;
            Y        = dg.Y;
            Turn     = dg.Turn;
            BlockNum = dg.BlockNum;
        }

        public void ResetPos()
        {
            X = GameRule.SX;
            Y = GameRule.SY;
        }

        public void MoveLeft()  { X--; }
        public void MoveRight() { X++; }
        public void MoveDown()  { Y++; }
        public void MoveTurn()  { Turn = (Turn + 1) % 4; }
    }
}
