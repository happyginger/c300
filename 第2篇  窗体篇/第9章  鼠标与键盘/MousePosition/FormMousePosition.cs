using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MousePosition
{
    public partial class FormMousePosition : Form
    {
        public FormMousePosition()
        {
            InitializeComponent();
        }

protected override void OnMouseMove(MouseEventArgs e)
{
    Point clientMouse = e.Location;                     //获取鼠标窗体客户区坐标
    Point screenMouse = PointToScreen(clientMouse);     //获取鼠标屏幕坐标
    this.Text = string.Format("鼠标窗体坐标：({0},{1}) 鼠标屏幕坐标：({2},{3})",
        clientMouse.X, clientMouse.Y, screenMouse.X, screenMouse.Y);
}
    }
}
