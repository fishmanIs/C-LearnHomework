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

        private void btnShowAWords_Click(object sender, EventArgs e)
        {
            AddwordsRecord("A");
        }

        private void btnShowBWords_Click(object sender, EventArgs e)
        {
            AddwordsRecord("B");
        }

        //输出talkerName及txtInputWords.Text中的内容,并清空txtInputWords.Text。
        public void AddwordsRecord(string talkerName)
        {
            string wholeWords = "";

            wholeWords += talkerName + "说:" + txtInputWords.Text;
            lstWordsRecord.Items.Add(wholeWords);
            lstWordsRecord.Items.Add("");//空一行
            txtInputWords.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //隐藏开始按钮
            btnStart.Visible = false;

            //显示界面
            lblHintInput.Visible = true;
            txtInputWords.Visible = true;
            btnShowAWords.Visible = btnShowBWords.Visible = btnHelp.Visible = true;
            lstWordsRecord.Visible = true;
        }
    }
}
