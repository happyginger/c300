namespace CallUser32
{
    partial class FormUser32
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
            this.components = new System.ComponentModel.Container();
            this.lLeft = new System.Windows.Forms.Label();
            this.lTop = new System.Windows.Forms.Label();
            this.lWidth = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.formUser32BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formUser32BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lLeft
            // 
            this.lLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lLeft.Location = new System.Drawing.Point(12, 9);
            this.lLeft.Name = "lLeft";
            this.lLeft.Size = new System.Drawing.Size(100, 23);
            this.lLeft.TabIndex = 0;
            // 
            // lTop
            // 
            this.lTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lTop.Location = new System.Drawing.Point(12, 32);
            this.lTop.Name = "lTop";
            this.lTop.Size = new System.Drawing.Size(100, 23);
            this.lTop.TabIndex = 0;
            // 
            // lWidth
            // 
            this.lWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lWidth.Location = new System.Drawing.Point(12, 55);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(100, 23);
            this.lWidth.TabIndex = 0;
            // 
            // lHeight
            // 
            this.lHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lHeight.Location = new System.Drawing.Point(12, 78);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(100, 23);
            this.lHeight.TabIndex = 0;
            // 
            // FormUser32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.lTop);
            this.Controls.Add(this.lLeft);
            this.Name = "FormUser32";
            this.Text = "利用WIN32 API任意拖动窗体";
            ((System.ComponentModel.ISupportInitialize)(this.formUser32BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lLeft;
        private System.Windows.Forms.Label lTop;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.BindingSource formUser32BindingSource;
    }
}

