namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblShowQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnJudgeAnswer = new System.Windows.Forms.Button();
            this.btnShowRule = new System.Windows.Forms.Button();
            this.lstResultRecord = new System.Windows.Forms.ListBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblShowScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblShowQuestion
            // 
            this.lblShowQuestion.AutoSize = true;
            this.lblShowQuestion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowQuestion.Location = new System.Drawing.Point(48, 35);
            this.lblShowQuestion.Name = "lblShowQuestion";
            this.lblShowQuestion.Size = new System.Drawing.Size(0, 16);
            this.lblShowQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswer.Location = new System.Drawing.Point(186, 32);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(68, 26);
            this.txtAnswer.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 69);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 32);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnJudgeAnswer
            // 
            this.btnJudgeAnswer.Location = new System.Drawing.Point(120, 69);
            this.btnJudgeAnswer.Name = "btnJudgeAnswer";
            this.btnJudgeAnswer.Size = new System.Drawing.Size(88, 32);
            this.btnJudgeAnswer.TabIndex = 5;
            this.btnJudgeAnswer.Text = "判断";
            this.btnJudgeAnswer.UseVisualStyleBackColor = true;
            this.btnJudgeAnswer.Click += new System.EventHandler(this.btnJudgeAnswer_Click);
            // 
            // btnShowRule
            // 
            this.btnShowRule.Location = new System.Drawing.Point(214, 69);
            this.btnShowRule.Name = "btnShowRule";
            this.btnShowRule.Size = new System.Drawing.Size(54, 32);
            this.btnShowRule.TabIndex = 6;
            this.btnShowRule.Text = "规则";
            this.btnShowRule.UseVisualStyleBackColor = true;
            this.btnShowRule.Click += new System.EventHandler(this.btnShowRule_Click);
            // 
            // lstResultRecord
            // 
            this.lstResultRecord.FormattingEnabled = true;
            this.lstResultRecord.ItemHeight = 12;
            this.lstResultRecord.Location = new System.Drawing.Point(26, 138);
            this.lstResultRecord.Name = "lstResultRecord";
            this.lstResultRecord.Size = new System.Drawing.Size(242, 172);
            this.lstResultRecord.TabIndex = 7;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(108, 114);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(53, 12);
            this.lblHint.TabIndex = 8;
            this.lblHint.Text = "得分为：";
            // 
            // lblShowScore
            // 
            this.lblShowScore.AutoSize = true;
            this.lblShowScore.Location = new System.Drawing.Point(167, 114);
            this.lblShowScore.Name = "lblShowScore";
            this.lblShowScore.Size = new System.Drawing.Size(11, 12);
            this.lblShowScore.TabIndex = 10;
            this.lblShowScore.Text = "0";
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 334);
            this.Controls.Add(this.lblShowScore);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lstResultRecord);
            this.Controls.Add(this.btnShowRule);
            this.Controls.Add(this.btnJudgeAnswer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblShowQuestion);
            this.Name = "Form1";
            this.Text = "欢迎来到小学算术无限地狱（×";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnJudgeAnswer;
        private System.Windows.Forms.Button btnShowRule;
        private System.Windows.Forms.ListBox lstResultRecord;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblShowScore;
        private System.Windows.Forms.Timer timer;
    }
}

