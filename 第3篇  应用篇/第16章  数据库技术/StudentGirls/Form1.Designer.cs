namespace StudentGirls
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
            this.dGVGirls = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGirls)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVGirls
            // 
            this.dGVGirls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGirls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVGirls.Location = new System.Drawing.Point(0, 0);
            this.dGVGirls.Name = "dGVGirls";
            this.dGVGirls.RowTemplate.Height = 23;
            this.dGVGirls.Size = new System.Drawing.Size(487, 283);
            this.dGVGirls.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 283);
            this.Controls.Add(this.dGVGirls);
            this.Name = "Form1";
            this.Text = "查询女生信息";
            ((System.ComponentModel.ISupportInitialize)(this.dGVGirls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVGirls;
    }
}

