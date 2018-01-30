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
            this.labF = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnJudge = new System.Windows.Forms.Button();
            this.btnRule = new System.Windows.Forms.Button();
            this.lstDisp = new System.Windows.Forms.ListBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labF
            // 
            this.labF.AutoSize = true;
            this.labF.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labF.Location = new System.Drawing.Point(48, 35);
            this.labF.Name = "labF";
            this.labF.Size = new System.Drawing.Size(0, 16);
            this.labF.TabIndex = 0;
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAns.Location = new System.Drawing.Point(186, 32);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(68, 26);
            this.txtAns.TabIndex = 3;
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
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(120, 69);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(88, 32);
            this.btnJudge.TabIndex = 5;
            this.btnJudge.Text = "判断";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // btnRule
            // 
            this.btnRule.Location = new System.Drawing.Point(214, 69);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(54, 32);
            this.btnRule.TabIndex = 6;
            this.btnRule.Text = "规则";
            this.btnRule.UseVisualStyleBackColor = true;
            this.btnRule.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // lstDisp
            // 
            this.lstDisp.FormattingEnabled = true;
            this.lstDisp.ItemHeight = 12;
            this.lstDisp.Location = new System.Drawing.Point(26, 138);
            this.lstDisp.Name = "lstDisp";
            this.lstDisp.Size = new System.Drawing.Size(242, 172);
            this.lstDisp.TabIndex = 7;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(108, 114);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(53, 12);
            this.lab1.TabIndex = 8;
            this.lab1.Text = "得分为：";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Location = new System.Drawing.Point(167, 114);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(11, 12);
            this.labScore.TabIndex = 10;
            this.labScore.Text = "0";
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
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.lstDisp);
            this.Controls.Add(this.btnRule);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.labF);
            this.Name = "Form1";
            this.Text = "欢迎来到小学算术无限地狱（×";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labF;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Button btnRule;
        private System.Windows.Forms.ListBox lstDisp;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Timer timer;
    }
}

