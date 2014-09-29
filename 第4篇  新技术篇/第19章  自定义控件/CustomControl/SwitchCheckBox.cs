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
    [DefaultEvent("CheckedChanged")]
    public class SwitchCheckBox : Control
    {
[Description("当 Checked 属性更改时发生。")]
public event EventHandler CheckedChanged;

bool isChecked = false;
[Category("外观")]
[Description("指定控件是否为开启状态")]
[DefaultValue(false)]
public bool Checked
{
    get { return isChecked; }
    set
    {
        if (isChecked != value)
        {
            isChecked = value;
            this.Invalidate();
        }
    }
}
string openedString = "已开启";
[Category("外观")]
[Description("指定控件开启时的文本")]
[DefaultValue("已开启")]
public string OpenedString
{
    get { return openedString; }
    set
    {
        openedString = value;
        this.Invalidate();
    }
}
string closedString = "已关闭";
[Category("外观")]
[Description("指定控件关闭时的文本")]
[DefaultValue("已关闭")]
public string ClosedString
{
    get { return closedString; }
    set
    {
        closedString = value;
        this.Invalidate();
    }
}

        public SwitchCheckBox()
        {
            this.MinimumSize = new Size(20, 30);

        }

protected override void OnClick(EventArgs e)
{
    base.OnClick(e);
    this.isChecked = !this.isChecked;                   //改变选择状态
    this.Invalidate();
    if (CheckedChanged != null) CheckedChanged(this, null);//调用事件
}

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

Graphics G = e.Graphics;
LinearGradientBrush brush = new LinearGradientBrush(    //线性画刷
    new Point(0, 0), new Point(0, this.Height), Color.Gray, Color.White);
G.FillRectangle(brush, this.ClientRectangle);           //填充背景
Color colorBrush = Color.Red;
Rectangle rectCheck = new Rectangle(0, 0, this.Width * 2 / 3, this.Height);
string checkedText = this.closedString;
if (this.isChecked)                                     //如果为选中状态
{
    colorBrush = Color.Lime;
    rectCheck = new Rectangle(this.Width - this.Width * 2 / 3, 0, this.Width * 2 / 3, this.Height);
    checkedText = this.openedString;
}
LinearGradientBrush brush2 = new LinearGradientBrush(   //线性画刷
new Point(0, 0), new Point(0, this.Height), colorBrush, Color.White);
G.FillRectangle(brush2, rectCheck);                     //绘制滑块
StringFormat format = new StringFormat();
format.Alignment = StringAlignment.Center;
format.LineAlignment = StringAlignment.Center;
//绘制选择状态对应的文本
G.DrawString(checkedText, this.Font, Brushes.Black, rectCheck, format);

brush.Dispose();
brush2.Dispose();
format.Dispose();
        }
    }
}
