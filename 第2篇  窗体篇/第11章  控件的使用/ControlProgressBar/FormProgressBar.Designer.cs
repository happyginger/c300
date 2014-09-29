namespace ControlProgressBar
{
    partial class FormProgressBar
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBProgress = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pBProgress
            // 
            this.pBProgress.Location = new System.Drawing.Point(12, 12);
            this.pBProgress.Name = "pBProgress";
            this.pBProgress.Size = new System.Drawing.Size(268, 23);
            this.pBProgress.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lProgress
            // 
            this.lProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lProgress.Font = new System.Drawing.Font("宋体", 12F);
            this.lProgress.Location = new System.Drawing.Point(96, 41);
            this.lProgress.Margin = new System.Windows.Forms.Padding(3);
            this.lProgress.Name = "lProgress";
            this.lProgress.Size = new System.Drawing.Size(100, 23);
            this.lProgress.TabIndex = 1;
            this.lProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 76);
            this.Controls.Add(this.lProgress);
            this.Controls.Add(this.pBProgress);
            this.Name = "FormProgressBar";
            this.Text = "利用ProgressBar监控程序执行进度";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pBProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lProgress;
    }
}

