namespace ControlComboBox
{
    partial class FormComboBox
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
            this.cBProvince = new System.Windows.Forms.ComboBox();
            this.lProvince = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cBProvince
            // 
            this.cBProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cBProvince.FormattingEnabled = true;
            this.cBProvince.Location = new System.Drawing.Point(143, 23);
            this.cBProvince.Name = "cBProvince";
            this.cBProvince.Size = new System.Drawing.Size(137, 99);
            this.cBProvince.TabIndex = 0;
            this.cBProvince.SelectedIndexChanged += new System.EventHandler(this.cBProvince_SelectedIndexChanged);
            // 
            // lProvince
            // 
            this.lProvince.AutoSize = true;
            this.lProvince.Location = new System.Drawing.Point(47, 110);
            this.lProvince.Name = "lProvince";
            this.lProvince.Size = new System.Drawing.Size(71, 12);
            this.lProvince.TabIndex = 1;
            this.lProvince.Text = "请选择省份:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请选择城市:";
            // 
            // cBCity
            // 
            this.cBCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCity.FormattingEnabled = true;
            this.cBCity.Location = new System.Drawing.Point(124, 145);
            this.cBCity.Name = "cBCity";
            this.cBCity.Size = new System.Drawing.Size(121, 20);
            this.cBCity.TabIndex = 2;
            // 
            // FormComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBCity);
            this.Controls.Add(this.lProvince);
            this.Controls.Add(this.cBProvince);
            this.Name = "FormComboBox";
            this.Text = "利用ComboBox控件实现省市选择";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBProvince;
        private System.Windows.Forms.Label lProvince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBCity;
    }
}

