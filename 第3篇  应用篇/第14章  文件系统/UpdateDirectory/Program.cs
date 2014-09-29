using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.AccessControl;

namespace UpdateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "开启文件夹只读属性";

string directoryName = "test";                          //文件夹名称
if (!Directory.Exists(directoryName))                   //判断文件夹是否存在
    Directory.CreateDirectory(directoryName);           //创建文件夹

//获取文件夹访问控制列表
DirectorySecurity dirSecurity = Directory.GetAccessControl(directoryName);
//将指定访问控制列表添加到当前文件夹
dirSecurity.AddAccessRule(new FileSystemAccessRule("Home", FileSystemRights.Read, InheritanceFlags.None, PropagationFlags.InheritOnly, AccessControlType.Allow));
Directory.SetAccessControl(directoryName, dirSecurity);     //设置文件夹访问控制列表


            Console.ReadLine();
        }
    }
}
