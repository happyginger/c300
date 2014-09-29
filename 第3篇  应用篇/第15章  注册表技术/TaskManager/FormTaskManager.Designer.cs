namespace TaskManager
{
    partial class FormTaskManager
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
            this.btnForbidTaskManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForbidTaskManager
            // 
            this.btnForbidTaskManager.Location = new System.Drawing.Point(12, 12);
            this.btnForbidTaskManager.Name = "btnForbidTaskManager";
            this.btnForbidTaskManager.Size = new System.Drawing.Size(268, 23);
            this.btnForbidTaskManager.TabIndex = 0;
            this.btnForbidTaskManager.Text = "禁用任务管理器";
            this.btnForbidTaskManager.UseVisualStyleBackColor = true;
            this.btnForbidTaskManager.Click += new System.EventHandler(this.btnForbidTaskManager_Click);
            // 
            // FormTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnForbidTaskManager);
            this.Name = "FormTaskManager";
            this.Text = "禁用任务管理器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForbidTaskManager;
    }
}

