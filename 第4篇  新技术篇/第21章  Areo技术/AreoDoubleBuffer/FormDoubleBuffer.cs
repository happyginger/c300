using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AreoLibrary;

namespace AreoDoubleBuffer
{
    public partial class FormDoubleBuffer : Form
    {
        public FormDoubleBuffer()
        {
SetStyle(ControlStyles.AllPaintingInWmPaint
        | ControlStyles.OptimizedDoubleBuffer           //开启窗体双缓存绘图
        | ControlStyles.UserPaint, true);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
e.Graphics.Clear(Color.FromArgb(alpha, Color.Fuchsia)); //设置窗体透明色
        }

protected override void OnLoad(EventArgs e)
{
Areo.AreoParams parameter = new Areo.AreoParams();
parameter.Flags = Areo.AreoParams.ENABLE;
parameter.Enable = true;
parameter.AreoRegion = IntPtr.Zero;
Areo.AreoWindow(this.Handle, parameter);                //将整个窗体背景设置成Areo效果
}

bool isMouseOver = false;                               //鼠标是否在窗体上
int alpha = 0;                                          //窗体背景颜色不透明度
protected override void OnMouseEnter(EventArgs e)
{
    isMouseOver = true;
    tAreo.Start();
}
protected override void OnMouseLeave(EventArgs e)
{
    isMouseOver = false;
    tAreo.Start();
}
private void tAreo_Tick(object sender, EventArgs e)
{
    if (isMouseOver)
    {
        if (alpha < 100) alpha += 10;                   //不透明度增加
        else tAreo.Stop();
    }
    else
    {
        if (alpha > 0) alpha -= 10;                     //透明度增加
        else tAreo.Stop();
    }
    this.Invalidate();
}
    }
}
