namespace HideHardDisk
{
    partial class FormbtnHardDisk
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
            this.cBDisk = new System.Windows.Forms.CheckedListBox();
            this.btnHideHardDisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBDisk
            // 
            this.cBDisk.FormattingEnabled = true;
            this.cBDisk.Location = new System.Drawing.Point(12, 52);
            this.cBDisk.Name = "cBDisk";
            this.cBDisk.Size = new System.Drawing.Size(268, 212);
            this.cBDisk.TabIndex = 0;
            // 
            // btnHideHardDisk
            // 
            this.btnHideHardDisk.Location = new System.Drawing.Point(12, 12);
            this.btnHideHardDisk.Name = "btnHideHardDisk";
            this.btnHideHardDisk.Size = new System.Drawing.Size(268, 23);
            this.btnHideHardDisk.TabIndex = 1;
            this.btnHideHardDisk.Text = "隐藏指定磁盘";
            this.btnHideHardDisk.UseVisualStyleBackColor = true;
            this.btnHideHardDisk.Click += new System.EventHandler(this.btnHideHardDisk_Click);
            // 
            // FormbtnHardDisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnHideHardDisk);
            this.Controls.Add(this.cBDisk);
            this.Name = "FormbtnHardDisk";
            this.Text = "隐藏指定磁盘";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cBDisk;
        private System.Windows.Forms.Button btnHideHardDisk;
    }
}

