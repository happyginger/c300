namespace Registry_Boot
{
    partial class FormBoot
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
            this.btnBoot = new System.Windows.Forms.Button();
            this.btnForbidHomepage = new System.Windows.Forms.Button();
            this.btnForbidTaskManager = new System.Windows.Forms.Button();
            this.btnHideHardDisk = new System.Windows.Forms.Button();
            this.btnForbidRegistry = new System.Windows.Forms.Button();
            this.lboot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBoot
            // 
            this.btnBoot.Location = new System.Drawing.Point(12, 12);
            this.btnBoot.Name = "btnBoot";
            this.btnBoot.Size = new System.Drawing.Size(260, 23);
            this.btnBoot.TabIndex = 0;
            this.btnBoot.Text = "程序开机自动启动";
            this.btnBoot.UseVisualStyleBackColor = true;
            this.btnBoot.Click += new System.EventHandler(this.btnBoot_Click);
            // 
            // btnForbidHomepage
            // 
            this.btnForbidHomepage.Location = new System.Drawing.Point(12, 41);
            this.btnForbidHomepage.Name = "btnForbidHomepage";
            this.btnForbidHomepage.Size = new System.Drawing.Size(260, 23);
            this.btnForbidHomepage.TabIndex = 1;
            this.btnForbidHomepage.Text = "禁止修改主页";
            this.btnForbidHomepage.UseVisualStyleBackColor = true;
            this.btnForbidHomepage.Click += new System.EventHandler(this.btnForbidHomepage_Click);
            // 
            // btnForbidTaskManager
            // 
            this.btnForbidTaskManager.Location = new System.Drawing.Point(12, 70);
            this.btnForbidTaskManager.Name = "btnForbidTaskManager";
            this.btnForbidTaskManager.Size = new System.Drawing.Size(260, 23);
            this.btnForbidTaskManager.TabIndex = 2;
            this.btnForbidTaskManager.Text = "禁用任务管理器";
            this.btnForbidTaskManager.UseVisualStyleBackColor = true;
            this.btnForbidTaskManager.Click += new System.EventHandler(this.btnForbidTaskManager_Click);
            // 
            // btnHideHardDisk
            // 
            this.btnHideHardDisk.Location = new System.Drawing.Point(12, 99);
            this.btnHideHardDisk.Name = "btnHideHardDisk";
            this.btnHideHardDisk.Size = new System.Drawing.Size(260, 23);
            this.btnHideHardDisk.TabIndex = 3;
            this.btnHideHardDisk.Text = "隐藏指定磁盘";
            this.btnHideHardDisk.UseVisualStyleBackColor = true;
            this.btnHideHardDisk.Click += new System.EventHandler(this.btnHideHardDisk_Click);
            // 
            // btnForbidRegistry
            // 
            this.btnForbidRegistry.Location = new System.Drawing.Point(12, 128);
            this.btnForbidRegistry.Name = "btnForbidRegistry";
            this.btnForbidRegistry.Size = new System.Drawing.Size(260, 23);
            this.btnForbidRegistry.TabIndex = 4;
            this.btnForbidRegistry.Text = "禁止打开注册表";
            this.btnForbidRegistry.UseVisualStyleBackColor = true;
            this.btnForbidRegistry.Click += new System.EventHandler(this.btnForbidRegistry_Click);
            // 
            // lboot
            // 
            this.lboot.AutoSize = true;
            this.lboot.Location = new System.Drawing.Point(12, 252);
            this.lboot.Name = "lboot";
            this.lboot.Size = new System.Drawing.Size(65, 12);
            this.lboot.TabIndex = 5;
            this.lboot.Text = "开机未启动";
            // 
            // FormBoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lboot);
            this.Controls.Add(this.btnForbidRegistry);
            this.Controls.Add(this.btnHideHardDisk);
            this.Controls.Add(this.btnForbidTaskManager);
            this.Controls.Add(this.btnForbidHomepage);
            this.Controls.Add(this.btnBoot);
            this.Name = "FormBoot";
            this.Text = "开机启动";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoot;
        private System.Windows.Forms.Button btnForbidHomepage;
        private System.Windows.Forms.Button btnForbidTaskManager;
        private System.Windows.Forms.Button btnHideHardDisk;
        private System.Windows.Forms.Button btnForbidRegistry;
        private System.Windows.Forms.Label lboot;
    }
}

