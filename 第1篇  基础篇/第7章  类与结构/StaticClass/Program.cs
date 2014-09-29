using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "统计工厂生产汽车的数量";

Car[] cars1 = CarFactory.Manufacture();
Console.WriteLine("工厂第一季度生产汽车{0}辆", cars1.Length);
Car[] cars2 = CarFactory.Manufacture();
Console.WriteLine("工厂第二季度生产汽车{0}辆", cars2.Length);
Car[] cars3 = CarFactory.Manufacture();
Console.WriteLine("工厂第三季度生产汽车{0}辆", cars3.Length);
Car[] cars4 = CarFactory.Manufacture();
Console.WriteLine("工厂第四季度生产汽车{0}辆", cars4.Length);
Console.WriteLine("工厂全年生产汽车{0}辆", Car.Number);

            Console.ReadLine();
        }
    }
//汽车工厂静态类
static class CarFactory
{
    static Random R = new Random();                     //随机数发生器
    //生产一定数量的汽车
    public static Car[] Manufacture()
    {
        Car[] cars = new Car[R.Next(100,300)];          //创建随机长度汽车数组
        for (int i = 0; i < cars.Length; i++) cars[i] = new Car();//生产汽车
        return cars;
    }
}
//汽车类
class Car
{
    public static int Number { get; private set; }      //统计生产汽车的数量
    public Car() { Number++; }                          //构造函数
}
}
