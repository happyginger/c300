using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace CallUser32
{
    public partial class FormUser32 : Form
    {
//设置窗体的位置和大小
[DllImport("user32.dll", EntryPoint = "MoveWindow")]
public static extern bool MoveWindow(IntPtr hWnd, int x, int y, int width, int height, bool repaint);

//从当前线程中的窗口释放鼠标捕获，并恢复通常的鼠标输入处理。
[DllImport("user32.dll")]
public static extern bool ReleaseCapture();
//将指定的消息发送到一个或多个窗口。
[DllImport("user32.dll")]
public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
public const int WM_SYSCOMMAND = 0x0112;
public const int SC_MOVE = 0xF010;
public const int HTCAPTION = 0x0002;

        public FormUser32()
        {
            InitializeComponent();
        }

protected override void OnLoad(EventArgs e)
{
    lLeft.DataBindings.Add("Text", this, "Left");       //窗体左边距与lLeft绑定
    lTop.DataBindings.Add("Text", this, "Top");         //窗体上边距与lTop绑定
    lWidth.DataBindings.Add("Text", this, "Width");     //窗体宽度与lWidth绑定
    lHeight.DataBindings.Add("Text", this, "Height");   //窗体高度与lHeight绑定
    base.OnLoad(e);
}

protected override void OnLocationChanged(EventArgs e)
{
    lLeft.DataBindings["Text"].ReadValue();             //更新窗体左边距信息
    lTop.DataBindings["Text"].ReadValue();              //更新窗体上边距信息
    lWidth.DataBindings["Text"].ReadValue();            //更新窗体宽度信息
    lHeight.DataBindings["Text"].ReadValue();           //更新窗体高度信息
    base.OnLocationChanged(e);
}

protected override void OnClick(EventArgs e)
{
    base.OnClick(e);
Rectangle rect = Screen.AllScreens[0].Bounds;
//调用user32.dll中的MoveWindow方法，设置当前窗体的位置和大小
MoveWindow(this.Handle, rect.Width / 4, rect.Height / 4, rect.Width / 2, rect.Height / 2, true);
}

protected override void OnMouseDown(MouseEventArgs e)
{
    base.OnMouseDown(e);
    ReleaseCapture();   //调用user32.dll中的ReleaseCapture方法，释放鼠标捕获
    //调用user32.dll中的SendMessage方法，向当前窗口发送移动窗体消息
    SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
}
    }
}
