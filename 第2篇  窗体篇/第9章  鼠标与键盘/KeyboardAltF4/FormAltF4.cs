using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyboardAltF4
{
    public partial class FormAltF4 : Form
    {
        public FormAltF4()
        {
            InitializeComponent();
        }

protected override void OnKeyDown(KeyEventArgs e)
{
    if (e.KeyData == (Keys.Alt | Keys.F4))
    {
        MessageBox.Show("Alt+F4组合键已被屏蔽，无法关闭当前窗体！");
        e.Handled = true;                               //将Alt+F4标记为已处理状态
    }
}
    }
}
