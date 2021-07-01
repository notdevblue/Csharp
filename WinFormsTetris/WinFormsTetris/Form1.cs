using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        Thread t1;
        public Form1()  //생성자
        {
            InitializeComponent();
            originInterval = timer1.Interval;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(600, 100);

            t1 = new Thread(MoveWindow)
            {
                IsBackground = true
            };

        }

        float t = 0.0f;
        bool isBottom = false;
        object lockObj = new object();
        void MoveWindow()
        {
            while (true)
            {
                if (stop) continue;
                Thread.Sleep(1000 / 60);
                WindowShake();
                WindowDown();
            }
        }

        int shakeEffectTime = 25;
        int shakeAmount = 5;
        int bottomT = 0;
        bool stop = false;
        int xPos = 0;
        double sin = 0;
        float posidx = 0.0f;
        float showIdx = 0.0f;
        bool noMove = false;
        Point[] posarr = new Point[4] { new Point(0, 0), new Point(1300, 0), new Point(0, 410), new Point(1300, 410) };
        private void WindowShake()
        {
            if (game.score % 6 == 2 && !isBottom)
            {
                lock (lockObj)
                {
                    noMove = false;
                }
                this.Invoke(new Action(delegate ()
                {
                    showIdx += 0.1f;
                    if ((int)showIdx % 2 == 1)
                    {
                        xPos = 2000;
                    }
                    else
                    {
                        xPos = 600;
                    }
                    Location = new Point(xPos, (int)t);
                    return;
                }));
            }
            else if (game.score % 6 == 3 && !isBottom)
            {
                lock (lockObj)
                {
                    noMove = false;
                }
                this.Invoke(new Action(delegate ()
                {
                    xPos = (int)((Math.Sin(sin) + 1) * 250) + 250;
                    Debug.WriteLine(xPos);
                    Location = new Point(xPos, (int)t);
                    sin += 0.05;

                }));

                return;
            }
            else if (game.score % 6 == 4 && !isBottom)
            {
                lock (lockObj)
                {
                    noMove = true;
                }

                this.Invoke(new Action(delegate ()
                {
                    xPos = posarr[(int)posidx % 4].X;
                    Location = posarr[(int)posidx % 4];
                    posidx += 0.01f;
                }));
                return;
            }
            else if (game.score % 6 == 5 & !isBottom)
            {
                lock (lockObj)
                {
                    noMove = true;
                }

                xPos = (int)((Math.Sin(sin) + 1) * 250) + 250;
                t = (float)((Math.Cos(sin) + 1) * 100) + 100;
                sin += 0.05;

                this.Invoke(new Action(delegate ()
                {
                    Location = new Point(xPos + 150, (int)t);
                }));
                return;

            }
            else if (!isBottom)
            {
                lock (lockObj)
                {
                    noMove = false;
                }
                xPos = 600;
            }

            if (isBottom)
            {
                this.Invoke(new Action(delegate ()
                {
                    Location = new Point(xPos - shakeAmount, bottomT);
                    Thread.Sleep(shakeEffectTime);
                    Location = new Point(xPos + shakeAmount, bottomT);
                    Thread.Sleep(shakeEffectTime);
                }));

                isBottom = false;
            }
        }

        private void WindowDown()
        {

            if (noMove) return;

            lock (lockObj)
            {
                t += (game.score + 0.5f) / 3.0f;
            }
            this.Invoke(new Action(delegate ()
            {
                Location = new Point(xPos, (int)t);
            }));
        }


        private void Form1_Load(object sender, EventArgs e) //Start()
        {
            game = Game.Singleton;
            bx = GameRule.BX;
            by = GameRule.BY;
            bwidth = GameRule.B_WIDTH;
            bheight = GameRule.B_HEIGHT;
            this.SetClientSizeCore(GameRule.BX * GameRule.B_WIDTH, GameRule.BY * GameRule.B_HEIGHT);
            t1.Start();
        }

        
        private void Form1_Paint(object sender, PaintEventArgs e) //Update()
        {
            Score.Text = $"SCORE : {game.score}";
            next.Text = "NEXT";
            holdText.Text = "HOLD (T)";

            

            DoubleBuffered = true;
            DrawGraduation(e.Graphics);
            NextDrawDiagram(e.Graphics);
            HoldDrawDiagram(e.Graphics);
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

        private void HoldDrawDiagram(Graphics graphics)
        {
            int bn = game.HoldBlockNum;
            if (bn == -1) return;

            Debug.WriteLine(bn);
            int tn = 0;
            Point now = new Point(14, 7);

            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle now_rt = new Rectangle((now.X + xx) * (bwidth - 20) + 2, (now.Y + yy) * bheight + 2, bwidth - 24, bheight - 4);
                        graphics.DrawRectangle(Pens.Black, now_rt);
                        graphics.FillRectangle(Brushes.BlueViolet, now_rt);
                    }
                }
            }
        }
        
        private void NextDrawDiagram(Graphics graphics)
        {
            int bn = game.NextBlockNum;
            int tn = 0;
            Point now = new Point(14, 3);

            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[bn, tn, xx, yy] != 0)
                    {
                        Rectangle now_rt = new Rectangle((now.X + xx) * (bwidth - 20) + 2, (now.Y + yy) * bheight + 2, bwidth - 24, bheight - 4);
                        graphics.DrawRectangle(Pens.Black, now_rt);
                        graphics.FillRectangle(Brushes.BlueViolet, now_rt);
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

        bool holded = false;
        private void Hold()
        {
            if (holded) return;
            holded = true;
            game.Hold();

            lock (lockObj)
            {
                t = 0;
            }

            Region rg = MakeRegion();
            Invalidate(rg);
        }

        private void EndingCheck()
        {
            if (game.Next())
            {
                Invalidate(); //전체 영역 갱신
                holded = false;
                lock(lockObj)
                {
                    bottomT = (int)t;
                    t = 0;
                    isBottom = true;
                }
            }
            else
            {
                timer1.Enabled = false;
                lock (lockObj)
                {
                    stop = true;
                }

                if (DialogResult.Yes == MessageBox.Show($"당신의 인내심 점수: {game.score}\r\n계속 하실건가요?", "계속 진행 확인 창", MessageBoxButtons.YesNo))
                {
                    lock (lockObj)
                    {
                        stop = false;
                    }

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
