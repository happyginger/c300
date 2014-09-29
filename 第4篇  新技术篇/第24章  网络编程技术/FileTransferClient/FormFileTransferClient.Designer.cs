namespace FileTransferClient
{
    partial class FormFileTransferClient
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
            this.lIP = new System.Windows.Forms.Label();
            this.tBIP = new System.Windows.Forms.TextBox();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.rTBReceive = new System.Windows.Forms.RichTextBox();
            this.bStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(205, 238);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 0;
            this.bConnect.Text = "连接";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // lIP
            // 
            this.lIP.AutoSize = true;
            this.lIP.Location = new System.Drawing.Point(12, 15);
            this.lIP.Name = "lIP";
            this.lIP.Size = new System.Drawing.Size(41, 12);
            this.lIP.TabIndex = 1;
            this.lIP.Text = "IP地址";
            // 
            // tBIP
            // 
            this.tBIP.Location = new System.Drawing.Point(59, 12);
            this.tBIP.Name = "tBIP";
            this.tBIP.Size = new System.Drawing.Size(125, 21);
            this.tBIP.TabIndex = 2;
            this.tBIP.Text = "127.0.0.1";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(225, 12);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(55, 21);
            this.tBPort.TabIndex = 3;
            this.tBPort.Text = "8888";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(190, 15);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(29, 12);
            this.lPort.TabIndex = 4;
            this.lPort.Text = "端口";
            // 
            // rTBReceive
            // 
            this.rTBReceive.Location = new System.Drawing.Point(12, 39);
            this.rTBReceive.Name = "rTBReceive";
            this.rTBReceive.Size = new System.Drawing.Size(268, 193);
            this.rTBReceive.TabIndex = 5;
            this.rTBReceive.Text = "";
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(124, 238);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 6;
            this.bStop.Text = "停止";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // FormFileTransferClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.rTBReceive);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.tBPort);
            this.Controls.Add(this.tBIP);
            this.Controls.Add(this.lIP);
            this.Controls.Add(this.bConnect);
            this.Name = "FormFileTransferClient";
            this.Text = "文件传输客户端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label lIP;
        private System.Windows.Forms.TextBox tBIP;
        private System.Windows.Forms.TextBox tBPort;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.RichTextBox rTBReceive;
        private System.Windows.Forms.Button bStop;
    }
}

