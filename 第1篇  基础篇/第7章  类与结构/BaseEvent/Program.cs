using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "形状改变时重新计算圆形和矩形的面积";

Circle circle = new Circle(100);                        //创建圆形实例
circle.SharpChanged += new EventHandler<SharpChangedEventArgs>(Sharp_SharpChanged);
Console.WriteLine("半径为{0}的圆形面积为{1}", circle.Radius, circle.Area);
circle.Radius = 50;                                     //修改圆形的半径
Rectangle rectangle = new Rectangle(new Rectangle.Size(80, 60));//创建矩形实例
rectangle.SharpChanged += new EventHandler<SharpChangedEventArgs>(Sharp_SharpChanged);
Console.WriteLine("宽为{0}高为{1}的矩形面积为{2}", 
    rectangle.RectangleSize.Width, rectangle.RectangleSize.Height, rectangle.Area);
rectangle.RectangleSize = new Rectangle.Size(40, 50);   //修改矩形的大小

            Console.ReadLine();
        }

static void Sharp_SharpChanged(object sender, SharpChangedEventArgs e)
{
    if (sender is Circle) Console.WriteLine("形状变化后圆形面积为{0}", e.Area);
    else if (sender is Rectangle) Console.WriteLine("形状变化后矩形面积为{0}", e.Area);
}
    }
//形状改变事件参数类
class SharpChangedEventArgs : EventArgs
{
    public readonly double Area;                        //改变后的面积
    public SharpChangedEventArgs(double area) { Area = area; }
}
//形状
class Sharp
{
    public double Area { get; protected set; }          //形状的面积
    public event EventHandler<SharpChangedEventArgs> SharpChanged;//形状改变事件
    protected virtual void OnSharpChanged(SharpChangedEventArgs e)//形状改变虚函数
    {
        if (SharpChanged != null) SharpChanged(this, e);//触发形状改变事件
    }
}
//圆形
class Circle : Sharp
{
    int radius;
    public int Radius                                   //圆形半径
    {
        get { return radius; }
        set
        {
            if (radius != value)                        //如果半径发生变化
            {
                radius = value;
                Area = Math.PI * radius * radius;       //重新计算面积
                OnSharpChanged(new SharpChangedEventArgs(Area));
            }
        }
    }
    public Circle(int radius)
    {
        this.radius = radius;
        Area = Math.PI * radius * radius;               //计算圆形面积
    }
    protected override void OnSharpChanged(SharpChangedEventArgs e)//重载形状改变函数
    {
        base.OnSharpChanged(e);
    }
}
//矩形类
class Rectangle : Sharp
{
    //矩形大小结构体
    public struct Size
    {
        public int Width;                               //矩形宽
        public int Height;                              //矩形高
        public Size(int width, int height) { Width = width; Height = height; }

    }
    Size size;
    public Size RectangleSize                           //矩形大小
    {
        get { return size; }
        set
        {
            if (size.Width != value.Width || size.Height != value.Width)//如果大小发生变化
            {
                size = value;
                Area = size.Width * size.Height;        //重新计算矩形面积
                OnSharpChanged(new SharpChangedEventArgs(Area));
            }
        }
    }
    public Rectangle(Size size)
    {
        this.size = size;
        Area = size.Width * size.Height;                //计算矩形面积
    }
    protected override void OnSharpChanged(SharpChangedEventArgs e)//重载形状改变函数
    {
        base.OnSharpChanged(e);
    }
}
}
