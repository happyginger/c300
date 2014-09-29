using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormLocation
{
    public partial class FormLocation : Form
    {
Point location;                                         //记录窗体坐标
int angle;                                              //窗体抖动角度
int radius = 20;                                        //窗体抖动半径
        public FormLocation()
        {
            InitializeComponent();
        }

private void timer1_Tick(object sender, EventArgs e)
{
    int x = location.X + (int)(radius * Math.Sin(angle * Math.PI / 180));//计算水平坐标
    int y = location.Y + (int)(radius * Math.Cos(angle * Math.PI / 180));//计算垂直坐标
    angle = (angle + 45) % 360;                         //增加窗体抖动角度
    this.Location = new Point(x, y);                    //设置窗体当前坐标
    lLocation.Text = string.Format("窗体当前坐标：({0},{1})", this.Left, this.Top);
}

protected override void OnClick(EventArgs e)
{
    if (timer1.Enabled) this.Location = location;       //还原窗体原始坐标
    else
    {
        location = this.Location;                       //记录窗体原始坐标
        angle = 0;                                      //将窗体抖动角置零
    }
    timer1.Enabled =!timer1.Enabled;                    //启动或停止计时器
}
    }
}
