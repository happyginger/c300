using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "计算球、圆柱和圆锥的体积";

Ball ball = new Ball(10);                               //实例化球体
Console.WriteLine("半径为{0}的球体体积为{1:0.00}", ball.Radius, ball.Volume);
Circle cylinder = new Cylinder(10, 10);                 //实例化圆柱体
Console.WriteLine("半径为{0}高度为{1}的圆柱体体积为{2:F3}", cylinder.Radius, 10, cylinder.Volume);
Circle cone = new Cone(10, 10);                         //实例化圆锥体
Console.WriteLine("半径为{0}高度为{1}的圆柱体体积为{2:#,#.#}", cone.Radius, 10, cone.Volume);

            Console.ReadLine();
        }
    }

//圆
class Circle
{
    protected int radius;
    public int Radius { get { return radius; } }
    public double Volume { get; protected set; }
}
//球
class Ball : Circle
{
    public Ball(int radius)
    {
        this.radius = radius;
        Volume = 4 * Math.PI * radius * radius * radius / 3;//计算球体体积
    }
}
//圆柱
class Cylinder : Circle
{
    public Cylinder(int radius, int high)
    {
        this.radius = radius;
        Volume = Math.PI * radius * radius * high;      //计算圆柱体积
    }
}
//圆锥
class Cone : Circle
{
    public Cone(int radius, int high)
    {
        this.radius = radius;
        Volume = Math.PI * radius * radius * high / 3;  //计算圆锥体积
    }
}
}
