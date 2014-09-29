namespace SyncSocketClient
{
    partial class FormSyncSocketClient
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
            this.bConnect = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.tBSend = new System.Windows.Forms.TextBox();
            this.tBReceive = new System.Windows.Forms.TextBox();
            this.lSend = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lReceive = new System.Windows.Forms.Label();
            this.lIP = new System.Windows.Forms.Label();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.tBIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(125, 238);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 14;
            this.bConnect.Text = "连接";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(205, 237);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 13;
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
            this.tBSend.TabIndex = 11;
            // 
            // tBReceive
            // 
            this.tBReceive.Location = new System.Drawing.Point(47, 38);
            this.tBReceive.Multiline = true;
            this.tBReceive.Name = "tBReceive";
            this.tBReceive.Size = new System.Drawing.Size(233, 94);
            this.tBReceive.TabIndex = 12;
            // 
            // lSend
            // 
            this.lSend.AutoSize = true;
            this.lSend.Location = new System.Drawing.Point(12, 141);
            this.lSend.Name = "lSend";
            this.lSend.Size = new System.Drawing.Size(29, 12);
            this.lSend.TabIndex = 10;
            this.lSend.Text = "发送";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "端口";
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
            // lIP
            // 
            this.lIP.AutoSize = true;
            this.lIP.Location = new System.Drawing.Point(12, 14);
            this.lIP.Name = "lIP";
            this.lIP.Size = new System.Drawing.Size(29, 12);
            this.lIP.TabIndex = 9;
            this.lIP.Text = "地址";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(186, 11);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(38, 21);
            this.tBPort.TabIndex = 5;
            this.tBPort.Text = "8888";
            this.tBPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBIP
            // 
            this.tBIP.Location = new System.Drawing.Point(47, 11);
            this.tBIP.Name = "tBIP";
            this.tBIP.Size = new System.Drawing.Size(98, 21);
            this.tBIP.TabIndex = 6;
            this.tBIP.Text = "127.0.0.1";
            this.tBIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormSyncSocketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tBSend);
            this.Controls.Add(this.tBReceive);
            this.Controls.Add(this.lSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lReceive);
            this.Controls.Add(this.lIP);
            this.Controls.Add(this.tBPort);
            this.Controls.Add(this.tBIP);
            this.Name = "FormSyncSocketClient";
            this.Text = "同步客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.TextBox tBSend;
        private System.Windows.Forms.TextBox tBReceive;
        private System.Windows.Forms.Label lSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lReceive;
        private System.Windows.Forms.Label lIP;
        private System.Windows.Forms.TextBox tBPort;
        private System.Windows.Forms.TextBox tBIP;
    }
}

