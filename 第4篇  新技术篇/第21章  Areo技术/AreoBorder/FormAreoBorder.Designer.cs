﻿namespace AreoBorder
{
    partial class FormAreoBorder
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
            this.cBAreo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cBAreo
            // 
            this.cBAreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBAreo.Appearance = System.Windows.Forms.Appearance.Button;
            this.cBAreo.Location = new System.Drawing.Point(82, 121);
            this.cBAreo.Name = "cBAreo";
            this.cBAreo.Size = new System.Drawing.Size(120, 21);
            this.cBAreo.TabIndex = 0;
            this.cBAreo.Text = "无Areo效果";
            this.cBAreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cBAreo.ThreeState = true;
            this.cBAreo.UseVisualStyleBackColor = true;
            this.cBAreo.CheckStateChanged += new System.EventHandler(this.cBAreo_CheckStateChanged);
            // 
            // FormAreoBorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cBAreo);
            this.Name = "FormAreoBorder";
            this.Text = "带边框磨砂玻璃窗体";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cBAreo;
    }
}

