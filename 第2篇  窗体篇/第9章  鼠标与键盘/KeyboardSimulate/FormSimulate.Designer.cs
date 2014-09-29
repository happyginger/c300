namespace KeyboardSimulate
{
    partial class FormSimulate
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bNormal = new System.Windows.Forms.Button();
            this.bspecial = new System.Windows.Forms.Button();
            this.bRepeat = new System.Windows.Forms.Button();
            this.bCombine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // bNormal
            // 
            this.bNormal.Location = new System.Drawing.Point(13, 39);
            this.bNormal.Name = "bNormal";
            this.bNormal.Size = new System.Drawing.Size(62, 22);
            this.bNormal.TabIndex = 1;
            this.bNormal.Text = "常用字符";
            this.bNormal.UseVisualStyleBackColor = true;
            this.bNormal.Click += new System.EventHandler(this.bNormal_Click);
            // 
            // bspecial
            // 
            this.bspecial.Location = new System.Drawing.Point(81, 39);
            this.bspecial.Name = "bspecial";
            this.bspecial.Size = new System.Drawing.Size(62, 22);
            this.bspecial.TabIndex = 2;
            this.bspecial.Text = "特殊指令";
            this.bspecial.UseVisualStyleBackColor = true;
            this.bspecial.Click += new System.EventHandler(this.bSpacial_Click);
            // 
            // bRepeat
            // 
            this.bRepeat.Location = new System.Drawing.Point(149, 39);
            this.bRepeat.Name = "bRepeat";
            this.bRepeat.Size = new System.Drawing.Size(62, 22);
            this.bRepeat.TabIndex = 4;
            this.bRepeat.Text = "重复字符";
            this.bRepeat.UseVisualStyleBackColor = true;
            this.bRepeat.Click += new System.EventHandler(this.bRepeat_Click);
            // 
            // bCombine
            // 
            this.bCombine.Location = new System.Drawing.Point(217, 39);
            this.bCombine.Name = "bCombine";
            this.bCombine.Size = new System.Drawing.Size(62, 22);
            this.bCombine.TabIndex = 3;
            this.bCombine.Text = "组合指令";
            this.bCombine.UseVisualStyleBackColor = true;
            this.bCombine.Click += new System.EventHandler(this.bCombine_Click);
            // 
            // FormSimulate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 73);
            this.Controls.Add(this.bRepeat);
            this.Controls.Add(this.bCombine);
            this.Controls.Add(this.bspecial);
            this.Controls.Add(this.bNormal);
            this.Controls.Add(this.textBox1);
            this.Name = "FormSimulate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模拟键盘输入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bNormal;
        private System.Windows.Forms.Button bspecial;
        private System.Windows.Forms.Button bRepeat;
        private System.Windows.Forms.Button bCombine;
    }
}

