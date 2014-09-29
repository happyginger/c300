using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "计算圆柱体和圆锥体表面积";

Circle cylinder = new Cylinder(100, 100);               //实例化圆柱体
Console.WriteLine("半径为100高为100的圆柱体表面积为{0:N2}", cylinder.Area());
Circle cone = new Cone(100, 100);                       //实例化圆锥体
Console.WriteLine("半径为100高为100的圆锥体表面积为{0:N2}", cone.Area());

            Console.ReadLine();
        }
    }
//圆形
class Circle
{
    protected int radius;                                         //半径
    public Circle(int radius) { this.radius = radius; }             //构造圆形
    public virtual double Area() { return Math.PI * radius * radius; }//计算面积

}
//圆柱体
class Cylinder : Circle
{
    int high;
    public Cylinder(int radius, int high) : base(radius)            //构造圆柱
    { 
        this.high = high; 
    }
    public override double Area()                               //重写计算面积函数
    {
        //计算圆柱体表面积=两个底面圆面积+侧面矩形面积
        return base.Area() * 2 + 2 * Math.PI * radius * high;
    }
}
//圆锥体
class Cone : Circle
{
    int high;
    public Cone(int radius, int high)
        : base(radius)                                              //构造圆柱
    {
        this.high = high;
    }
    public override double Area()                               //重写计算面积函数
    {
        double line = Math.Sqrt(radius * radius + high * high);//计算母线长
        //计算圆锥体表面积=底面圆面积+侧面扇形面积
        return base.Area() + Math.PI * radius * line;
    }
}
}
