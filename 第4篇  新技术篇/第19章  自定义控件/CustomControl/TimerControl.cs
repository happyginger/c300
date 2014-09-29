using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class TimerControl : UserControl
    {
        DateTime time = DateTime.Now;

        public TimerControl()
        {
            InitializeComponent();
        }

private void timer1_Tick(object sender, EventArgs e)
{
    TimeSpan span = DateTime.Now - time;                //计算时间间隔
    this.lTimer.Text = String.Format("{0:00}小时{1:00}分{2:00}秒{3:000}毫秒", span.Hours, span.Minutes, span.Seconds, span.Milliseconds);
}

private void bStart_Click(object sender, EventArgs e)
{
    lBTime.Items.Clear();                               //清空列表
    time = DateTime.Now;                                //保存起始时间
    timer1.Start();                                     //开始计时
}

private void bTiming_Click(object sender, EventArgs e)
{
    //将当前时间间隔添加到计时列表中
    lBTime.Items.Insert(0, "[" + lBTime.Items.Count + "]" + lTimer.Text);
}

private void bStop_Click(object sender, EventArgs e)
{
    timer1.Stop();                                      //停止计时
}
    }
}
