using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "动物园给不同动物喂食";

Animal panda = new Panda("竹子");                         //创建熊猫实例
Animal tiger = new Tiger("牛肉");                         //创建老虎实例


            Console.ReadLine();
        }
    }
//动物类
class Animal
{
    string name;                                        //动物名称
    string food;                                        //动物所吃的食物
    public Animal(string name, string food)             //构造函数
    {
        this.name = name;
        this.food = food;
    }
    protected void Feed()                               //喂食
    {
        Console.WriteLine("饲养员给{0}喂{1}", name, food);
    }
}
//熊猫类
class Panda : Animal
{
    public Panda(string food)
        : base("熊猫", food)                            //调用基类构造函数
    {
        Feed();                                         //给熊猫喂食
    }
}
//老虎
class Tiger : Animal
{
    public Tiger(string food)
        : base("老虎", food)                            //调用基类构造函数
    {
        Feed();                                         //给老虎喂食
    }
}
    
}
