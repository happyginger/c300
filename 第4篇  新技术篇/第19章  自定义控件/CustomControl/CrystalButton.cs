using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomControl
{
    public class CrystalButton : UserControl
    {
GraphicsPath pathOut = new GraphicsPath();              //外框绘图路径
GraphicsPath pathIn = new GraphicsPath();               //内框绘图路径
StringFormat format = new StringFormat();               //按钮文本格式

        public CrystalButton()
            : base()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.UserPaint, true);

this.BackColor = Color.Transparent;                     //设置按钮背景透明
format.Alignment = StringAlignment.Center;              //按钮文字水平居中
format.LineAlignment = StringAlignment.Center;          //按钮文字垂直居中
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

if (this.Width >= this.Height)                          //为水平模式时
{
    pathOut.Reset();                                    //清空外框绘图路径
    pathIn.Reset();                                     //清空内框绘图路径
    Rectangle rectLeft = new Rectangle(0, 0, Height, Height);//外框左半圆弧所在矩形
    Rectangle rectRight = new Rectangle(Width - Height, 0, Height, Height);//外框右半圆弧所在矩形
    pathOut.AddArc(rectLeft, 90, 180);                  //向路径中添加外框左半圆弧
    pathOut.AddArc(rectRight, 270, 180);                //向路径中添加外框右半圆弧
    pathOut.CloseFigure();                              //闭合外框绘图路径
    rectLeft.Inflate(-5, -5);                           //缩小外框左半圆弧所在矩形
    rectRight.Inflate(-5, -5);                          //缩小外框右半圆弧所在矩形
    pathIn.AddArc(rectLeft, 90, 180);                   //向路径中添加内框左半圆弧
    pathIn.AddArc(rectRight, 270, 180);                 //向路径中添加内框右半圆弧
    pathIn.CloseFigure();                               //闭合内框绘图路径
    format.FormatFlags &= ~StringFormatFlags.DirectionVertical;//取消垂直绘制模式
}
else                                                    //为垂直模式时
{
    pathOut.Reset();                                    //清空外框绘图路径
    pathIn.Reset();                                     //清空内框绘图路径
    Rectangle rectUp = new Rectangle(0, 0, Width, Width);//外框上半圆弧所在矩形
    Rectangle rectDown = new Rectangle(0, Height - Width, Width, Width);//外框下半圆弧所在矩形
    pathOut.AddArc(rectUp, 180, 180);                   //向路径中添加外框上半圆弧
    pathOut.AddArc(rectDown, 0, 180);                   //向路径中添加外框下半圆弧
    pathOut.CloseFigure();                              //闭合外框绘图路径
    rectUp.Inflate(-5, -5);                             //缩小外框上半圆弧所在矩形
    rectDown.Inflate(-5, -5);                           //缩小外框下半圆弧所在矩形
    pathIn.AddArc(rectUp, 180, 180);                    //向路径中添加内框上半圆弧
    pathIn.AddArc(rectDown, 0, 180);                    //向路径中添加内框下半圆弧
    pathIn.CloseFigure();                               //闭合内框绘图路径
    format.FormatFlags = StringFormatFlags.DirectionVertical;//设置垂直绘制模式
}
this.Invalidate();                                      //使整个控件重绘
        }
string buttonText;
public string ButtonText                                //按钮文本
{
    get { return buttonText; }
    set
    {
        buttonText = value;
        this.Invalidate();
    }
}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics G = e.Graphics;
G.SmoothingMode = SmoothingMode.AntiAlias;              //消除锯齿
LinearGradientBrush brushOut = new LinearGradientBrush( //创建线性渐变画刷
    new Point(0, 0), new Point(20, 20), Color.Gray, Color.White);
brushOut.WrapMode = WrapMode.TileFlipXY;
G.FillPath(brushOut, pathOut);                          //填充外框路径
PathGradientBrush brushIn = new PathGradientBrush(pathIn);//创建路径画刷
brushIn.CenterColor = Color.White;
brushIn.CenterPoint = new PointF(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
brushIn.SurroundColors = new Color[] { Color.Orange };
G.FillPath(brushIn, pathIn);                            //填充内框路径
G.DrawString(buttonText, Font, Brushes.Black, ClientRectangle, format);//绘制字符串
brushOut.Dispose();
brushIn.Dispose();
        }
    }
}
