namespace SyncSocketServer
{
    partial class FormSyncSocketServer
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
            this.lPort = new System.Windows.Forms.Label();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.tBReceive = new System.Windows.Forms.TextBox();
            this.lReceive = new System.Windows.Forms.Label();
            this.lSend = new System.Windows.Forms.Label();
            this.tBSend = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(12, 15);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(29, 12);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "端口";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(47, 12);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(38, 21);
            this.tBPort.TabIndex = 0;
            this.tBPort.Text = "8888";
            this.tBPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBReceive
            // 
            this.tBReceive.Location = new System.Drawing.Point(47, 39);
            this.tBReceive.Multiline = true;
            this.tBReceive.Name = "tBReceive";
            this.tBReceive.Size = new System.Drawing.Size(233, 94);
            this.tBReceive.TabIndex = 2;
            // 
            // lReceive
            // 
            this.lReceive.AutoSize = true;
            this.lReceive.Location = new System.Drawing.Point(12, 42);
            this.lReceive.Name = "lReceive";
            this.lReceive.Size = new System.Drawing.Size(29, 12);
            this.lReceive.TabIndex = 1;
            this.lReceive.Text = "接收";
            // 
            // lSend
            // 
            this.lSend.AutoSize = true;
            this.lSend.Location = new System.Drawing.Point(12, 142);
            this.lSend.Name = "lSend";
            this.lSend.Size = new System.Drawing.Size(29, 12);
            this.lSend.TabIndex = 1;
            this.lSend.Text = "发送";
            // 
            // tBSend
            // 
            this.tBSend.Location = new System.Drawing.Point(47, 139);
            this.tBSend.Multiline = true;
            this.tBSend.Name = "tBSend";
            this.tBSend.Size = new System.Drawing.Size(233, 94);
            this.tBSend.TabIndex = 2;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(205, 238);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 3;
            this.bSend.Text = "发送";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bListen
            // 
            this.bListen.Location = new System.Drawing.Point(125, 239);
            this.bListen.Name = "bListen";
            this.bListen.Size = new System.Drawing.Size(75, 23);
            this.bListen.TabIndex = 4;
            this.bListen.Text = "监听";
            this.bListen.UseVisualStyleBackColor = true;
            this.bListen.Click += new System.EventHandler(this.bListen_Click);
            // 
            // FormSyncSocketServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bListen);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tBSend);
            this.Controls.Add(this.tBReceive);
            this.Controls.Add(this.lSend);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.lReceive);
            this.Controls.Add(this.tBPort);
            this.Name = "FormSyncSocketServer";
            this.Text = "同步服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tBPort;
        private System.Windows.Forms.TextBox tBReceive;
        private System.Windows.Forms.Label lReceive;
        private System.Windows.Forms.Label lSend;
        private System.Windows.Forms.TextBox tBSend;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bListen;
    }
}

