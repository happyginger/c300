using System;                                           //引用系统命名空间
using System.Windows.Forms;                             //引用窗体命名空间
namespace WindowsFormsApplication                       //定义窗体应用程序命名空间
{
    static class Program                                //定义Program类
    {
        [STAThread]                                     //为Main函数添加的特性
        static void Main()                              //应用程序的入口点。
        {
            Application.EnableVisualStyles();           //启用应用程序的可视样式
            //使窗体控件支持TextRenderer类来呈现文本
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());               //显示窗体
        }
    }
}
