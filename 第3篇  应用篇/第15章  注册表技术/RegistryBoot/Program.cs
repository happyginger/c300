using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Registry_Boot
{
    static class Program
    {
/// <summary>
/// 应用程序的主入口点。
/// </summary>
/// <param name="Args">启动参数</param>
[STAThread]
static void Main(params string[] Args)
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    if (Args.Length > 0)
        //将启动信息传入启动窗体
        Application.Run(new FormBoot(Args[0]));
    else
        Application.Run(new FormBoot());
}
    }
}
