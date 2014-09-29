using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "利用枚举型描述动物类型";

Animal animal = Animal.Cat;                             //为枚举型变量赋值
switch (animal)                                         //判断枚举型变量的值
{
    case Animal.Dog:                                    //如果为Dog则输出“狗”
        Console.WriteLine("狗");
        break;
    case Animal.Cat:                                    //如果为Cat则输出“猫”
        Console.WriteLine("猫");
        break;
    case Animal.Mouse:                                  //如果为Mouse则输出“鼠”
        Console.WriteLine("鼠");
        break;
    default:
        break;
}
            Console.Read();
        }

//定义动物枚举类型
enum Animal : byte
{
    Dog = 0,                                            //狗
    Cat = 1,                                            //猫
    Mouse = 2                                           //鼠
}
    }
}
