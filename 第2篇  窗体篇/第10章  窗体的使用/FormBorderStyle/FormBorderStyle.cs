using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormBorderStyle
{
    public partial class FormBorderStyle : Form
    {
bool isMouseDown = false;                               //标记鼠标是否按下
Point pointMouse = new Point();                         //记录鼠标按下时的坐标
        public FormBorderStyle()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//将窗体设置为无边框
}

protected override void OnMouseDown(MouseEventArgs e)
{
    pointMouse = e.Location;                            //记录鼠标按下时的坐标
    isMouseDown = true;                                 //记录鼠标已按下
}

protected override void OnMouseMove(MouseEventArgs e)
{
    if (isMouseDown)
    {
        Point location = this.PointToScreen(e.Location);//记录鼠标屏幕坐标
        location.Offset(-pointMouse.X, -pointMouse.Y);  //将鼠标屏幕坐标转换成窗体坐标
        this.Location = location;                       //设置窗体坐标
        lLocation.Text = string.Format("窗体当前坐标：({0},{1})\n鼠标当前坐标：({2},{3})"
            , this.Left, this.Top, pointMouse.X, pointMouse.Y);
    }
}

protected override void OnMouseUp(MouseEventArgs e)
{
    isMouseDown = false;                                 //记录鼠标未按下
}
    }
}
