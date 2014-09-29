namespace StudentGridView
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
            this.dGVStudent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVStudent
            // 
            this.dGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVStudent.Location = new System.Drawing.Point(0, 0);
            this.dGVStudent.Name = "dGVStudent";
            this.dGVStudent.RowTemplate.Height = 23;
            this.dGVStudent.Size = new System.Drawing.Size(570, 355);
            this.dGVStudent.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 355);
            this.Controls.Add(this.dGVStudent);
            this.Name = "Form1";
            this.Text = "显示学生信息表";
            ((System.ComponentModel.ISupportInitialize)(this.dGVStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVStudent;
    }
}

