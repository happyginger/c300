using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardCtrlEnter
{
    public partial class FormCtrlEnter : Form
    {
        public FormCtrlEnter()
        {
            InitializeComponent();
        }

protected override void OnKeyDown(KeyEventArgs e)
{
    if (e.KeyData == (Keys.Control | Keys.Enter))       //判断键盘按键类型
    {
        if (this.WindowState == FormWindowState.Maximized)//判断窗体当前状态
        {
            this.WindowState = FormWindowState.Normal;  //将窗体还原
        }
        else if (this.WindowState == FormWindowState.Normal)
        {
            MessageBox.Show("窗体即将最大化！");
            this.WindowState = FormWindowState.Maximized;//将窗体最大化
        }
    }
}
    }
}
