namespace MainProcess
{
    partial class FormMainProcess
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
			this.btnStart = new System.Windows.Forms.Button();
			this.lBProcess = new System.Windows.Forms.ListBox();
			this.btnGetProcess = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "启动子进程";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lBProcess
			// 
			this.lBProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lBProcess.FormattingEnabled = true;
			this.lBProcess.ItemHeight = 12;
			this.lBProcess.Location = new System.Drawing.Point(12, 41);
			this.lBProcess.Name = "lBProcess";
			this.lBProcess.Size = new System.Drawing.Size(268, 220);
			this.lBProcess.TabIndex = 1;
			// 
			// btnGetProcess
			// 
			this.btnGetProcess.Location = new System.Drawing.Point(93, 12);
			this.btnGetProcess.Name = "btnGetProcess";
			this.btnGetProcess.Size = new System.Drawing.Size(75, 23);
			this.btnGetProcess.TabIndex = 2;
			this.btnGetProcess.Text = "获取子进程";
			this.btnGetProcess.UseVisualStyleBackColor = true;
			this.btnGetProcess.Click += new System.EventHandler(this.btnGetProcess_Click);
			// 
			// FormMainProcess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnGetProcess);
			this.Controls.Add(this.lBProcess);
			this.Controls.Add(this.btnStart);
			this.Name = "FormMainProcess";
			this.Text = "主进程";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lBProcess;
        private System.Windows.Forms.Button btnGetProcess;
    }
}

