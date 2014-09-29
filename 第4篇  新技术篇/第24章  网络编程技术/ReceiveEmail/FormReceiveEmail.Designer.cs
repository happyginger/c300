namespace ReceiveEmail
{
    partial class FormReceiveEmail
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
            this.lBEmail = new System.Windows.Forms.ListBox();
            this.rTBEmail = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBEmail
            // 
            this.lBEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBEmail.FormattingEnabled = true;
            this.lBEmail.ItemHeight = 12;
            this.lBEmail.Location = new System.Drawing.Point(0, 0);
            this.lBEmail.Name = "lBEmail";
            this.lBEmail.Size = new System.Drawing.Size(196, 573);
            this.lBEmail.TabIndex = 1;
            this.lBEmail.DoubleClick += new System.EventHandler(this.lBEmail_DoubleClick);
            // 
            // rTBEmail
            // 
            this.rTBEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBEmail.Location = new System.Drawing.Point(0, 0);
            this.rTBEmail.Name = "rTBEmail";
            this.rTBEmail.Size = new System.Drawing.Size(392, 573);
            this.rTBEmail.TabIndex = 2;
            this.rTBEmail.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lBEmail);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rTBEmail);
            this.splitContainer1.Size = new System.Drawing.Size(592, 573);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 4;
            // 
            // FormReceiveEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 573);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormReceiveEmail";
            this.Text = "接收电子邮件";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBEmail;
        private System.Windows.Forms.RichTextBox rTBEmail;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

