namespace ChatRoomClient
{
    partial class FormChatRoomClient
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
            this.rTBChat = new System.Windows.Forms.RichTextBox();
            this.tBSend = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.tBName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTBChat
            // 
            this.rTBChat.Location = new System.Drawing.Point(12, 39);
            this.rTBChat.Name = "rTBChat";
            this.rTBChat.Size = new System.Drawing.Size(268, 193);
            this.rTBChat.TabIndex = 0;
            this.rTBChat.Text = "";
            // 
            // tBSend
            // 
            this.tBSend.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tBSend.Location = new System.Drawing.Point(12, 240);
            this.tBSend.Name = "tBSend";
            this.tBSend.Size = new System.Drawing.Size(213, 21);
            this.tBSend.TabIndex = 1;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(231, 238);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(49, 23);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "发送";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tBName
            // 
            this.tBName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tBName.Location = new System.Drawing.Point(59, 12);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(91, 21);
            this.tBName.TabIndex = 3;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 15);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(41, 12);
            this.lName.TabIndex = 4;
            this.lName.Text = "姓名：";
            // 
            // FormChatRoomClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tBSend);
            this.Controls.Add(this.rTBChat);
            this.Name = "FormChatRoomClient";
            this.Text = "简单聊天室客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBChat;
        private System.Windows.Forms.TextBox tBSend;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label lName;
    }
}

