using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace CustomControl
{
    public class BitmapButton : Button
    {
        //protected override void OnClick(EventArgs e)
        //{
        //    base.OnClick(e);

        //    Bitmap image = new Bitmap(100, 40);
        //    Graphics G = Graphics.FromImage(image);
        //    LinearGradientBrush brush = new LinearGradientBrush(
        //        new Point(0, 0), new Point(0, 20),
        //        Color.FromArgb(128, Color.Lime),
        //        Color.FromArgb(128, Color.Yellow));
        //    brush.WrapMode = WrapMode.TileFlipX;
        //    G.FillRectangle(brush, this.ClientRectangle);
        //    image.Save("Down.png", ImageFormat.Png);

        //}

Image imageOver = null;
[Category("位图按钮")]
[Description("当鼠标移动到按钮上面时按钮显示的图像。")]
public Image ImageOver
{
    get { return imageOver; }
    set { imageOver = value; }
}
Image imageDown = null;
[Category("位图按钮")]
[Description("当鼠标在按钮按下时按钮显示的图像。")]
public Image ImageDown
{
    get { return imageDown; }
    set { imageDown = value; }
}
Image imageLeave = null;
[Category("位图按钮")]
[Description("当鼠标离开钮按时按钮显示的图像。")]
public Image ImageLeave
{
    get { return imageLeave; }
    set
    { 
        imageLeave = value;
        this.BackgroundImage = value;
    }
}

public BitmapButton() : base()
{
    this.BackgroundImageLayout = ImageLayout.Stretch;   //设置背景图像在按钮上拉伸显示
}

protected override void OnMouseEnter(EventArgs e)
{
    this.BackgroundImage = this.imageOver;
    base.OnMouseEnter(e);
}
protected override void OnMouseDown(MouseEventArgs mevent)
{
    this.BackgroundImage = this.imageDown;
    base.OnMouseDown(mevent);
}
protected override void OnMouseUp(MouseEventArgs mevent)
{
    this.BackgroundImage = this.imageOver;
    base.OnMouseUp(mevent);
}
protected override void OnMouseLeave(EventArgs e)
{
    this.BackgroundImage = this.imageLeave;
    base.OnMouseLeave(e);
}
    }
}
