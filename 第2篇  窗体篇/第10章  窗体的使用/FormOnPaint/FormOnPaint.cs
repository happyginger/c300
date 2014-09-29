using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace FormOnPaint
{
    public partial class FormOnPaint : Form
    {
Point pointGradient = new Point();                      //记录渐变画刷起始点
        public FormOnPaint()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

protected override void OnPaint(PaintEventArgs e)
{
    LinearGradientBrush brush = new LinearGradientBrush(//创建线性渐变画刷
        pointGradient, new Point(20, 20),              	//渐变起始点和终止点
        Color.Yellow, Color.Blue);                      //激变起始颜色和终止颜色
    e.Graphics.FillRectangle(brush, 0, 0, Width, Height);//绘制窗体背景
}

private void timer1_Tick(object sender, EventArgs e)
{
    pointGradient.X = ++pointGradient.X % 20;           //增加渐变点横坐标
    pointGradient.Y = ++pointGradient.Y % 20;           //增加渐变点纵坐标
    this.Invalidate();                                  //使窗体重绘
}
    }
}
