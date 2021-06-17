using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanForm
{
    public partial class Form1 : Form
    {
        private int btnClickCount = 0;

        public Form1()
        {
            InitializeComponent();

            myText.Text = "내 콤퓨타 관리자";
            textBox1.PlaceholderText = "관리자통과어";
            textBox1.PasswordChar = '별';
            textBox2.PlaceholderText = "고유알림어";
            btnLogin.Text = "들어가기";
            myText.MouseHover += new EventHandler(onTextHover);

            btnLogin.Width = textBox1.Width;
            btnLogin.Height = textBox1.Height;
        }

        private void onTextHover(object sender, EventArgs e)
        {
            MessageBox.Show("내 콤퓨타 관리자 입니다.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Text = "어림도없지";

            for(int i = 1; i < 5; ++i)
            {
                Button b = new Button();
                b.Width = 150;
                b.Location = new Point(400, 100 + i * 30);
                b.Text = $"{i} 번째 버튼";
                b.Click += new EventHandler(onNewBtnClick);
                b.DoubleClick += new EventHandler(onNewBtnDoubleClick);
                Controls.Add(b);
            }

        }

        private void onNewBtnClick(object sender, EventArgs e)
        {
            ++btnClickCount;
            Button b = sender as Button;

            b.Text = "눌렀네";

            myText.Text = $"새로 생긴 버튼을 총 {btnClickCount} 번 눌렀습니다";

            if(btnClickCount > 10)
            {
                // do something
            }
            
            //MessageBox.Show("와센즈");
        }

        private void onNewBtnDoubleClick(object sender, EventArgs s)
        {
            Button b = sender as Button;

            b.Text = "오 더블클릭";
        }


        int sec = 0;
        private void myTimer_Tick(object sender, EventArgs e)
        {
            ++sec;
            myText.Text = $"{sec} 초가 지났습니다.";
        }
    }
}
