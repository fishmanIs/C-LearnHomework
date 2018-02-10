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
            this.showQuestion = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.judgeAnswer = new System.Windows.Forms.Button();
            this.showRule = new System.Windows.Forms.Button();
            this.resultRecord = new System.Windows.Forms.ListBox();
            this.hint = new System.Windows.Forms.Label();
            this.showScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // showQuestion
            // 
            this.showQuestion.AutoSize = true;
            this.showQuestion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showQuestion.Location = new System.Drawing.Point(48, 35);
            this.showQuestion.Name = "showQuestion";
            this.showQuestion.Size = new System.Drawing.Size(0, 16);
            this.showQuestion.TabIndex = 0;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answer.Location = new System.Drawing.Point(186, 32);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(68, 26);
            this.answer.TabIndex = 3;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(26, 69);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(88, 32);
            this.start.TabIndex = 4;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // judgeAnswer
            // 
            this.judgeAnswer.Location = new System.Drawing.Point(120, 69);
            this.judgeAnswer.Name = "judgeAnswer";
            this.judgeAnswer.Size = new System.Drawing.Size(88, 32);
            this.judgeAnswer.TabIndex = 5;
            this.judgeAnswer.Text = "判断";
            this.judgeAnswer.UseVisualStyleBackColor = true;
            this.judgeAnswer.Click += new System.EventHandler(this.judgeAnswer_Click);
            // 
            // showRule
            // 
            this.showRule.Location = new System.Drawing.Point(214, 69);
            this.showRule.Name = "showRule";
            this.showRule.Size = new System.Drawing.Size(54, 32);
            this.showRule.TabIndex = 6;
            this.showRule.Text = "规则";
            this.showRule.UseVisualStyleBackColor = true;
            this.showRule.Click += new System.EventHandler(this.showRule_Click);
            // 
            // resultRecord
            // 
            this.resultRecord.FormattingEnabled = true;
            this.resultRecord.ItemHeight = 12;
            this.resultRecord.Location = new System.Drawing.Point(26, 138);
            this.resultRecord.Name = "resultRecord";
            this.resultRecord.Size = new System.Drawing.Size(242, 172);
            this.resultRecord.TabIndex = 7;
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Location = new System.Drawing.Point(108, 114);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(53, 12);
            this.hint.TabIndex = 8;
            this.hint.Text = "得分为：";
            // 
            // showScore
            // 
            this.showScore.AutoSize = true;
            this.showScore.Location = new System.Drawing.Point(167, 114);
            this.showScore.Name = "showScore";
            this.showScore.Size = new System.Drawing.Size(11, 12);
            this.showScore.TabIndex = 10;
            this.showScore.Text = "0";
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
            this.Controls.Add(this.showScore);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.resultRecord);
            this.Controls.Add(this.showRule);
            this.Controls.Add(this.judgeAnswer);
            this.Controls.Add(this.start);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.showQuestion);
            this.Name = "Form1";
            this.Text = "欢迎来到小学算术无限地狱（×";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showQuestion;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button judgeAnswer;
        private System.Windows.Forms.Button showRule;
        private System.Windows.Forms.ListBox resultRecord;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.Label showScore;
        private System.Windows.Forms.Timer timer;
    }
}

