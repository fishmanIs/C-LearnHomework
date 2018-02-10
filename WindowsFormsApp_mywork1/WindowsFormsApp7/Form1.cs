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

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("输入AB要说的话之后点击按钮。");
        }

        private void showAWords_Click(object sender, EventArgs e)
        {
            AddwordsRecord("A");
        }

        private void showBWords_Click(object sender, EventArgs e)
        {
            AddwordsRecord("B");
        }

        //输出talkerName及inputWords.Text中的内容,并清空inputWords.Text。
        public void AddwordsRecord(string talkerName)
        {
            string wholeWords = "";

            wholeWords += talkerName + "说:" + inputWords.Text;
            wordsRecord.Items.Add(wholeWords);
            wordsRecord.Items.Add("");//空一行
            inputWords.Text = "";
        }

        private void start_Click(object sender, EventArgs e)
        {
            //隐藏开始按钮
            start.Visible = false;

            //显示界面
            hintInput.Visible = true;
            inputWords.Visible = true;
            showAWords.Visible = showBWords.Visible = help.Visible = true;
            wordsRecord.Visible = true;
        }
    }
}
