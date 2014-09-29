using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WpfApplication
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
public MainWindow()
{
    InitializeComponent();
    this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
}
void  MainWindow_Loaded(object sender, RoutedEventArgs e)
{
    Debug.WriteLine("Window Loaded");
}
protected override void OnInitialized(EventArgs e)
{
    Debug.WriteLine("Window Startup");
    base.OnInitialized(e);
}
protected override void OnActivated(EventArgs e)
{
    Debug.WriteLine("Window Activated");
    base.OnActivated(e);
}
protected override void OnDeactivated(EventArgs e)
{
    Debug.WriteLine("Window Deactivated");
    base.OnDeactivated(e);
}
protected override void OnContentRendered(EventArgs e)
{
    Debug.WriteLine("Window Content Rendered");
    base.OnContentRendered(e);
}
protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
{
    if (MessageBox.Show("您确定要退出吗？", "退出", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel) == MessageBoxResult.Cancel) 
        e.Cancel = true;                                //设置是否取消窗体关闭
    else
    {
        Debug.WriteLine("Window Closing");
    }
    base.OnClosing(e);
}
protected override void OnClosed(EventArgs e)
{
    Debug.WriteLine("Window Closed");
    base.OnClosed(e);
}
    }
}
