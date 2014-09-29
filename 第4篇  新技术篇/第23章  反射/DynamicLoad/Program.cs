using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DynamicLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "动态加载程序集";

//加载指定路径上的程序集
Assembly myAssembly = Assembly.LoadFile("V:\\MyAssembly.dll");
Console.WriteLine("动态加载程序集 {0}", myAssembly.FullName);
//遍历程序集中的所有类型
foreach (Type t in myAssembly.GetTypes())
{
    Console.WriteLine("获取程序集 {0} 中的类型为： {1} 类型名称为 {2}", myAssembly.FullName, t, t.Name);
    Console.WriteLine("获取类型 {0} 中的方法：", t);
    //遍历类型中的所有方法
    foreach (var method in t.GetMethods())
    {
        Console.WriteLine("\t方法名称为 {0}", method.Name);
        //遍历方法中的所有参数
        foreach (var parameter in method.GetParameters())
            Console.WriteLine("\t\t参数名为：{0} 参数类型为：{1}", parameter.Name, parameter.ParameterType);
    }
    Console.WriteLine("获取类型 {0} 中的成员：", t);
    //遍历类型中的所有属性
    foreach (var member in t.GetProperties()) Console.WriteLine("\t成员名称为 {0}", member.Name);
}

            Console.Read();
        }
    }
}
