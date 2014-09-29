namespace AsyncSocketServer
{
    partial class FormAsyncSocketServer
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
            this.bListen = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.tBSend = new System.Windows.Forms.TextBox();
            this.tBReceive = new System.Windows.Forms.TextBox();
            this.lSend = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.lReceive = new System.Windows.Forms.Label();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bListen
            // 
            this.bListen.Location = new System.Drawing.Point(125, 238);
            this.bListen.Name = "bListen";
            this.bListen.Size = new System.Drawing.Size(75, 23);
            this.bListen.TabIndex = 12;
            this.bListen.Text = "监听";
            this.bListen.UseVisualStyleBackColor = true;
            this.bListen.Click += new System.EventHandler(this.bListen_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(205, 237);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 11;
            this.bSend.Text = "发送";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tBSend
            // 
            this.tBSend.Location = new System.Drawing.Point(47, 138);
            this.tBSend.Multiline = true;
            this.tBSend.Name = "tBSend";
            this.tBSend.Size = new System.Drawing.Size(233, 94);
            this.tBSend.TabIndex = 9;
            // 
            // tBReceive
            // 
            this.tBReceive.Location = new System.Drawing.Point(47, 38);
            this.tBReceive.Multiline = true;
            this.tBReceive.Name = "tBReceive";
            this.tBReceive.Size = new System.Drawing.Size(233, 94);
            this.tBReceive.TabIndex = 10;
            // 
            // lSend
            // 
            this.lSend.AutoSize = true;
            this.lSend.Location = new System.Drawing.Point(12, 141);
            this.lSend.Name = "lSend";
            this.lSend.Size = new System.Drawing.Size(29, 12);
            this.lSend.TabIndex = 6;
            this.lSend.Text = "发送";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(12, 14);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(29, 12);
            this.lPort.TabIndex = 7;
            this.lPort.Text = "端口";
            // 
            // lReceive
            // 
            this.lReceive.AutoSize = true;
            this.lReceive.Location = new System.Drawing.Point(12, 41);
            this.lReceive.Name = "lReceive";
            this.lReceive.Size = new System.Drawing.Size(29, 12);
            this.lReceive.TabIndex = 8;
            this.lReceive.Text = "接收";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(47, 11);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(38, 21);
            this.tBPort.TabIndex = 5;
            this.tBPort.Text = "8888";
            this.tBPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormAsyncSocketServer
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
            this.Name = "FormAsyncSocketServer";
            this.Text = "异步服务端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bListen;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tBSend;
        private System.Windows.Forms.TextBox tBReceive;
        private System.Windows.Forms.Label lSend;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.Label lReceive;
        private System.Windows.Forms.TextBox tBPort;


    }
}

