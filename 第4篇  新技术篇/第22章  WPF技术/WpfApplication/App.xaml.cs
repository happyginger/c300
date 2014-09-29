using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

using System.Diagnostics;

namespace WpfApplication
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
protected override void OnStartup(StartupEventArgs e)
{
    Debug.WriteLine("App Startup");
    base.OnStartup(e);
}
protected override void OnActivated(EventArgs e)
{
    Debug.WriteLine("App Activated");
    base.OnActivated(e);
}
protected override void OnDeactivated(EventArgs e)
{
    Debug.WriteLine("App Deactivated");
    base.OnDeactivated(e);
}
protected override void OnExit(ExitEventArgs e)
{
    Debug.WriteLine("App Exit");
    MessageBox.Show("WPF应用程序退出");
    base.OnExit(e);
}
    }
}
