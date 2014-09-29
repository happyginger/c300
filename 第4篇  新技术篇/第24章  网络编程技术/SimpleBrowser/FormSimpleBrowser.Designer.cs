namespace SimpleBrowser
{
    partial class Form1
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
            this.wBSimple = new System.Windows.Forms.WebBrowser();
            this.bGoBack = new System.Windows.Forms.Button();
            this.bEnter = new System.Windows.Forms.Button();
            this.bGoForward = new System.Windows.Forms.Button();
            this.cBUrl = new System.Windows.Forms.ComboBox();
            this.bHomepage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wBSimple
            // 
            this.wBSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wBSimple.Location = new System.Drawing.Point(9, 50);
            this.wBSimple.Margin = new System.Windows.Forms.Padding(0);
            this.wBSimple.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBSimple.Name = "wBSimple";
            this.wBSimple.Size = new System.Drawing.Size(774, 514);
            this.wBSimple.TabIndex = 0;
            // 
            // bGoBack
            // 
            this.bGoBack.Location = new System.Drawing.Point(12, 12);
            this.bGoBack.Name = "bGoBack";
            this.bGoBack.Size = new System.Drawing.Size(42, 23);
            this.bGoBack.TabIndex = 1;
            this.bGoBack.Text = "后退";
            this.bGoBack.UseVisualStyleBackColor = true;
            this.bGoBack.Click += new System.EventHandler(this.bGoBack_Click);
            // 
            // bEnter
            // 
            this.bEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEnter.Location = new System.Drawing.Point(738, 12);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(42, 23);
            this.bEnter.TabIndex = 1;
            this.bEnter.Text = "转到";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // bGoForward
            // 
            this.bGoForward.Location = new System.Drawing.Point(60, 12);
            this.bGoForward.Name = "bGoForward";
            this.bGoForward.Size = new System.Drawing.Size(42, 23);
            this.bGoForward.TabIndex = 1;
            this.bGoForward.Text = "前进";
            this.bGoForward.UseVisualStyleBackColor = true;
            this.bGoForward.Click += new System.EventHandler(this.bGoForward_Click);
            // 
            // cBUrl
            // 
            this.cBUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cBUrl.FormattingEnabled = true;
            this.cBUrl.Location = new System.Drawing.Point(156, 14);
            this.cBUrl.Name = "cBUrl";
            this.cBUrl.Size = new System.Drawing.Size(576, 20);
            this.cBUrl.TabIndex = 2;
            // 
            // bHomepage
            // 
            this.bHomepage.Location = new System.Drawing.Point(108, 12);
            this.bHomepage.Name = "bHomepage";
            this.bHomepage.Size = new System.Drawing.Size(42, 23);
            this.bHomepage.TabIndex = 3;
            this.bHomepage.Text = "主页";
            this.bHomepage.UseVisualStyleBackColor = true;
            this.bHomepage.Click += new System.EventHandler(this.bHomepage_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.bHomepage);
            this.Controls.Add(this.cBUrl);
            this.Controls.Add(this.bGoForward);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.bGoBack);
            this.Controls.Add(this.wBSimple);
            this.Name = "Form1";
            this.Text = "简单浏览器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wBSimple;
        private System.Windows.Forms.Button bGoBack;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Button bGoForward;
        private System.Windows.Forms.ComboBox cBUrl;
        private System.Windows.Forms.Button bHomepage;
    }
}

