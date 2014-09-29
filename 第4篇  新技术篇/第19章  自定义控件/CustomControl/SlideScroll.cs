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
    public class SlideScroll : Control
    {
int max = 100;
[Category("滑动滚动")]
[DefaultValue(100)]
public int Maximum
{
    get { return max; }
    set
    {
        max = value;
        if (min > max) min = max;               //当最小值大于最大值时另最小值等于最大值
        if (this.value > max) this.value = max; //当当前值大于最大值时另当前值等于最大值
        this.Invalidate();
    }
}
int min = 0;
[Category("滑动滚动")]
[DefaultValue(0)]
public int Minimum
{
    get { return min; }
    set
    {
        min = value;
        if (max < min) max = min;               //当最大值小于最小值时另最大值等于最小值
        if (this.value < min) this.value = min; //当当前值小于最小值时另当前值等于最小值
        this.Invalidate();
    }
}
int value = 0;
[Category("滑动滚动")]
[DefaultValue(0)]
public int Value
{
    get { return value; }
    set
    {
        if (value > max) this.value = max;      //当设置值大于最大值时另当前值等于最大值
        else if (value < min) this.value = min; //当设置值小于最小值时别当前值等于最小值
        else this.value = value;                //当前值等于设置值
        this.Invalidate();
    }
}

Timer timer = new Timer();                      //计时器
int targetValue;                                //目标值
        public SlideScroll()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint
            | ControlStyles.OptimizedDoubleBuffer
            | ControlStyles.UserPaint, true);

this.MinimumSize = new Size(10, 20);            //限制控件最小尺寸
timer.Interval = 10;
timer.Tick += new EventHandler(timer_Tick);
        }

void timer_Tick(object sender, EventArgs e)
{
    if (targetValue > this.value)               //如果目标值大于当前值
        this.value += (targetValue - this.value + 9) / 10;//当前值向目标值移动
    else if (targetValue < this.value)          //如果目标值小于当前值
        this.value -= (this.value - targetValue + 9) / 10;//当前值向目标值移动
    else timer.Stop();                          //如果目标值等于当前值则停止移动
    this.Invalidate();
}
protected override void OnMouseDown(MouseEventArgs e)
{
    base.OnMouseDown(e);
    if (this.Width <= 10 || this.max == this.min) return;
    if (e.X < 5) targetValue = this.min;        //设置目标值为最小值
    else if (e.X + 5 > this.Width) targetValue = max;//设置目标值为最大值
    else targetValue = (e.X - 5) * (this.max - this.min) / (this.Width - 10);//计算目标值
    timer.Start();                              //当前值开始向目标值移动
}

protected override void OnPaint(PaintEventArgs e)
{
    base.OnPaint(e);
    Graphics G = e.Graphics;
    LinearGradientBrush brush = new LinearGradientBrush(//线性画刷
        new Point(0, 0), new Point(0, this.Height), Color.Orange, Color.White);
    G.FillRectangle(brush, this.ClientRectangle);//填充背景
    LinearGradientBrush brush2 = new LinearGradientBrush(//线性画刷
        new Point(0, 0), new Point(0, this.Height), Color.Green, Color.White);
    int x = 0;
    if (this.max > this.min)
        x = this.value * (this.Width - 10) / (this.max - this.min);
    G.FillRectangle(brush2, new Rectangle(x, 0, 10, this.Height));//填充滑块

    StringFormat format = new StringFormat();
    format.Alignment = StringAlignment.Center;
    format.LineAlignment = StringAlignment.Center;
    //绘制当前值
    G.DrawString(value.ToString(), this.Font, Brushes.Black, this.ClientRectangle, format);

    brush.Dispose();
    brush2.Dispose();
    format.Dispose();
}
    }
}
