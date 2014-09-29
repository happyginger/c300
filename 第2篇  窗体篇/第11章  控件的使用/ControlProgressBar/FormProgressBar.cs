using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlProgressBar
{
    public partial class FormProgressBar : Form
    {
        public FormProgressBar()
        {
            InitializeComponent();
        }

protected override void OnClick(EventArgs e)
{
    timer1.Enabled = !timer1.Enabled;                   //开关计时器
    if (timer1.Enabled)
    {
        pBProgress.Value = pBProgress.Minimum;          //设置进度条初始进度
    }
}

private void timer1_Tick(object sender, EventArgs e)
{
    if (pBProgress.Value == pBProgress.Maximum) 
        timer1.Stop();                                  //执行完成时停止计时器
    else
    {
        pBProgress.Value++;                             //设置进度条进度值
        lProgress.Text = string.Format("进度：{0:0.0%}",
            (float)(pBProgress.Value - pBProgress.Minimum) / (pBProgress.Maximum - pBProgress.Minimum));             //显示进度的具体值
    }
}
    }
}
