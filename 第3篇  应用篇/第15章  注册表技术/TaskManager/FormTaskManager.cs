using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TaskManager
{
    public partial class FormTaskManager : Form
    {
        public FormTaskManager()
        {
            InitializeComponent();
        }

private void btnForbidTaskManager_Click(object sender, System.EventArgs e)
{
    //获取注册表HKEY_CURRENT_USER基项
    RegistryKey currentUser = Registry.CurrentUser;
    //打开注册表中的系统项
    RegistryKey system = currentUser.OpenSubKey(
        @"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
    if (system == null)
    {//系统项不存在
        //创建系统项
        system = currentUser.CreateSubKey(
            @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
    }
    //设置系统项中禁用任管理器键的值为1
    system.SetValue("DisableTaskmgr", 1, RegistryValueKind.DWord);
    //关闭HKEY_CURRENT_USER基项
    currentUser.Close();
}


    }
}
