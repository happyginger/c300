using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseClip
{
    public partial class FormMouseClip : Form
    {
        public FormMouseClip()
        {
            InitializeComponent();
        }

protected override void OnMouseDown(MouseEventArgs e)
{
    Cursor.Clip = new Rectangle(this.Location, this.Size);//设置鼠标活动范围为当前窗体
}

protected override void OnMouseUp(MouseEventArgs e)
{
    Rectangle clip = new Rectangle();
    foreach (var item in Screen.AllScreens)             //计算包含所有屏幕的矩形
        clip = Rectangle.Union(clip, item.Bounds);
    Cursor.Clip = clip;                                 //设置鼠标活动范围为所有屏幕
}
    }
}
