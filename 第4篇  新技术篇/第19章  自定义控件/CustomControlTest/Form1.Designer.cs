namespace CustomControlTest
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
            this.switchCheckBox1 = new CustomControl.SwitchCheckBox();
            this.SuspendLayout();
            // 
            // switchCheckBox1
            // 
            this.switchCheckBox1.Location = new System.Drawing.Point(96, 121);
            this.switchCheckBox1.MinimumSize = new System.Drawing.Size(20, 30);
            this.switchCheckBox1.Name = "switchCheckBox1";
            this.switchCheckBox1.Size = new System.Drawing.Size(100, 30);
            this.switchCheckBox1.TabIndex = 1;
            this.switchCheckBox1.CheckedChanged += new System.EventHandler(this.switchCheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.switchCheckBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.SwitchCheckBox switchCheckBox1;






    }
}

