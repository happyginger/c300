using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace HideHardDisk
{
    public partial class FormbtnHardDisk : Form
    {
public FormbtnHardDisk()
{
    InitializeComponent();
    //遍历字符‘A’到‘Z’
    for (int i = 0; i < 26; i++)
    {
        //磁盘编号的字节索引
        int byteIndex = i / 8;
        //磁盘编号的位索引
        int bitIndex = i % 8;
        //产生磁盘编号
        int diskNumber = 0x00000001 << byteIndex * 8 << bitIndex;
        //将磁盘盘符与磁盘所对应十六进制编号作为选择添加到磁盘列表中
        cBDisk.Items.Add(Convert.ToChar('A' + i) + "盘  0x" + diskNumber.ToString("X8"), false);
    }
}

        /*
                不隐藏任何盘      00000000 
                隐藏A盘           00000001 
                隐藏B盘           00000002 
                隐藏C盘           00000004 
                隐藏D盘           00000008 
                隐藏E盘           00000010 
                隐藏F盘           00000020 
                隐藏G盘           00000040 
                隐藏H盘           00000080   
                隐藏I盘           00000100 
                隐藏J盘           00000200 
                隐藏K盘           00000400 
                隐藏L盘           00000800 
                ....... 
                依次类推 
                隐藏Z盘           02000000 
                隐藏全部驱动器    FFFFFFFF 
            */
private void btnHideHardDisk_Click(object sender, System.EventArgs e)
{
    //获取注册表HKEY_CURRENT_USER基项
    RegistryKey currentUser = Registry.CurrentUser;

    //打开注册表中的资源管理器项
    RegistryKey explorer = currentUser.OpenSubKey(
        @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true);

    if (explorer == null)
    {//资源管理器项不存在
        //创建资源管理器项
        explorer = currentUser.CreateSubKey(
            @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer");
    }

    //设置资源管理器项中隐藏磁盘键的键值设置为隐藏磁盘的编号和
    explorer.SetValue("NoDrives", GetDistNumber(), RegistryValueKind.DWord);

    //关闭HKEY_CURRENT_USER基项
    currentUser.Close();
}

int GetDistNumber()
{
    //硬盘编号初始值
    int diskNumber = 0x00000000;
    //遍历需要隐藏的磁盘
    foreach (string chechedDisk in cBDisk.CheckedItems)
    {
        //获取隐藏磁盘编号
        string strNumber= chechedDisk.ToString().Split(new string[]{"0x"}, StringSplitOptions.RemoveEmptyEntries)[1];
        //将需要隐藏的磁盘编号进行累加
        diskNumber += Convert.ToInt32(strNumber, 16);
    }
    //返回最终需要隐藏的磁盘编号之和
    return diskNumber;
}
    }
}
