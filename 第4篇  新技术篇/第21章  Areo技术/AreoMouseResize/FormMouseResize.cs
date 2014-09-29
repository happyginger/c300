using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AreoLibrary;

namespace AreoMouseResize
{
    public partial class FormMouseResize : Form
    {
        public FormMouseResize()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
e.Graphics.Clear(Color.FromArgb(50, Color.Lime));  //设置背景透明色
        }

        protected override void OnLoad(EventArgs e)
        {
Areo.AreoParams parameter = new Areo.AreoParams();
parameter.Flags = Areo.AreoParams.ENABLE;
parameter.Enable = true;
parameter.AreoRegion = IntPtr.Zero;
Areo.AreoWindow(this.Handle, parameter);                //将整个窗体背景设置成Areo效果
        }

const int WM_NCHITTEST = 0x84;                          //鼠标在窗体客户区时发送的消息
const int HTCLIENT = 0x1;                               //表示鼠标在窗口客户区的系统消息
const int HTLEFT = 0x0A;                                //鼠标在窗口的左边框
const int HTRIGHT = 0x0B;                               //鼠标在窗口的右边框
const int HTTOP = 0x0C;                                 //鼠标在窗口的上边框
const int HTTOPLEFT = 0x0D;                             //鼠标在窗口的左上边框
const int HTTOPRIGHT = 0x0E;                            //鼠标在窗口的右上边框
const int HTBOTTOM = 0x0F;                              //鼠标在窗口的下边框
const int HTBOTTOMLEFT = 0x10;                          //鼠标在窗口的左下边框
const int HTBOTTOMRIGHT = 0x11;                         //鼠标在窗口的右下边框
protected override void WndProc(ref Message m)
{
    base.WndProc(ref m);
    if (m.Msg == WM_NCHITTEST && HTCLIENT == m.Result.ToInt32())
    {
        //获取鼠标屏幕坐标
        Point point = new Point((int)m.LParam & 0xFFFF, (int)m.LParam >> 16 & 0xFFFF);
        point = PointToClient(point);                   //将鼠标屏幕坐标转换为窗体坐标
        Padding padding = new Padding(3);               //设置边框宽度
        if (this.WindowState == FormWindowState.Normal) //当窗体为常规状态时
        {
            if (point.X <= padding.Left)
            {
                if (point.Y <= padding.Top)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (point.Y >= ClientSize.Height - padding.Bottom)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else m.Result = (IntPtr)HTLEFT;
            }
            else if (point.X >= ClientSize.Width - padding.Right)
            {
                if (point.Y <= padding.Top)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (point.Y >= ClientSize.Height - padding.Bottom)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else m.Result = (IntPtr)HTRIGHT;
            }
            else if (point.Y <= padding.Top)
            {
                m.Result = (IntPtr)HTTOP;
            }
            else if (point.Y >= ClientSize.Height - padding.Bottom)
            {
                m.Result = (IntPtr)HTBOTTOM;
            }
        }
    }
}
    }
}
