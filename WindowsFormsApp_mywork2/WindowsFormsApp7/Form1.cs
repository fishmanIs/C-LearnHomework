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
        string question;

        private void btnStart_Click(object sender, EventArgs e)
        {
            count = 0;
            score = 0;

            RandQuestion();

            this.timer.Enabled = true;
        }

        private void btnJudgeAnswer_Click(object sender, EventArgs e)
        {
            //判断答案改变answer的底色
            if (txtAnswer.Text == result.ToString())
                txtAnswer.BackColor = Color.FromArgb(0, 255, 0);
            else
            {
                txtAnswer.BackColor = Color.FromArgb(255, 0, 0);
                txtAnswer.Text = "";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            JudgeAndRecord();

            if (isOK())
                MessageBox.Show("恭喜！你的得分是：" + score);
            else
                RandQuestion();
        }

        private void btnShowRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击开始按钮开始游戏。\n每" +
                (timer.Interval/1000).ToString() + 
                "s出一题，时间结束自动判题。\n" +
                "填好答案，可点判断按钮，判断对错。\n" +
                "共10题，算对加一分，算错减一分。");
        }



        //随机生成题目
        public void RandQuestion()
        {
            Random rnd = new Random();

            int a, b, op;

            a = rnd.Next(9) + 1;
            b = rnd.Next(9) + 1;
            op = rnd.Next(3);

            switch (op)
            {
                case 0: question = a + " + " + b + " ="; result = a + b; break;
                case 1: question = a + " - " + b + " ="; result = a - b; break;
                case 2: question = a + " * " + b + " ="; result = a * b; break;
            }

            lblShowQuestion.Text = question;
            txtAnswer.Text = "";
            txtAnswer.BackColor = Color.FromArgb(255, 255, 255);
            count++;
        }

        //判断答案并增加记录
        public void JudgeAndRecord()
        {
            string newRecord = question + txtAnswer.Text;

            if (txtAnswer.Text == result.ToString())
            {
                score++;
                newRecord += " √";
            }
            else
            {
                score--;
                txtAnswer.Text = "";
                newRecord += " ×";
            }

            //更新分数
            lblShowScore.Text = score.ToString();

            lstResultRecord.Items.Add(newRecord);
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
