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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("输入AB要说的话之后点击按钮。");
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            //将tx中的内容输出并清空tx
            Talk(btnA.Text);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            //将tx中的内容输出并清空tx
            Talk(btnB.Text);
        }

        //将tx中的内容输出并清空tx
        public void Talk(string who)
        {
            string str = who;
            str += ":" + txSpeak.Text;
            lstSpeak.Items.Add(str);
            lstSpeak.Items.Add("");
            txSpeak.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //隐藏开始按钮
            btnStart.Visible = false;

            //显示界面
            label1.Visible = true;
            txSpeak.Visible = true;
            btnA.Visible = btnB.Visible = btnHelp.Visible = true;
            lstSpeak.Visible = true;
        }
    }
}
