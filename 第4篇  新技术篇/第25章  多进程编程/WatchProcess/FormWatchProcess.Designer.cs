namespace WatchProcess
{
    partial class FormWatchProcess
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
            this.bAddProcess = new System.Windows.Forms.Button();
            this.cBStartWatch = new System.Windows.Forms.CheckBox();
            this.lBProcess = new System.Windows.Forms.ListBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.tWatch = new System.Windows.Forms.Timer(this.components);
            this.oFDProcess = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bAddProcess
            // 
            this.bAddProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddProcess.Location = new System.Drawing.Point(124, 238);
            this.bAddProcess.Name = "bAddProcess";
            this.bAddProcess.Size = new System.Drawing.Size(75, 23);
            this.bAddProcess.TabIndex = 0;
            this.bAddProcess.Text = "添加程序";
            this.bAddProcess.UseVisualStyleBackColor = true;
            this.bAddProcess.Click += new System.EventHandler(this.bAddProcess_Click);
            // 
            // cBStartWatch
            // 
            this.cBStartWatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cBStartWatch.Appearance = System.Windows.Forms.Appearance.Button;
            this.cBStartWatch.Location = new System.Drawing.Point(43, 238);
            this.cBStartWatch.Name = "cBStartWatch";
            this.cBStartWatch.Size = new System.Drawing.Size(75, 23);
            this.cBStartWatch.TabIndex = 1;
            this.cBStartWatch.Text = "启动守护";
            this.cBStartWatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cBStartWatch.UseVisualStyleBackColor = true;
            this.cBStartWatch.CheckedChanged += new System.EventHandler(this.cBStartWatch_CheckedChanged);
            // 
            // lBProcess
            // 
            this.lBProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lBProcess.FormattingEnabled = true;
            this.lBProcess.ItemHeight = 12;
            this.lBProcess.Location = new System.Drawing.Point(12, 12);
            this.lBProcess.Name = "lBProcess";
            this.lBProcess.Size = new System.Drawing.Size(268, 220);
            this.lBProcess.TabIndex = 2;
            // 
            // bDelete
            // 
            this.bDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bDelete.Location = new System.Drawing.Point(205, 238);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 0;
            this.bDelete.Text = "删除程序";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // tWatch
            // 
            this.tWatch.Interval = 1000;
            this.tWatch.Tick += new System.EventHandler(this.tWatch_Tick);
            // 
            // oFDProcess
            // 
            this.oFDProcess.FileName = "openFileDialog1";
            this.oFDProcess.Filter = "可执行文件|*.exe";
            this.oFDProcess.FileOk += new System.ComponentModel.CancelEventHandler(this.oFDProcess_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lBProcess);
            this.Controls.Add(this.cBStartWatch);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAddProcess);
            this.Name = "Form1";
            this.Text = "进程守护";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddProcess;
        private System.Windows.Forms.CheckBox cBStartWatch;
        private System.Windows.Forms.ListBox lBProcess;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Timer tWatch;
        private System.Windows.Forms.OpenFileDialog oFDProcess;
    }
}

