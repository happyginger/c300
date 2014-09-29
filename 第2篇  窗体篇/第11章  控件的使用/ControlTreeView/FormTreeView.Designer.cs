namespace FormTreeView
{
    partial class FormTreeView
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
            this.tVComputer = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tVComputer
            // 
            this.tVComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tVComputer.Location = new System.Drawing.Point(0, 0);
            this.tVComputer.Name = "tVComputer";
            this.tVComputer.Size = new System.Drawing.Size(292, 273);
            this.tVComputer.TabIndex = 0;
            this.tVComputer.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tVComputer_AfterExpand);
            // 
            // FormTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tVComputer);
            this.Name = "FormTreeView";
            this.Text = "利用TreeView浏览磁盘目录";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tVComputer;
    }
}

