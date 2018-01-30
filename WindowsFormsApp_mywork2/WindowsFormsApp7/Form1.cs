using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0,score = 0,result;
        string F,R;

        private void btnStart_Click(object sender, EventArgs e)
        {
            //数据初始化
            count = 0;
            score = 0;

            //随机生成题目
            RandF();

            //启动时钟
            this.timer.Enabled = true;
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            //判断答案改变txt底色
            if (txtAns.Text == result.ToString())
                txtAns.BackColor = Color.FromArgb(0, 255, 0);
            else
            {
                txtAns.BackColor = Color.FromArgb(255, 0, 0);
                txtAns.Text = "";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //判断答案
             Judge();

            //判断是否完成
            if (isOK())
                MessageBox.Show("恭喜！你的得分是：" + score);
            else
                RandF();//随机生成题目
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击开始按钮开始游戏。\n每" +
                (timer.Interval/1000).ToString() + 
                "s出一题，时间结束自动判题。\n" +
                "填好答案，可点判断按钮，判断对错。\n" +
                "共10题，算对加一分，算错减一分。");
        }



        //随机生成题目
        public void RandF()
        {
            Random rnd = new Random();

            int a, b, op;

            a = rnd.Next(9) + 1;
            b = rnd.Next(9) + 1;
            op = rnd.Next(3);

            switch (op)
            {
                case 0: F = a + " + " + b + " ="; result = a + b; break;
                case 1: F = a + " - " + b + " ="; result = a - b; break;
                case 2: F = a + " * " + b + " ="; result = a * b; break;
            }

            labF.Text = F;
            txtAns.Text = "";
            txtAns.BackColor = Color.FromArgb(255, 255, 255);
            count++;
        }

        //判断答案
        public void Judge()
        {
            R = F + txtAns.Text;

            if (txtAns.Text == result.ToString())
            {
                score++;
                R += " √";
            }
            else
            {
                score--;
                txtAns.Text = "";
                R += " ×";
            }

            //更新列表
            labScore.Text = score.ToString();
            lstDisp.Items.Add(R);
        }

        //判断是否完成
        public bool isOK()
        {
            if (count >= 10)
            {
                this.timer.Enabled = false;
                return true;
            }
            return false;
        }
    }
}
