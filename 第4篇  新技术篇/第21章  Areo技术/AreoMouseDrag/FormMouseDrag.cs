using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AreoLibrary;

namespace AreoMouseDrag
{
    public partial class FormMouseDrag : Form
    {
        public FormMouseDrag()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromArgb(50, Color.Yellow));  //设置背景透明色
        }

        protected override void OnLoad(EventArgs e)
        {
Areo.AreoParams parameter = new Areo.AreoParams();
parameter.Flags = Areo.AreoParams.ENABLE;
parameter.Enable = true;
parameter.AreoRegion = IntPtr.Zero;
Areo.AreoWindow(this.Handle, parameter);                //将整个窗体背景设置成Areo效果
        }
const int WM_NCHITTEST = 0x84;//鼠标在窗体客户区（除了标题栏和边框以外的部分）时发送的消息
const int HTCLIENT = 0x1;//表示鼠标在窗口客户区的系统消息
const int HTCAPTION = 0x0002;//表示鼠标在窗口标题栏时的系统信息
protected override void WndProc(ref Message m)
{
    base.WndProc(ref m);
    if (m.Msg == WM_NCHITTEST && HTCLIENT == m.Result.ToInt32())
    {
        m.Result = new IntPtr(HTCAPTION);
    }
}
    }
}
