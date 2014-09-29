using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Regist
{
    public partial class FormRegist : Form
    {
public FormRegist()
{
    InitializeComponent();
    //获取注册表HKEY_CURRENT_USER基项
    RegistryKey currentUser = Registry.CurrentUser;
    //打开注册表中的系统项
    RegistryKey system = currentUser.OpenSubKey(
        @"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
    if (system == null)
        //如果系统不存在该项，则设置复选按钮的状态为假
        cBForbidRegistry.Checked = false;
    else
    {
        //获取禁用注册表项的键值
        object value = system.GetValue("Disableregistrytools");
        //根据键值是否存在，键值为0或是1来设置复选按钮状态
        if (value != null && (int)value == 1)
            //设置复选按钮的状态为真
            cBForbidRegistry.Checked = true;
        else
            //设置复选按钮的状态为假
            cBForbidRegistry.Checked = false;
        system.Close();     //关闭系统项
    }
    currentUser.Close();    //关闭当前用户基项
}

private void cBForbidRegistry_CheckedChanged(object sender, EventArgs e)
{
    //根据用户选择设置注册表项的键值，0为允许访问，1为禁止访问
    int value = cBForbidRegistry.Checked ? 1 : 0;
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
    //设置系统项中禁用注册表工具键的键值
    system.SetValue("Disableregistrytools", value, RegistryValueKind.DWord);
    system.Close();         //关闭系统项
    currentUser.Close();    //关闭当前用户基项
}
    }
}
