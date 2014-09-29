using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComponentErrorProvider
{
    public partial class FormErrorProvider : Form
    {
        public FormErrorProvider()
        {
            InitializeComponent();
        }

private void tBUser_Validating(object sender, CancelEventArgs e)
{
    if (tBUser.Text != "admin")                         //添加错误提示
        ePError.SetError(tBUser, "用户名错误！");
    else ePError.SetError(tBUser, string.Empty);        //取消错误提示
}
private void tBPassword_Validating(object sender, CancelEventArgs e)
{
    if (tBPassword.Text != "123456")                    //添加错误提示
        ePError.SetError(tBPassword, "密码错误！");
    else ePError.SetError(tBPassword, string.Empty);    //取消错误提示
}
    }
}
