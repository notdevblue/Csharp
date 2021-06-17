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

        public int[] blockSetArr = new int[7]; // 블록 패턴 저장
        private List<int> blockList = new List<int>(); // 랜덤을 위한 List

        public Diagram()
        {
            InitRandom();
            Reset();
        }

        private void InitRandom()
        {
            Random rand = new Random();

            for (int i = 0; i < 7; ++i)
            {
                blockList.Add(i);
            }

            for (int i = 0; i < 7; ++i)
            {
                int idx = rand.Next(blockList.Count);

                blockSetArr[i] = blockList[idx];

                blockList.RemoveAt(idx);
            }
        }

        int blockIdx = 0;
        public void Reset()   // 다이아그램 생성
        {
            Random rand = new Random();
            X = GameRule.SX;
            Y = GameRule.SY;
            Turn = rand.Next() % 4;
            BlockNum = blockSetArr[blockIdx++ % 7];
        }

        public int GetNextBlock()
        {
            return blockSetArr[(blockIdx + 1) % 7];
        }

        public void MoveLeft()  { X--; }
        public void MoveRight() { X++; }
        public void MoveDown()  { Y++; }
        public void MoveTurn()  { Turn = (Turn + 1) % 4; }
    }
}
