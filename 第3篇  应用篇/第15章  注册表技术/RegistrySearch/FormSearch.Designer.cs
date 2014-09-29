namespace RegistrySearch
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
            this.bSearch = new System.Windows.Forms.Button();
            this.tBKeywords = new System.Windows.Forms.TextBox();
            this.lBSearchResult = new System.Windows.Forms.ListBox();
            this.sSSearch = new System.Windows.Forms.StatusStrip();
            this.tSSLSearching = new System.Windows.Forms.ToolStripStatusLabel();
            this.bWSearch = new System.ComponentModel.BackgroundWorker();
            this.sSSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Location = new System.Drawing.Point(505, 12);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 0;
            this.bSearch.Text = "搜索";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tBKeywords
            // 
            this.tBKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBKeywords.Location = new System.Drawing.Point(12, 14);
            this.tBKeywords.Name = "tBKeywords";
            this.tBKeywords.Size = new System.Drawing.Size(487, 21);
            this.tBKeywords.TabIndex = 1;
            // 
            // lBSearchResult
            // 
            this.lBSearchResult.FormattingEnabled = true;
            this.lBSearchResult.ItemHeight = 12;
            this.lBSearchResult.Location = new System.Drawing.Point(12, 41);
            this.lBSearchResult.Name = "lBSearchResult";
            this.lBSearchResult.Size = new System.Drawing.Size(568, 496);
            this.lBSearchResult.TabIndex = 2;
            // 
            // sSSearch
            // 
            this.sSSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLSearching});
            this.sSSearch.Location = new System.Drawing.Point(0, 551);
            this.sSSearch.Name = "sSSearch";
            this.sSSearch.Size = new System.Drawing.Size(592, 22);
            this.sSSearch.TabIndex = 3;
            this.sSSearch.Text = "statusStrip1";
            // 
            // tSSLSearching
            // 
            this.tSSLSearching.Name = "tSSLSearching";
            this.tSSLSearching.Size = new System.Drawing.Size(0, 17);
            // 
            // bWSearch
            // 
            this.bWSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWSearch_DoWork);
            this.bWSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWSearch_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 573);
            this.Controls.Add(this.sSSearch);
            this.Controls.Add(this.lBSearchResult);
            this.Controls.Add(this.tBKeywords);
            this.Controls.Add(this.bSearch);
            this.Name = "Form1";
            this.Text = "搜索注册表";
            this.sSSearch.ResumeLayout(false);
            this.sSSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tBKeywords;
        private System.Windows.Forms.ListBox lBSearchResult;
        private System.Windows.Forms.StatusStrip sSSearch;
        private System.Windows.Forms.ToolStripStatusLabel tSSLSearching;
        private System.ComponentModel.BackgroundWorker bWSearch;
    }
}

