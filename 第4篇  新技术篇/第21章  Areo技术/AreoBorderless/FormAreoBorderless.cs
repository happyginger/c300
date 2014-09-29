using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AreoLibrary;

namespace AreoBorderless
{
    public partial class FormAreoBorderless : Form
    {
        public FormAreoBorderless()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
if (cBAreo.CheckState != CheckState.Unchecked)
    e.Graphics.Clear(Color.FromArgb(50,Color.Yellow));  //设置背景透明色
        }

        private void cBAreo_CheckStateChanged(object sender, EventArgs e)
        {
switch (cBAreo.CheckState)
{
    case CheckState.Checked:
        cBAreo.Text = "边框扩展Areo效果";
        this.FormBorderStyle = FormBorderStyle.None;    //将窗体设置成无边型
        Areo.AreoFrame(this.Handle, new Areo.Margin(-1, 0, 0, 0));//将边框扩展至整个窗体
        break;
    case CheckState.Indeterminate:
        cBAreo.Text = "窗体背景Areo效果";
        Areo.AreoFrame(this.Handle, new Areo.Margin(20, 20, 20, 20));//将边框四边向内扩展20像素
        this.FormBorderStyle = FormBorderStyle.None;
        Areo.AreoParams parameter = new Areo.AreoParams();
        parameter.Flags = Areo.AreoParams.ENABLE;
        parameter.Enable = true;
        parameter.AreoRegion = IntPtr.Zero;
        Areo.AreoWindow(this.Handle, parameter);        //将整个窗体背景设置成Areo效果
        break;
    case CheckState.Unchecked:
        this.FormBorderStyle = FormBorderStyle.Sizable;
        ClearAreoWindow();                              //关闭背景Areo效果
        cBAreo.Text = "窗体背景Areo效果";
        break;
    default:
        break;
}
this.Invalidate();
        }

void ClearAreoWindow()
{
    Areo.AreoParams parameter = new Areo.AreoParams();
    parameter.Flags = Areo.AreoParams.ENABLE | Areo.AreoParams.REGION;
    parameter.Enable = false;                           //关闭Areo效果
    parameter.AreoRegion = IntPtr.Zero;
    Areo.AreoWindow(this.Handle, parameter);
}

    }
}
