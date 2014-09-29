namespace FileTransferServer
{
    partial class FormFileTransferServer
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
            this.lPort = new System.Windows.Forms.Label();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bListen
            // 
            this.bListen.Location = new System.Drawing.Point(205, 238);
            this.bListen.Name = "bListen";
            this.bListen.Size = new System.Drawing.Size(75, 23);
            this.bListen.TabIndex = 0;
            this.bListen.Text = "监听";
            this.bListen.UseVisualStyleBackColor = true;
            this.bListen.Click += new System.EventHandler(this.bListen_Click);
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(12, 17);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(35, 12);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "端口:";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(53, 14);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(40, 21);
            this.tBPort.TabIndex = 2;
            this.tBPort.Text = "8888";
            // 
            // FormFileTransferServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.tBPort);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.bListen);
            this.Name = "FormFileTransferServer";
            this.Text = "文件传输服务器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bListen;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tBPort;
    }
}

