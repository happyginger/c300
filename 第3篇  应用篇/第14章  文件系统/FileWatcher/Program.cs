using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "监控文件";
Console.WriteLine("正在监控目录{0}下的txt文件...", Directory.GetCurrentDirectory());
FileSystemWatcher watcher = new FileSystemWatcher(Directory.GetCurrentDirectory(), "*.txt");
watcher.Created += new FileSystemEventHandler(watcher_Created);//添加文件创建事件
watcher.Changed += new FileSystemEventHandler(watcher_Changed);//添加文件修改事件
watcher.Deleted += new FileSystemEventHandler(watcher_Deleted);//添加文件删除事件
watcher.EnableRaisingEvents = true;                     //启动侦听
            Console.ReadLine(); 
        }

static void watcher_Created(object sender, FileSystemEventArgs e)
{
    Console.WriteLine("文件{0}被创建！", e.Name);
}
static void watcher_Changed(object sender, FileSystemEventArgs e)
{
    Console.WriteLine("文件{0}被修改！", e.Name);
}
static void watcher_Deleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine("文件{0}被删除！", e.Name);
}
    }
}
