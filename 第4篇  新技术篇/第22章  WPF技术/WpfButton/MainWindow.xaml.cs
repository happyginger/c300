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
using System.Windows.Controls.Primitives;

namespace WpfButton
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

private void Button_Click(object sender, RoutedEventArgs e)
{
    MessageBox.Show((sender as Button).Content.ToString());
}
private void RepeatButton_Click(object sender, RoutedEventArgs e)
{
    RepeatButton repeatButton = sender as RepeatButton;
    repeatButton.Width++;
    repeatButton.Height++;
}
    }
}
