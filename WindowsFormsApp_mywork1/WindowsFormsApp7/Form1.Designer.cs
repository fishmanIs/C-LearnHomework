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
            this.start = new System.Windows.Forms.Button();
            this.showAWords = new System.Windows.Forms.Button();
            this.showBWords = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.wordsRecord = new System.Windows.Forms.ListBox();
            this.hintInput = new System.Windows.Forms.Label();
            this.inputWords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.Location = new System.Drawing.Point(162, 129);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(139, 45);
            this.start.TabIndex = 0;
            this.start.Text = "开始BB";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // showAWords
            // 
            this.showAWords.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showAWords.Location = new System.Drawing.Point(88, 77);
            this.showAWords.Name = "showAWords";
            this.showAWords.Size = new System.Drawing.Size(102, 46);
            this.showAWords.TabIndex = 1;
            this.showAWords.Text = "A说";
            this.showAWords.UseVisualStyleBackColor = true;
            this.showAWords.Visible = false;
            this.showAWords.Click += new System.EventHandler(this.showAWords_Click);
            // 
            // showBWords
            // 
            this.showBWords.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showBWords.Location = new System.Drawing.Point(196, 77);
            this.showBWords.Name = "showBWords";
            this.showBWords.Size = new System.Drawing.Size(105, 46);
            this.showBWords.TabIndex = 2;
            this.showBWords.Text = "B说";
            this.showBWords.UseVisualStyleBackColor = true;
            this.showBWords.Visible = false;
            this.showBWords.Click += new System.EventHandler(this.showBWords_Click);
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.help.Location = new System.Drawing.Point(307, 77);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(82, 46);
            this.help.TabIndex = 3;
            this.help.Text = "帮助";
            this.help.UseVisualStyleBackColor = true;
            this.help.Visible = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // wordsRecord
            // 
            this.wordsRecord.FormattingEnabled = true;
            this.wordsRecord.ItemHeight = 12;
            this.wordsRecord.Location = new System.Drawing.Point(88, 133);
            this.wordsRecord.Name = "wordsRecord";
            this.wordsRecord.Size = new System.Drawing.Size(301, 196);
            this.wordsRecord.TabIndex = 4;
            this.wordsRecord.Visible = false;
            // 
            // hintInput
            // 
            this.hintInput.AutoSize = true;
            this.hintInput.BackColor = System.Drawing.Color.Transparent;
            this.hintInput.Location = new System.Drawing.Point(86, 53);
            this.hintInput.Name = "hintInput";
            this.hintInput.Size = new System.Drawing.Size(53, 12);
            this.hintInput.TabIndex = 6;
            this.hintInput.Text = "请输入：";
            this.hintInput.Visible = false;
            // 
            // inputWords
            // 
            this.inputWords.Location = new System.Drawing.Point(145, 50);
            this.inputWords.Name = "inputWords";
            this.inputWords.Size = new System.Drawing.Size(244, 21);
            this.inputWords.TabIndex = 7;
            this.inputWords.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 349);
            this.Controls.Add(this.inputWords);
            this.Controls.Add(this.hintInput);
            this.Controls.Add(this.wordsRecord);
            this.Controls.Add(this.help);
            this.Controls.Add(this.showBWords);
            this.Controls.Add(this.showAWords);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "第一讲作业 BB练习";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button showAWords;
        private System.Windows.Forms.Button showBWords;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.ListBox wordsRecord;
        private System.Windows.Forms.Label hintInput;
        private System.Windows.Forms.TextBox inputWords;
    }
}

