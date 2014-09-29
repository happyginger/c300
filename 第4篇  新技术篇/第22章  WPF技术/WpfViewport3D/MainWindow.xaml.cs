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

namespace WpfViewport3D
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


Point pointMouseDown = new Point();                     //记录鼠标按下时的坐标
double angle = 0;                                       //记录鼠标按下时旋转的角度
bool isMouseDown = false;                               //标记鼠标是否按下
private void viewprot3D_MouseDown(object sender, MouseButtonEventArgs e)
{
    if (!isMouseDown)
    {
        pointMouseDown = e.GetPosition(this.viewprot3D);//设置鼠标按下时的坐标
        angle = axisAngle.Angle;
        isMouseDown = true;
    }
}
private void viewprot3D_MouseMove(object sender, MouseEventArgs e)
{
    if (isMouseDown)
    {
        Point pointMouseMove = e.GetPosition(this.viewprot3D);//获取鼠标当前坐标
        //设置旋转的角度
        axisAngle.Angle = (angle + 360 + pointMouseMove.X - pointMouseDown.X) % 360;
        Debug.WriteLine("水平旋转角" + axisAngle.Angle.ToString());
    }
}
private void viewprot3D_MouseUp(object sender, MouseButtonEventArgs e)
{
    if (isMouseDown)
    {
        isMouseDown = false;
        angle = 0;
        pointMouseDown = new Point();
    }
}
private void viewprot3D_MouseWheel(object sender, MouseWheelEventArgs e)
{
    if (e.Delta > 0)
    {
        if (camera.FieldOfView > 60) camera.FieldOfView -= 10;//缩小
    }
    else if (e.Delta < 0)
    {
        if (camera.FieldOfView < 200) camera.FieldOfView += 10;//放大
    }
}
    }
}
