using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Security.Cryptography;

namespace WindowsManagementInstrumentation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 实例273  获取操作系统版本号
//Console.Title = "获取操作系统版本号";

//string strQuery = "Select * From Win32_OperatingSystem";//查询字串
//SelectQuery queryOS = new SelectQuery(strQuery);//实例化查询类
//ManagementObjectSearcher searcher = new ManagementObjectSearcher(queryOS);//调用指定查询
//foreach (var os in searcher.Get())
//{//遍历查询结果
//    Console.WriteLine("操作系统版本号为\t{0}", os["Version"]);
//    Console.WriteLine("操作系统标题为  \t{0}", os["Caption"]);
//    Console.WriteLine("操作系统序列号为\t{0}", os["SerialNumber"]);
//    Console.WriteLine("操作系统路径为  \t{0}", os["SystemDirectory"]);
//    Console.WriteLine("操作系统磁盘为  \t{0}", os["SystemDrive"]);
//}
            #endregion

            #region 实例274  获取逻辑磁盘信息
//Console.Title = "获取逻辑磁盘信息";

////实例化公共信息管理类，读取逻辑磁盘的信息
//ManagementClass classLogicalDisk = new ManagementClass("Win32_LogicalDisk");
////获取所有磁盘信息列表
//ManagementObjectCollection LogicalDisks = classLogicalDisk.GetInstances();
//foreach (var LogicalDisk in LogicalDisks)
//{//遍历所有磁盘驱动器
//    string DriveType = string.Empty;            //磁盘类型说明
//    switch (UInt32.Parse(LogicalDisk["DriveType"].ToString()))
//    {//选择磁盘类型说明
//        case 1: DriveType = "无根目录"; break;
//        case 2: DriveType = "移动磁盘"; break;
//        case 3: DriveType = "本地磁盘"; break;
//        case 4: DriveType = "网络驱动器"; break;
//        case 5: DriveType = "光盘"; break;
//        case 0:
//        default: DriveType = "未知类型"; break;
//    }
//    Console.WriteLine("磁盘盘符：{0}\t磁盘类型为：{1}\t磁盘名称：{2}\n", LogicalDisk["Name"], DriveType, LogicalDisk["VolumeName"]);
//}

            #endregion

            #region 实例275  获取磁盘驱动器空间
//            Console.Title = "获取磁盘空间";

////实例化公共信息管理类，读取磁盘驱动器
//ManagementClass classDiskDrive = new ManagementClass("Win32_DiskDrive");
////获取所有磁盘驱动器信息实例列表
//ManagementObjectCollection DiskDrives = classDiskDrive.GetInstances();
//foreach (ManagementObject DiskDrive in DiskDrives)
//{//遍历所有磁盘信息
//    //获取磁盘空间大小，以Byte为单位
//    UInt64 size = UInt64.Parse(DiskDrive["Size"].ToString());
//    //单位列表
//    string[] units = new string[]{"Bytes", "KBytes", "MBytes", "GBytes"};
//    int unitsLeve = 3;          //单位等级
//    while (unitsLeve >0 && size / (UInt64)Math.Pow(1024, unitsLeve) == 0)
//    {//计算单位等级
//        unitsLeve--;
//    }
//    size /= (UInt64)Math.Pow(1024, unitsLeve);//换算磁盘容量
//    Console.WriteLine("制造商的模型编号 : {0}\n磁盘驱动器大小 : {1} {2}\n磁盘序列号 : {3}\n\n", DiskDrive["Model"], size, units[unitsLeve], DiskDrive["SerialNumber"]);
//}
            #endregion

            #region 实例276  获取屏幕分辨率
//            Console.Title = "获取屏幕分辨率";

////实例化公共信息管理类，读取显示器信息
//ManagementClass classDesktopMonitor = new ManagementClass("Win32_DesktopMonitor");
////获取显示器信息实例列表
//ManagementObjectCollection DesktopMonitors = classDesktopMonitor.GetInstances();
//foreach (ManagementObject DesktopMonitor in DesktopMonitors)
//{//遍历所有显示器
//    Console.WriteLine("屏幕垂直分辨率为:\t{0}", DesktopMonitor["ScreenHeight"].ToString());
//    Console.WriteLine("屏幕水平分辨率为:\t{0}", DesktopMonitor["ScreenWidth"].ToString());
//    Console.WriteLine("屏幕垂直DPI:\t{0}", DesktopMonitor["PixelsPerYLogicalInch"].ToString());
//    Console.WriteLine("屏幕水平DPI:\t{0}", DesktopMonitor["PixelsPerXLogicalInch"].ToString());
//}
            #endregion

            #region 实例277  查询并修改本地IP地址
//            Console.Title = "获取本地机器IP地址";

//WriteLocalIP();
//UpdateLocalIP();
//Console.WriteLine("\n\n********   正在修改IP地址,请稍等...   ********\n\n");
//System.Threading.Thread.Sleep(3000);
//WriteLocalIP();

            #endregion

            #region 实例278  监视内存使用状态
//Console.Title = "监视内存使用状态";

////操作系统管理对象集合
//ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * From Win32_OperatingSystem");
//foreach (ManagementObject OperatingSystem in MOS.Get())
//{//遍历操作系统管理对象集合
//    Console.WriteLine(
//    "剩余物理内存量\t{0} MB\n剩余虚拟内存量\t{1} MB\n总虚拟内存量\t{2} MB\n总物理内存量\t{3} MB",
//    Math.Round(Int64.Parse(OperatingSystem["FreePhysicalMemory"].ToString()) / 1024.0),
//    Math.Round(Int64.Parse(OperatingSystem["FreeVirtualMemory"].ToString()) / 1024.0),
//    Math.Round(Int64.Parse(OperatingSystem["TotalVirtualMemorySize"].ToString()) / 1024.0),
//    Math.Round(Int64.Parse(OperatingSystem["TotalVisibleMemorySize"].ToString()) / 1024.0));
//}
            #endregion

            #region 实例279  监视CPU使用率
//            Console.Title = "监视CPU使用率";

////实例化公共信息管理类，读取CPU信息
//ManagementClass classProcessor = new ManagementClass("Win32_Processor");
////获取CPU信息实例列表
//ManagementObjectCollection Processors = classProcessor.GetInstances();
//foreach (ManagementObject Processor in Processors)
//{
//    Console.WriteLine("CPU名称为：\n{0}",Processor["Name"]);
//    Console.WriteLine("CPU占用率为：{0}",Processor["LoadPercentage"]);
//    Console.WriteLine("CPU的序列号为：{0}",Processor["ProcessorID"]);
//    Console.WriteLine("CPU地址宽度：{0}位", Processor["AddressWidth"]);
//    Console.WriteLine("CPU数据宽度：{0}位", Processor["DataWidth"]);
//}
            #endregion

            #region 实例280  利用硬件信息对程序加密
//            Console.Title = "利用硬件信息对程序加密";

//string fingerprint = GetFingerprint();//获取硬件指纹
//string registrationCode =GetRegistrationCode(fingerprint);//根据硬件指纹获取硬件注册码
//string input = string.Empty;    //用户输入信息
//bool RegistrationSuccess = false;//判断是否注册成功
//Console.WriteLine("请输入清册码：");
//do
//{
//    RegistrationSuccess = Console.ReadLine() == registrationCode;//判断输入注册码是否正确
//    if (RegistrationSuccess) Console.WriteLine("注册成功！");
//    else
//    {
//        Console.Clear();
//        Console.WriteLine("注册失败！");
//        Console.WriteLine("请重新输入清册码：");
//    }
//} while (!RegistrationSuccess);
//Console.WriteLine("硬件指纹：" + fingerprint);
//Console.WriteLine("软件注册码：" + registrationCode);
            #endregion

            Console.Read();
        }

/// <summary>获取机器指纹</summary>
/// <returns>机器指纹</returns>
static string GetFingerprint()
{
    string fingerprint = string.Empty;
    //获取CPU序列号
    ManagementObjectSearcher MOSProcessor = new ManagementObjectSearcher("Select ProcessorID From Win32_Processor");
    ManagementObjectCollection OperatingSystems = MOSProcessor.Get();
    foreach (var OperatingSystem in OperatingSystems)
    {//获取CPU序列号
        fingerprint += OperatingSystem["ProcessorID"].ToString();
    }
    //获取网络适配器MAC地址
    ManagementObjectSearcher MOSMACAddress = new ManagementObjectSearcher("Select * From Win32_NetworkAdapterConfiguration");
    ManagementObjectCollection MACAddresses = MOSMACAddress.Get();
    foreach (var MACAddress in MACAddresses)
    {//获取网卡MAC地址
        if (!(bool)MACAddress["IPEnabled"]) continue;
        fingerprint += MACAddress["MACAddress"].ToString().Replace(":","");
    }
    return fingerprint;
}

/// <summary>获取注册码</summary>
/// <param name="fingerprint">机器指纹</param>
/// <returns>注册码</returns>
static string GetRegistrationCode(string fingerprint)
{
    MD5 md5 = new MD5CryptoServiceProvider();//实例化MD5加密类
    byte[] byteFingerprint = System.Text.Encoding.Default.GetBytes(fingerprint);//将硬件指纹编码为一个字节序列 
    byte[] md5Fingerprint = md5.ComputeHash(byteFingerprint);//计算硬件指纹字节序列的哈希值 
    md5.Clear();//释放MD5资源
    string registrationCode = string.Empty;//MD5字节字串
    for (int i = 0; i < md5Fingerprint.Length - 1; i++)//拼接MD5字节字串
        registrationCode += md5Fingerprint[i].ToString("x").ToUpper().PadLeft(2, '0');
    return registrationCode;
} 

//修改本地IP地址
static void UpdateLocalIP()
{
    ManagementBaseObject MethodParameter = null;
    ManagementClass classNAC = 
        new ManagementClass("Win32_NetworkAdapterConfiguration");
    ManagementObjectCollection NACs = classNAC.GetInstances();
    foreach (ManagementObject NAC in NACs)
    {
        if (!(bool)NAC["IPEnabled"]) continue;//筛选TCP/ip协议绑定并且已启用的网络适配器
        //获取允许静态TCP/IP协议修改地址网络适配器参数
        MethodParameter = NAC.GetMethodParameters("EnableStatic");
        MethodParameter["IPAddress"] = new string[] { "192.168.1.100" };//IP地址参数
        MethodParameter["SubnetMask"] = new string[] { "255.255.255.0" };//子网掩码参数
        NAC.InvokeMethod("EnableStatic", MethodParameter, null);//修改IP地址和子网掩码
        break;
    } 
}
//显示本地IP地址
static void WriteLocalIP()
{
    //实例化公共信息管理类，读取网络适配器配置
    ManagementClass classNAC = new ManagementClass("Win32_NetworkAdapterConfiguration");
    //获取网络适配器实例列表
    ManagementObjectCollection NACs = classNAC.GetInstances();
    foreach (ManagementObject NAC in NACs)
    {//遍历所有网络适配器
        if (!(bool)NAC["IPEnabled"]) continue;  //筛选TCP/ip协议绑定并且已启用的网络适配器
        Console.WriteLine("网络适配器标题：\n{0}\n网络适配器服务名：{1}\n网络适配器MAC地址：{2}\n", 
            (string)NAC["Caption"], (string)NAC["ServiceName"], (string)NAC["MACAddress"]);
        string[] IPAddress = (string[])NAC["IPAddress"];    //获取IP地址
        string[] IPSubnet = (string[])NAC["IPSubnet"];       //获取子网掩码
        Console.WriteLine("IP地址为：{0}", IPAddress[0]);
        Console.WriteLine("子网掩码为：{0}",IPSubnet[0] );
    }
}
    }
}
