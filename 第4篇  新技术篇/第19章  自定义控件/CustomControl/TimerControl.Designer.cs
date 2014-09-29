namespace CustomControl
{
    partial class TimerControl
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lTimer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lBTime = new System.Windows.Forms.ListBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bTiming = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTimer
            // 
            this.lTimer.BackColor = System.Drawing.Color.White;
            this.lTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTimer.Location = new System.Drawing.Point(0, 0);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(150, 21);
            this.lTimer.TabIndex = 0;
            this.lTimer.Text = "00小时00分00秒0000毫秒";
            this.lTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bTiming);
            this.panel1.Controls.Add(this.bStop);
            this.panel1.Controls.Add(this.bStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 21);
            this.panel1.TabIndex = 2;
            // 
            // lBTime
            // 
            this.lBTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBTime.FormattingEnabled = true;
            this.lBTime.ItemHeight = 12;
            this.lBTime.Location = new System.Drawing.Point(0, 21);
            this.lBTime.Name = "lBTime";
            this.lBTime.Size = new System.Drawing.Size(150, 108);
            this.lBTime.TabIndex = 3;
            // 
            // bStart
            // 
            this.bStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.bStart.Location = new System.Drawing.Point(0, 0);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(42, 21);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "开始";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.bStop.Location = new System.Drawing.Point(108, 0);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(42, 21);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "停止";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bTiming
            // 
            this.bTiming.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTiming.Location = new System.Drawing.Point(42, 0);
            this.bTiming.Name = "bTiming";
            this.bTiming.Size = new System.Drawing.Size(66, 21);
            this.bTiming.TabIndex = 2;
            this.bTiming.Text = "计时";
            this.bTiming.UseVisualStyleBackColor = true;
            this.bTiming.Click += new System.EventHandler(this.bTiming_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lBTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lTimer);
            this.MinimumSize = new System.Drawing.Size(150, 150);
            this.Name = "TimerControl";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bTiming;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.ListBox lBTime;
        private System.Windows.Forms.Timer timer1;
    }
}
