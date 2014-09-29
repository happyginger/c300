using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "修改圆柱体的高度和底面半径";

Column column1 = new Column();                          //创建圆柱体1
Circle circle1 = new Circle();                          //创建圆形1
column1.Height = 20;                                    //设置圆柱体1的高度
column1.Circle = circle1;                               //将圆形1赋值给圆柱体1底面圆形
circle1.Radius = 10;                                    //设置圆形1半径
Console.WriteLine("圆柱体1高度:{0}", column1.Height);    //输出圆柱体1的高度
Console.WriteLine("圆柱体1底面半径:{0}", column1.Circle.Radius);//输出圆柱体1底面半径
Console.WriteLine("将圆柱体1赋值给圆柱体2");

Column column2 = column1;                               //将圆柱体1赋值给圆柱体2
Console.WriteLine("将圆形1半径改为30");
circle1.Radius = 30;                                    //修改圆形1的半径
Console.WriteLine("圆柱体1底面半径:{0}", column1.Circle.Radius);//输出圆柱体1底面半径
Console.WriteLine("圆柱体2底面半径:{0}", column2.Circle.Radius);//输出圆柱体2底面半径
Console.WriteLine("圆柱体1高度:{0}", column1.Height);    //输出圆柱体1的高度
Console.WriteLine("圆柱体2高度:{0}", column2.Height);    //输出圆柱体2的高度
Console.WriteLine("将圆柱体2高度改为40");
column2.Height = 40;                                    //修改圆柱体2的高度
Console.WriteLine("圆柱体1高度:{0}", column1.Height);    //输出圆柱体1的高度
Console.WriteLine("圆柱体2高度:{0}", column2.Height);    //输出圆柱体2的高度
            
            Console.Read();
        }

//定义一个圆柱体结构
struct Column
{
    public Circle Circle;                               //底面圆形
    public int Height;                                  //圆柱体高度
}
//定义一个圆形类
class Circle
{
    public int Radius;                                  //半径
}
    }
}
