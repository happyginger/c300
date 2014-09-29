using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDIDrawShape
{
    public partial class FormDrawShape : Form
    {
        public FormDrawShape()
        {
            InitializeComponent();
        }

protected override void OnPaint(PaintEventArgs e)
{
    base.OnPaint(e);
    Graphics G = e.Graphics;                    //获取绘图对象
    Point point1 = new Point(10, 10);           //实例化点1
    Point point2 = new Point(30, 10);           //实例化点2
    G.DrawLine(Pens.Black, point1, point2);     //绘制水平直线
    point1.Offset(0, 10);                       //点1向下移动10个像素
    point2.Offset(0, 20);                       //点2向下移动20个像素
    G.DrawLine(Pens.Black, point1, point2);     //绘制斜直线
    Point point3 = new Point(50, 10);           //实例化点3
    Size size1 = new Size(10, 10);              //实例化大小1
    Rectangle rect1 = new Rectangle(point3, size1);//实例化矩形
    G.DrawRectangle(Pens.Black, rect1);         //绘制矩形边框
    G.SmoothingMode = SmoothingMode.AntiAlias;  //开启抗锯齿功能
    point1.Offset(0, 10);                       //点1向下移动10个像素
    point2.Offset(0, 10);                       //点1向下移动10个像素
    G.DrawLine(Pens.Black, point1, point2);     //绘制斜直线
    rect1.Offset(0, 50);                        //矩形向下移动50个像素
    rect1.Inflate(20, 20);                      //放大矩形
    Color color1 = Color.FromArgb(100, Color.Yellow);//获取ARGB颜色
    G.DrawRectangle(Pens.Black, rect1);         //绘制矩形
    rect1.Offset(50, 0);                        //矩形向右移动50个像素
    Color color2 = Color.FromArgb(255, 0, 255); //获取RGB颜色
    G.DrawPie(Pens.Black, rect1, 45, 270);      //绘制扇形
    rect1.Offset(50, 0);                        //矩形向右移动50个像素
    rect1.Inflate(10, 0);                       //矩形向左右方向各扩大10个像素
    G.DrawEllipse(Pens.Black, rect1);           //绘制椭圆
    rect1.Offset(0, 100);                        //矩形向下移动50个像素
    SolidBrush brush1 = new SolidBrush(Color.Lime);//创建画刷
    G.FillEllipse(brush1, rect1);               //填充椭圆
    rect1.Inflate(-10, 0);                       //矩形向左右方向各缩小10个像素
    rect1.Offset(-30, 0);                       //矩形向左移动50个像素
    SolidBrush brush2 = new SolidBrush(Color.FromArgb(100, 0, 0, 255));
    G.FillPie(brush2, rect1, 45, 270);          //填充扇形
    rect1.Offset(-30, 0);                       //矩形向左移动50个像素
    SolidBrush brush3 = new SolidBrush(Color.FromArgb(100, 255, 0, 0));
    G.FillRectangle(brush3, rect1);             //填充矩形
}
    }
}
