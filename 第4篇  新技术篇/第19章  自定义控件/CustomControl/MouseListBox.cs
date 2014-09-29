using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CustomControl
{
    public partial class MouseListBox : Control
    {
int topItems = 0;                                       //列表集体顶部坐标
bool isMouseDown = false;                               //鼠标是否按下
int yMouseDown = 0;                                     //鼠标按下时的Y坐标
List<object> items = new List<object>();                //对象列表
Bitmap imageItem = new Bitmap(100, 40);                 //列表成员背景图片
StringFormat formatItem = new StringFormat();           //列表成员格式

int heightItem = 20;
[Category("列表控件")]
[DefaultValue(20)]
[Description("列表成员的高度")]
public int HeightItem
{
    get { return heightItem; }
    set { heightItem = value; }
}



        public MouseListBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            InitializeComponent();

Graphics G = Graphics.FromImage(imageItem);
LinearGradientBrush brush = new LinearGradientBrush(    //创建线性渐变画刷
    new Point(0, 0), new Point(0, 20), Color.Orange, Color.Lime);
brush.WrapMode = WrapMode.TileFlipXY;
G.FillRectangle(brush, 0, 0, 100, 40);                  //填充图像
brush.Dispose();
G.Dispose();
formatItem.Alignment = StringAlignment.Center;          //水平居中
formatItem.LineAlignment = StringAlignment.Center;      //垂直居中
        }

public void AddItem(object item)
{
    this.items.Add(item);                               //添加列表成员
    this.Invalidate();
}

protected override void OnMouseDown(MouseEventArgs e)
{
    base.OnMouseDown(e);
    this.isMouseDown = true;                            //记录鼠标按下
    yMouseDown = e.Y;
}
protected override void OnMouseUp(MouseEventArgs e)
{
    base.OnMouseUp(e);
    this.isMouseDown = false;                           //记录鼠标抬起
}
protected override void OnMouseMove(MouseEventArgs e)
{
    base.OnMouseMove(e);
    if (isMouseDown)
    {
        if (topItems + e.Y - yMouseDown <= 0
            && topItems + e.Y - yMouseDown + this.items.Count * heightItem >= this.Height)
        {
            topItems += e.Y - yMouseDown;               //改变列表顶部坐标
        }
        yMouseDown = e.Y;
        this.Invalidate();
    }
}

        //protected override void OnMouseWheel(MouseEventArgs e)
        //{
        //    base.OnMouseWheel(e);
        //    if (this.items.Count * heightItem < this.Height) return;
        //    if (e.Delta > 0)
        //    {
        //        if (topItems + heightItem <= 0)
        //        {
        //            topItems += heightItem;
        //            this.Invalidate();
        //        }
        //        else if (topItems != 0)
        //        {
        //            topItems = 0;
        //            this.Invalidate();
        //        }
        //    }
        //    else if (e.Delta < 0)
        //    {
        //        if (topItems - heightItem + this.items.Count * heightItem >= this.Height)
        //        {
        //            topItems -= heightItem;
        //            this.Invalidate();
        //        }
        //        else if (topItems != this.Height - this.items.Count * heightItem)
        //        {
        //            topItems = this.Height - this.items.Count * heightItem;
        //            this.Invalidate();
        //        }
        //    }
        //}

protected override void OnPaint(PaintEventArgs pe)
{
    base.OnPaint(pe);
Graphics G = pe.Graphics;
SolidBrush brush = new SolidBrush(this.ForeColor);
Pen pen = new Pen(this.ForeColor);
Rectangle rect = new Rectangle(0, topItems, this.ClientRectangle.Width - 1, heightItem - 1);
for (int i = 0; i < this.items.Count; i++)
{
    G.DrawImage(imageItem, rect);                   //绘制成员背景图片
    G.DrawString(items[i].ToString(), this.Font, brush, rect, formatItem);//绘制成员
    rect.Offset(0, heightItem); 
}
brush.Dispose();
pen.Dispose();

}
    }
}
