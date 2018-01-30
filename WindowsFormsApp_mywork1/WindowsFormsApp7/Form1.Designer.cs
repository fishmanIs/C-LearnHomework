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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lstSpeak = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txSpeak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(162, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始BB";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnA.Location = new System.Drawing.Point(88, 77);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(102, 46);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A说";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Visible = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnB.Location = new System.Drawing.Point(196, 77);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(105, 46);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B说";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Visible = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHelp.Location = new System.Drawing.Point(307, 77);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(82, 46);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Visible = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lstSpeak
            // 
            this.lstSpeak.FormattingEnabled = true;
            this.lstSpeak.ItemHeight = 12;
            this.lstSpeak.Location = new System.Drawing.Point(88, 133);
            this.lstSpeak.Name = "lstSpeak";
            this.lstSpeak.Size = new System.Drawing.Size(301, 196);
            this.lstSpeak.TabIndex = 4;
            this.lstSpeak.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(86, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入：";
            this.label1.Visible = false;
            // 
            // txSpeak
            // 
            this.txSpeak.Location = new System.Drawing.Point(145, 50);
            this.txSpeak.Name = "txSpeak";
            this.txSpeak.Size = new System.Drawing.Size(244, 21);
            this.txSpeak.TabIndex = 7;
            this.txSpeak.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 349);
            this.Controls.Add(this.txSpeak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSpeak);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "第一讲作业 BB练习";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox lstSpeak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txSpeak;
    }
}

