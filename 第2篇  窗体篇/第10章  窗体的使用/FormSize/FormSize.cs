using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormSize
{
    public partial class FormSize : Form
    {
        public FormSize()
        {
            InitializeComponent();
        }

private void timer1_Tick(object sender, EventArgs e)
{
    if (this.Height >= 300) timer1.Stop();              //停止计时器
    this.Width += 4;                                      //增加窗体宽度
    this.Height += 4;                                   //增加窗体高度
}

protected override void OnClick(EventArgs e)
{
    timer1.Start();                                     //启动计时器
}
    }
}
