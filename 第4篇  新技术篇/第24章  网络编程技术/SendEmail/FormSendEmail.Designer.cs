namespace SendEmail
{
    partial class FormSendEmail
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
            this.bSend = new System.Windows.Forms.Button();
            this.rTBBody = new System.Windows.Forms.RichTextBox();
            this.lAddressee = new System.Windows.Forms.Label();
            this.tBAddressee = new System.Windows.Forms.TextBox();
            this.lBody = new System.Windows.Forms.Label();
            this.tBSubject = new System.Windows.Forms.TextBox();
            this.lSubject = new System.Windows.Forms.Label();
            this.lBAttachment = new System.Windows.Forms.ListBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.oFDAttachment = new System.Windows.Forms.OpenFileDialog();
            this.lAttachment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSend.Location = new System.Drawing.Point(205, 238);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 0;
            this.bSend.Text = "发送邮件";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // rTBBody
            // 
            this.rTBBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBBody.Location = new System.Drawing.Point(57, 115);
            this.rTBBody.Name = "rTBBody";
            this.rTBBody.Size = new System.Drawing.Size(223, 117);
            this.rTBBody.TabIndex = 1;
            this.rTBBody.Text = "300 classic examples<br>\n300 classic examples<br>\n300 classic examples<br>\n300 cl" +
                "assic examples<br>\n300 classic examples<br>\n300 classic examples<br>";
            // 
            // lAddressee
            // 
            this.lAddressee.AutoSize = true;
            this.lAddressee.Location = new System.Drawing.Point(10, 15);
            this.lAddressee.Name = "lAddressee";
            this.lAddressee.Size = new System.Drawing.Size(41, 12);
            this.lAddressee.TabIndex = 2;
            this.lAddressee.Text = "收件人";
            // 
            // tBAddressee
            // 
            this.tBAddressee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBAddressee.Location = new System.Drawing.Point(57, 12);
            this.tBAddressee.Name = "tBAddressee";
            this.tBAddressee.Size = new System.Drawing.Size(223, 21);
            this.tBAddressee.TabIndex = 3;
            this.tBAddressee.Text = "iloujiok@sina.com";
            // 
            // lBody
            // 
            this.lBody.AutoSize = true;
            this.lBody.Location = new System.Drawing.Point(12, 115);
            this.lBody.Name = "lBody";
            this.lBody.Size = new System.Drawing.Size(41, 12);
            this.lBody.TabIndex = 4;
            this.lBody.Text = "内容：";
            // 
            // tBSubject
            // 
            this.tBSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSubject.Location = new System.Drawing.Point(57, 39);
            this.tBSubject.Name = "tBSubject";
            this.tBSubject.Size = new System.Drawing.Size(223, 21);
            this.tBSubject.TabIndex = 3;
            this.tBSubject.Text = "测试邮件";
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Location = new System.Drawing.Point(12, 42);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(41, 12);
            this.lSubject.TabIndex = 4;
            this.lSubject.Text = "标题：";
            // 
            // lBAttachment
            // 
            this.lBAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lBAttachment.FormattingEnabled = true;
            this.lBAttachment.ItemHeight = 12;
            this.lBAttachment.Location = new System.Drawing.Point(57, 69);
            this.lBAttachment.Name = "lBAttachment";
            this.lBAttachment.Size = new System.Drawing.Size(223, 40);
            this.lBAttachment.TabIndex = 5;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(124, 238);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "添加附件";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // oFDAttachment
            // 
            this.oFDAttachment.DefaultExt = "*.jpg";
            this.oFDAttachment.Filter = "图片文件|*.jpg";
            this.oFDAttachment.FileOk += new System.ComponentModel.CancelEventHandler(this.oFDAttachment_FileOk);
            // 
            // lAttachment
            // 
            this.lAttachment.AutoSize = true;
            this.lAttachment.Location = new System.Drawing.Point(12, 69);
            this.lAttachment.Name = "lAttachment";
            this.lAttachment.Size = new System.Drawing.Size(41, 12);
            this.lAttachment.TabIndex = 4;
            this.lAttachment.Text = "附件：";
            // 
            // FormSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lBAttachment);
            this.Controls.Add(this.lSubject);
            this.Controls.Add(this.lAttachment);
            this.Controls.Add(this.lBody);
            this.Controls.Add(this.tBSubject);
            this.Controls.Add(this.tBAddressee);
            this.Controls.Add(this.lAddressee);
            this.Controls.Add(this.rTBBody);
            this.Controls.Add(this.bSend);
            this.Name = "FormSendEmail";
            this.Text = "发送电子邮件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.RichTextBox rTBBody;
        private System.Windows.Forms.Label lAddressee;
        private System.Windows.Forms.TextBox tBAddressee;
        private System.Windows.Forms.Label lBody;
        private System.Windows.Forms.TextBox tBSubject;
        private System.Windows.Forms.Label lSubject;
        private System.Windows.Forms.ListBox lBAttachment;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.OpenFileDialog oFDAttachment;
        private System.Windows.Forms.Label lAttachment;
    }
}

