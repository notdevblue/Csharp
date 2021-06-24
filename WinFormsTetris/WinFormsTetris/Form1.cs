﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTetris
{
    public partial class Form1 : Form
    {
        Game game;
        int bx;
        int by;
        int bwidth;
        int bheight;

        public Form1()  //생성자
        {
            InitializeComponent();
            originInterval = timer1.Interval;
        }

        private void Form1_Load(object sender, EventArgs e) //Start()
        {
            game = Game.Singleton;
            bx = GameRule.BX;
            by = GameRule.BY;
            bwidth = GameRule.B_WIDTH;
            bheight = GameRule.B_HEIGHT;
            this.SetClientSizeCore(GameRule.BX * GameRule.B_WIDTH, GameRule.BY * GameRule.B_HEIGHT);
        }

        private void Form1_Paint(object sender, PaintEventArgs e) //Update()
        {
            Score.Text = $"SCORE : {game.score}";

            DoubleBuffered = true;
            DrawGraduation(e.Graphics);
            DrawDiagram(e.Graphics);
            DrawBoard(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right: MoveRight(); return;
                case Keys.Left: MoveLeft(); return;                
                case Keys.Up: MoveTurn(); return;
                case Keys.Down: MoveDown(); return;
                case Keys.Space: MoveSSDown(); return;
                case Keys.T: Hold(); return;
            }
        }

        int originInterval;
        private void timer1_Tick(object sender, EventArgs e)  //Update()
        {
            int interval = originInterval - (Game.Singleton.score * 100);

            timer1.Interval = interval < 250 ? 250 : interval;
            MoveDown();
        }

        private void DrawBoard(Graphics graphics)
        {
            for (int xx = 0; xx < bx; xx++)
            {
                for (int yy = 0; yy < by; yy++)
                {
                    if (game[xx, yy] != 0)
                    {
                        Rectangle now_rt = new Rectangle(xx * (bwidth - 20) + 2, yy * bheight + 2, bwidth - 24, bheight - 4);
                        graphics.DrawRectangle(Pens.White, now_rt);
                        graphics.FillRectangle(Brushes.BlueViolet, now_rt); // TODO : Color
                    }
                }
            }
        }

        private void DrawDiagram(Graphics graphics)
        {
            int bn = game.BlockNum;
            int tn = game.Turn;
            Point now = game.NowPosition;
            Pen dpen = new Pen(Color.Red, 3);

            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle now_rt = new Rectangle((now.X + xx) * (bwidth - 20) + 2, (now.Y + yy) * bheight + 2, bwidth - 24, bheight - 4);
                        graphics.DrawRectangle(dpen, now_rt);
                    }
                }
            }
        }

        private void DrawGraduation(Graphics graphics)
        {
            DrawHorizons(graphics);
            DrawVerticals(graphics);
        }

        private void DrawVerticals(Graphics graphics)
        {
            Point st = new Point();
            Point et = new Point();

            for (int cx = 0; cx < bx; cx++)
            {
                st.X = cx * (bwidth - 20); // TODO : SIZE
                st.Y = 0;
                et.X = st.X;
                et.Y = by * bheight;
                graphics.DrawLine(Pens.DarkGray, st, et);
            }
        }

        private void DrawHorizons(Graphics graphics)
        {
            Point st = new Point();
            Point et = new Point();

            for (int cy = 0; cy < by; cy++)
            {
                st.X = 0;
                st.Y = cy * bheight;
                et.X = bx * (bwidth - 20);
                et.Y = cy * bheight;
                graphics.DrawLine(Pens.DarkGray, st, et);
            }
        }

        private void MoveTurn()
        {
            if (game.MoveTurn())
            {
                Region rg = MakeRegion();
                Invalidate(rg);
            }
        }

        private void MoveLeft()
        {
            if (game.MoveLeft())
            {
                Region rg = MakeRegion(1, 0);
                Invalidate(rg);
            }
        }

        private void MoveRight()
        {
            if (game.MoveRight())
            {
                Region rg = MakeRegion(-1, 0);
                Invalidate(rg);
            }
        }

        private void MoveDown()
        {
            if (game.MoveDown())
            {
                Region rg = MakeRegion(0, -1);
                Invalidate(rg);
            }
            else
            {
                EndingCheck();
            }
        }

        private void MoveSSDown()
        {
            while (game.MoveDown()) 
            {
                Region rg = MakeRegion(0, -1);
                Invalidate(rg);
            }
            EndingCheck();
        }

        private void Hold()
        {
            game.Hold();

            Region rg = MakeRegion();
            Invalidate(rg);
        }

        private void EndingCheck()
        {
            if (game.Next())
            {
                Invalidate(); //전체 영역 갱신
            }
            else
            {
                timer1.Enabled = false;

                if (DialogResult.Yes == MessageBox.Show("계속 하실건가요?", "계속 진행 확인 창", MessageBoxButtons.YesNo))
                {
                    game.ReStart();
                    timer1.Enabled = true;
                    Invalidate();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private Region MakeRegion(int cx, int cy) //갱신할 영역 계산
        {
            Point now = game.NowPosition;

            int bn = game.BlockNum;
            int tn = game.Turn;
            Region region = new Region();
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X + xx) * bwidth + 2, (now.Y + yy) * bheight + 2, bwidth - 4, bheight - 4);
                        Rectangle rect2 = new Rectangle((now.X + cx + xx) * bwidth, (now.Y + cy + yy) * bheight, bwidth, bheight);
                        Region rg1 = new Region(rect1);
                        Region rg2 = new Region(rect2);
                        region.Union(rg1);
                        region.Union(rg2);
                    }
                }
            }
            return region;
        }

        private Region MakeRegion() 
        {
            Point now = game.NowPosition;
            int bn = game.BlockNum;
            int tn = game.Turn;
            int oldtn = (tn + 3) % 4;

            Region region = new Region();
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X + xx) * bwidth + 2, (now.Y + yy) * bheight + 2, bwidth - 4, bheight - 4);
                        Region rg1 = new Region(rect1);
                        region.Union(rg1);
                    }
                    if (BlockValue.bvals[bn, oldtn, xx, yy] != 0)
                    {
                        Rectangle rect1 = new Rectangle((now.X + xx) * bwidth + 2, (now.Y + yy) * bheight + 2, bwidth - 4, bheight - 4);
                        Region rg1 = new Region(rect1);
                        region.Union(rg1);
                    }
                }
            }
            return region;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
