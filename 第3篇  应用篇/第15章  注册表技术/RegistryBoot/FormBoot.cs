using System.Windows.Forms;
using Microsoft.Win32;

namespace Registry_Boot
{
    public partial class FormBoot : Form
    {
        public FormBoot()
        {
            InitializeComponent();
        }
/// <summary>
/// 重载窗体构造函数
/// </summary>
/// <param name="bootInfo">窗体自动启动信息</param>
public FormBoot(string bootInfo)
{
    InitializeComponent();
    //将启动信息赋值给标签控件
    lboot.Text = bootInfo;
}

private void btnBoot_Click(object sender, System.EventArgs e)
{
    //获取注册表HKEY_LOCAL_MACHINE基项
    RegistryKey localMachine = Registry.LocalMachine;
    //获取注册表中程序启动项所在的项
    RegistryKey run = localMachine.OpenSubKey(
    @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
    //判断启动项是否存在
    if (run == null)
    {
        MessageBox.Show("启动项不存在！");
    }
    else
    {
        //获取程序在开机启动项中的键值
        object registryBootValue = run.GetValue("RegistryBoot");
        if (registryBootValue != null)
        {//程序已经添加到开机启动项中
            MessageBox.Show("该程序已经添加到启动项！");
        }
        else
        {
            //获取程序当前路径
            string fullPath = System.IO.Directory.GetCurrentDirectory();
            //将程序名和程序全路径及启动参数分别写入启动项的键位和键值中
            //键值类型设置为字符串型。
            run.SetValue("RegistryBoot", fullPath + "\\Registry_Boot.exe \"开机已自动启动\"", 
                RegistryValueKind.String);
        }
    }
    //关闭HKEY_LOCAL_MACHINE基项
    localMachine.Close();
}

private void btnForbidHomepage_Click(object sender, System.EventArgs e)
{
    //获取注册表HKEY_CURRENT_USER基项
    RegistryKey currentUser = Registry.CurrentUser;
    //打开注册表中的控制面版项
    RegistryKey controlPanel = currentUser.OpenSubKey(
        @"Software\Policies\Microsoft\Control Panel", true);
    if (controlPanel == null)
    {//控制面板项不存在
        //创建控制面板项
        controlPanel = currentUser.CreateSubKey(
            @"Software\Policies\Microsoft\Control Panel");
    }
    //在控制面板项下设置锁定主页键的值为1
    controlPanel.SetValue("Settings", 1, RegistryValueKind.DWord);
    controlPanel.SetValue("Links", 1, RegistryValueKind.DWord);
    controlPanel.SetValue("SecAddSites", 1, RegistryValueKind.DWord);
    //关闭HKEY_CURRENT_USER基项
    currentUser.Close();
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
    system.SetValue("DisableTaskmgr", 0, RegistryValueKind.DWord);
    //关闭HKEY_CURRENT_USER基项
    currentUser.Close();
}

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

            //设置资源管理器项中禁用任管理器隐藏磁盘项的值为0x08000000
            //0x08000000表示隐藏D盘，不隐藏任何盘该值设为0x00000000，隐藏所有磁盘该值设为0xffffffff
            explorer.SetValue("NoDrives", 0x08000000, RegistryValueKind.DWord);

            //关闭HKEY_CURRENT_USER基项
            currentUser.Close();

            /*
                不隐藏任何盘      00000000 
                隐藏A盘           01000000 
                隐藏B盘           02000000 
                隐藏C盘           04000000 
                隐藏D盘           08000000 
                隐藏E盘           10000000 
                隐藏F盘           20000000 
                隐藏G盘           40000000 
                隐藏H盘           80000000   
                隐藏I盘           00010000 
                隐藏J盘           00020000 
                隐藏K盘           00040000 
                隐藏L盘           00080000 
                ....... 
                依次类推 
                隐藏Z盘           00000002 
                隐藏全部驱动器    FFFFFFFF 
            */
        }

        private void btnForbidRegistry_Click(object sender, System.EventArgs e)
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
            //设置系统项中禁用注册表工具键的值为1
            system.SetValue("Disableregistrytools", 0, RegistryValueKind.DWord);
            //关闭HKEY_CURRENT_USER基项
            currentUser.Close();
        }
    }
}
