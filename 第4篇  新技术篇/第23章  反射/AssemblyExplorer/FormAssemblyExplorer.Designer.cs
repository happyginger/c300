namespace AssemblyExplorer
{
    partial class FormAssemblyExplorer
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
            this.mSMain = new System.Windows.Forms.MenuStrip();
            this.TSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tVClass = new System.Windows.Forms.TreeView();
            this.oFDOpen = new System.Windows.Forms.OpenFileDialog();
            this.mSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSMain
            // 
            this.mSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFile});
            this.mSMain.Location = new System.Drawing.Point(0, 0);
            this.mSMain.Name = "mSMain";
            this.mSMain.Size = new System.Drawing.Size(303, 24);
            this.mSMain.TabIndex = 0;
            this.mSMain.Text = "menuStrip1";
            // 
            // TSMIFile
            // 
            this.TSMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIOpen});
            this.TSMIFile.Name = "TSMIFile";
            this.TSMIFile.Size = new System.Drawing.Size(41, 20);
            this.TSMIFile.Text = "文件";
            // 
            // TSMIOpen
            // 
            this.TSMIOpen.Name = "TSMIOpen";
            this.TSMIOpen.Size = new System.Drawing.Size(94, 22);
            this.TSMIOpen.Text = "打开";
            this.TSMIOpen.Click += new System.EventHandler(this.TSMIOpen_Click);
            // 
            // tVClass
            // 
            this.tVClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tVClass.Location = new System.Drawing.Point(0, 24);
            this.tVClass.Name = "tVClass";
            this.tVClass.Size = new System.Drawing.Size(303, 402);
            this.tVClass.TabIndex = 1;
            // 
            // oFDOpen
            // 
            this.oFDOpen.FileName = ".dll";
            this.oFDOpen.Filter = "DLL 文件|*.dll|可执行文件|*.exe";
            this.oFDOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.oFDOpen_FileOk);
            // 
            // FormAssemblyExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 426);
            this.Controls.Add(this.tVClass);
            this.Controls.Add(this.mSMain);
            this.MainMenuStrip = this.mSMain;
            this.Name = "FormAssemblyExplorer";
            this.Text = "简单程序集浏览器";
            this.mSMain.ResumeLayout(false);
            this.mSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mSMain;
        private System.Windows.Forms.ToolStripMenuItem TSMIFile;
        private System.Windows.Forms.ToolStripMenuItem TSMIOpen;
        private System.Windows.Forms.TreeView tVClass;
        private System.Windows.Forms.OpenFileDialog oFDOpen;

    }
}

