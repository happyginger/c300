namespace ComponentEventLog
{
    partial class FormEventLog
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tBLog = new System.Windows.Forms.TextBox();
            this.bWrite = new System.Windows.Forms.Button();
            this.lBLog = new System.Windows.Forms.ListBox();
            this.bRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tBLog
            // 
            this.tBLog.Location = new System.Drawing.Point(12, 12);
            this.tBLog.Name = "tBLog";
            this.tBLog.Size = new System.Drawing.Size(268, 21);
            this.tBLog.TabIndex = 0;
            // 
            // bWrite
            // 
            this.bWrite.Location = new System.Drawing.Point(205, 39);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(75, 23);
            this.bWrite.TabIndex = 1;
            this.bWrite.Text = "写入日志";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // lBLog
            // 
            this.lBLog.FormattingEnabled = true;
            this.lBLog.ItemHeight = 12;
            this.lBLog.Location = new System.Drawing.Point(12, 68);
            this.lBLog.Name = "lBLog";
            this.lBLog.Size = new System.Drawing.Size(268, 160);
            this.lBLog.TabIndex = 2;
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(205, 238);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(75, 23);
            this.bRead.TabIndex = 3;
            this.bRead.Text = "读取日志";
            this.bRead.UseVisualStyleBackColor = true;
            this.bRead.Click += new System.EventHandler(this.bRead_Click);
            // 
            // FormEventLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bRead);
            this.Controls.Add(this.lBLog);
            this.Controls.Add(this.bWrite);
            this.Controls.Add(this.tBLog);
            this.Name = "FormEventLog";
            this.Text = "利用EventLog组件读写系统日志";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button bRead;
        private System.Windows.Forms.ListBox lBLog;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.TextBox tBLog;
    }
}

