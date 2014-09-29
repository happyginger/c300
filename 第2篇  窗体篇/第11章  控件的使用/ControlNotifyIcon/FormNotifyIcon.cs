using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ControlNotifyIcon
{
    public partial class FormNotifyIcon : Form
    {
List<Icon> Icons = new List<Icon>();                    //图标列表
int index = 0;                                          //图标索引

public FormNotifyIcon()
{
    for (int i = 0; i < 8; i++)
    {
        Bitmap icon = new Bitmap(64, 64);               //创建图标
        using (Graphics g = Graphics.FromImage(icon))   //获取图标绘图表面
        {
            g.Clear(Color.Transparent);                 //将图标背景设置成透明色
            g.SmoothingMode = SmoothingMode.AntiAlias;  //开启消除锯齿
            g.FillPie(Brushes.Lime, 0, 0, icon.Width, icon.Height, i * 45, 45);//绘制扇形
            g.DrawEllipse(new Pen(Color.Black,4f), 0, 0, icon.Width, icon.Height);//绘制圆形
            Icons.Add(Icon.FromHandle(icon.GetHicon()));//将创建好的图标添加到图标列表中
        }
        icon.Dispose();                                 //释放图标
    }
    InitializeComponent();
}

private void timer1_Tick(object sender, EventArgs e)
{
    index = ++index % 8;                                //增加图标索引
    notifyIcon1.Icon = Icons[index];                    //设置通知区图标为指定索引图标
}
    }
}
