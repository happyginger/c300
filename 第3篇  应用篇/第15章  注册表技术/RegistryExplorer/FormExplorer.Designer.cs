namespace RegistryExplorer
{
    partial class FormExplorer
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
            this.tVRegistryExplorer = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tVRegistryExplorer
            // 
            this.tVRegistryExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tVRegistryExplorer.Location = new System.Drawing.Point(0, 0);
            this.tVRegistryExplorer.Name = "tVRegistryExplorer";
            this.tVRegistryExplorer.Size = new System.Drawing.Size(392, 373);
            this.tVRegistryExplorer.TabIndex = 0;
            this.tVRegistryExplorer.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tVRegistryExplorer_AfterExpand);
            // 
            // FormExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.tVRegistryExplorer);
            this.Name = "FormExplorer";
            this.Text = "注册表浏览器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tVRegistryExplorer;
    }
}

