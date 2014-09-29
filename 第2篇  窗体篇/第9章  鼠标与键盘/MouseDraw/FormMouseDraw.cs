using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MouseDraw
{
    public partial class FormMouseDraw : Form
    {
bool isMouseDown = false;                               //鼠标是否按下
Point pointMouse = new Point();                         //鼠标坐标

        public FormMouseDraw()
        {
            InitializeComponent();
        }

protected override void OnMouseDown(MouseEventArgs e)
{
    pointMouse = e.Location;                            //鼠标坐标
    isMouseDown = true;                                 //标记鼠标已经按下
}
protected override void OnMouseMove(MouseEventArgs e)
{
    if (isMouseDown)
    {
        using (Graphics G = this.CreateGraphics())      //获取窗体绘制表面
        {
            G.SmoothingMode = SmoothingMode.AntiAlias;  //开启消除锯齿
            using (Pen pen = new Pen(Color.Black, 3f))  //创建宽度为3像素的黑色画笔
            {
                G.DrawLine(pen, pointMouse, e.Location);//绘制线段
                pointMouse = e.Location;                //重新设置鼠标坐标
            }
        }
    }
}
protected override void OnMouseUp(MouseEventArgs e)
{
    isMouseDown = false;                                //标记鼠标未按下
}

    }
}
