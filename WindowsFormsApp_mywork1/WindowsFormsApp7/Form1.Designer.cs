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
            this.btnShowAWords = new System.Windows.Forms.Button();
            this.btnShowBWords = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lstWordsRecord = new System.Windows.Forms.ListBox();
            this.lblHintInput = new System.Windows.Forms.Label();
            this.txtInputWords = new System.Windows.Forms.TextBox();
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
            // btnShowAWords
            // 
            this.btnShowAWords.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowAWords.Location = new System.Drawing.Point(88, 77);
            this.btnShowAWords.Name = "btnShowAWords";
            this.btnShowAWords.Size = new System.Drawing.Size(102, 46);
            this.btnShowAWords.TabIndex = 1;
            this.btnShowAWords.Text = "A说";
            this.btnShowAWords.UseVisualStyleBackColor = true;
            this.btnShowAWords.Visible = false;
            this.btnShowAWords.Click += new System.EventHandler(this.btnShowAWords_Click);
            // 
            // btnShowBWords
            // 
            this.btnShowBWords.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowBWords.Location = new System.Drawing.Point(196, 77);
            this.btnShowBWords.Name = "btnShowBWords";
            this.btnShowBWords.Size = new System.Drawing.Size(105, 46);
            this.btnShowBWords.TabIndex = 2;
            this.btnShowBWords.Text = "B说";
            this.btnShowBWords.UseVisualStyleBackColor = true;
            this.btnShowBWords.Visible = false;
            this.btnShowBWords.Click += new System.EventHandler(this.btnShowBWords_Click);
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
            // lstWordsRecord
            // 
            this.lstWordsRecord.FormattingEnabled = true;
            this.lstWordsRecord.ItemHeight = 12;
            this.lstWordsRecord.Location = new System.Drawing.Point(88, 133);
            this.lstWordsRecord.Name = "lstWordsRecord";
            this.lstWordsRecord.Size = new System.Drawing.Size(301, 196);
            this.lstWordsRecord.TabIndex = 4;
            this.lstWordsRecord.Visible = false;
            // 
            // lblHintInput
            // 
            this.lblHintInput.AutoSize = true;
            this.lblHintInput.BackColor = System.Drawing.Color.Transparent;
            this.lblHintInput.Location = new System.Drawing.Point(86, 53);
            this.lblHintInput.Name = "lblHintInput";
            this.lblHintInput.Size = new System.Drawing.Size(53, 12);
            this.lblHintInput.TabIndex = 6;
            this.lblHintInput.Text = "请输入：";
            this.lblHintInput.Visible = false;
            // 
            // txtInputWords
            // 
            this.txtInputWords.Location = new System.Drawing.Point(145, 50);
            this.txtInputWords.Name = "txtInputWords";
            this.txtInputWords.Size = new System.Drawing.Size(244, 21);
            this.txtInputWords.TabIndex = 7;
            this.txtInputWords.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 349);
            this.Controls.Add(this.txtInputWords);
            this.Controls.Add(this.lblHintInput);
            this.Controls.Add(this.lstWordsRecord);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnShowBWords);
            this.Controls.Add(this.btnShowAWords);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "第一讲作业 BB练习";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShowAWords;
        private System.Windows.Forms.Button btnShowBWords;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox lstWordsRecord;
        private System.Windows.Forms.Label lblHintInput;
        private System.Windows.Forms.TextBox txtInputWords;
    }
}

