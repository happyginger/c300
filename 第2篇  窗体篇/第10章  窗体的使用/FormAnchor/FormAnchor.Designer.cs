namespace FormAnchor
{
    partial class FormAnchor
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
            this.bAll = new System.Windows.Forms.Button();
            this.bTop = new System.Windows.Forms.Button();
            this.bLeft = new System.Windows.Forms.Button();
            this.bBottom = new System.Windows.Forms.Button();
            this.bRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAll
            // 
            this.bAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bAll.Location = new System.Drawing.Point(109, 125);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(75, 23);
            this.bAll.TabIndex = 0;
            this.bAll.Text = "大小自适应";
            this.bAll.UseVisualStyleBackColor = true;
            // 
            // bTop
            // 
            this.bTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.bTop.Location = new System.Drawing.Point(0, 0);
            this.bTop.Name = "bTop";
            this.bTop.Size = new System.Drawing.Size(292, 23);
            this.bTop.TabIndex = 1;
            this.bTop.Text = "宽度自适应";
            this.bTop.UseVisualStyleBackColor = true;
            // 
            // bLeft
            // 
            this.bLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.bLeft.Location = new System.Drawing.Point(0, 23);
            this.bLeft.Name = "bLeft";
            this.bLeft.Size = new System.Drawing.Size(75, 250);
            this.bLeft.TabIndex = 2;
            this.bLeft.Text = "高度自适应";
            this.bLeft.UseVisualStyleBackColor = true;
            // 
            // bBottom
            // 
            this.bBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBottom.Location = new System.Drawing.Point(75, 250);
            this.bBottom.Name = "bBottom";
            this.bBottom.Size = new System.Drawing.Size(217, 23);
            this.bBottom.TabIndex = 3;
            this.bBottom.Text = "宽度自适应";
            this.bBottom.UseVisualStyleBackColor = true;
            // 
            // bRight
            // 
            this.bRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.bRight.Location = new System.Drawing.Point(217, 23);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(75, 227);
            this.bRight.TabIndex = 4;
            this.bRight.Text = "高度自适应";
            this.bRight.UseVisualStyleBackColor = true;
            // 
            // FormAnchor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.bBottom);
            this.Controls.Add(this.bLeft);
            this.Controls.Add(this.bTop);
            this.Controls.Add(this.bAll);
            this.Name = "FormAnchor";
            this.Text = "自动调整窗体中的控件";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAll;
        private System.Windows.Forms.Button bTop;
        private System.Windows.Forms.Button bLeft;
        private System.Windows.Forms.Button bBottom;
        private System.Windows.Forms.Button bRight;
    }
}

