namespace ChatRoomServer
{
    partial class FormChatRoomServer
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
            this.lBClient = new System.Windows.Forms.ListBox();
            this.rTBChat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lBClient
            // 
            this.lBClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.lBClient.FormattingEnabled = true;
            this.lBClient.ItemHeight = 12;
            this.lBClient.Location = new System.Drawing.Point(222, 0);
            this.lBClient.Name = "lBClient";
            this.lBClient.Size = new System.Drawing.Size(70, 273);
            this.lBClient.TabIndex = 0;
            // 
            // rTBChat
            // 
            this.rTBChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBChat.Location = new System.Drawing.Point(0, 0);
            this.rTBChat.Name = "rTBChat";
            this.rTBChat.Size = new System.Drawing.Size(222, 273);
            this.rTBChat.TabIndex = 1;
            this.rTBChat.Text = "";
            // 
            // FormChatRoomServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.rTBChat);
            this.Controls.Add(this.lBClient);
            this.Name = "FormChatRoomServer";
            this.Text = "聊天室服务端";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBClient;
        private System.Windows.Forms.RichTextBox rTBChat;
    }
}

