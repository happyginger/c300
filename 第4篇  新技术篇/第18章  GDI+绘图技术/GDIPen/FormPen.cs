using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDIPen
{
    public partial class FormPen : Form
    {
        public FormPen()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
Graphics G = e.Graphics;                    //获取绘图对象
Rectangle rect1 = new Rectangle(170, 20, 100, 20);//实例化矩形1
Point point1 = new Point(20, 20);           //实例化点1
Point point2 = new Point(120, 20);          //实例化点2
Pen pen1 = new Pen(Color.Red);              //默认线宽为1的黑色画笔
Pen pen2 = new Pen(Color.Black, 5f);        //实例化线宽为5的黑色画笔
G.DrawLine(pen2, point1, point2);           //用钢笔2绘制线宽为5的黑色线段
G.DrawLine(pen1, point1, point2);           //用钢笔1绘制线宽为1的红色线段
G.DrawRectangle(pen2, rect1);               //用钢笔2绘制线宽为5的黑色矩形
G.DrawRectangle(pen1, rect1);               //用钢笔1绘制线宽为1的红色矩形
point1.Offset(0, 10);
point2.Offset(0, 10);
rect1.Offset(0, 30);
pen2.Alignment = PenAlignment.Inset;        //设置绘制的矩形在指定矩形框内
G.DrawRectangle(pen2, rect1);               //用钢笔2绘制线宽为5的黑色矩形
G.DrawRectangle(pen1, rect1);               //用钢笔1绘制线宽为1的红色矩形

point1.Offset(0, 10);
point2.Offset(0, 10);
pen2.DashStyle = DashStyle.Dash;            //设置虚线样式为划线段
G.DrawLine(pen2, point1, point2);
point1.Offset(0, 10);
point2.Offset(0, 10);
pen2.DashStyle = DashStyle.DashDot;         //设置虚线样式为划线点
G.DrawLine(pen2, point1, point2);
point1.Offset(0, 10);
point2.Offset(0, 10);
rect1.Offset(0, 30);
//设置虚线样式为10像素实现2像素空格5像素实绩1像素空格
pen1.DashPattern = new float[] { 10, 2, 5, 1 };
G.DrawLine(pen1, point1, point2);
G.DrawRectangle(pen1, rect1);

point1.Offset(0, 10);
point2.Offset(0, 10);
pen2.DashStyle = DashStyle.Solid;
pen2.StartCap = LineCap.ArrowAnchor;        //设置线段起点样式为箭头锚头帽
pen2.EndCap = LineCap.DiamondAnchor;        //设置线段终点样式为菱形锚头帽
G.DrawLine(pen2, point1, point2);
point1.Offset(0, 10);
point2.Offset(0, 10);
pen2.StartCap = LineCap.Flat;               //设置线段起点样式为平线帽
pen2.EndCap = LineCap.Round;                //设置线段终点样式为圆线帽
G.DrawLine(pen2, point1, point2);
point1.Offset(0, 10);
point2.Offset(0, 10);
pen2.StartCap = LineCap.RoundAnchor;        //设置线段起点样式为圆锚头帽
pen2.EndCap = LineCap.Square;               //设置线段终点样式为方线帽
G.DrawLine(pen2, point1, point2);
point1.Offset(0, 10);
point2.Offset(0, 10);
pen2.StartCap = LineCap.SquareAnchor;       //设置线段起点样式为方锚头帽
pen2.EndCap = LineCap.Triangle;             //设置线段终点样式为三角线帽
G.DrawLine(pen2, point1, point2);

Pen pen3 = new Pen(Color.Black, 10f);
rect1.Offset(0, 50);
pen3.LineJoin = LineJoin.Bevel;             //设置矩形转角为斜角连接
G.DrawRectangle(pen3, rect1);
rect1.Offset(0, 50);
pen3.LineJoin = LineJoin.Round;             //设置矩形转角为圆弧
G.DrawRectangle(pen3, rect1);

pen1.Dispose();                             //释放钢笔对象
pen2.Dispose();                             //释放钢笔对象
pen3.Dispose();                             //释放钢笔对象
        }
    }
}
