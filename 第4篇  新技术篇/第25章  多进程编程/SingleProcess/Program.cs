using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace SingleProcess
{
    static class Program
    {
[DllImport("User32.dll")]
private static extern bool SetForegroundWindow(IntPtr hWnd);
[DllImport("User32.dll")]
private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
bool createdNew;    //是否是第一次开启程序
Mutex mutex = new Mutex(false, "Single", out createdNew);//实例化一个进程互斥变量，标记名称Single
if (!createdNew)                                        //如果多次开启了进程
{
    Process currentProcess = Process.GetCurrentProcess();//获取当前进程
    foreach (Process process in Process.GetProcessesByName(currentProcess.ProcessName))
    {
        //通过进程ID和程序路径来获取一个已经开启的进程
        if ((process.Id != currentProcess.Id) &&
            (Assembly.GetExecutingAssembly().Location == process.MainModule.FileName))
        {
            //获取已经开启的进程的主窗体句柄
            IntPtr mainFormHandle = process.MainWindowHandle;
            if (mainFormHandle != IntPtr.Zero)
            {
                ShowWindowAsync(mainFormHandle, 1);         //显示已经开启的进程窗口
                SetForegroundWindow(mainFormHandle);        //将已经开启的进程窗口移动到窗体的最前端
            }
        }
    }
    MessageBox.Show("进程已经开启");
    return;
}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSingleProcess());
        }
    }
}
