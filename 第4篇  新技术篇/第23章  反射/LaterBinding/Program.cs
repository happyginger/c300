using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Reflection;

namespace TestMyAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "晚期绑定类型";

//加载指定路径上的程序集
Assembly myAssembly = Assembly.LoadFile("V:\\MyAssembly.dll");
//获取程序集中指定命名空间下的指定类型
Type myClassType = myAssembly.GetType("MyAssembly.MyClass");
//搜索类型中指定名称的方法
MethodInfo myClassMethod = myClassType.GetMethod("DoWork");
//调用程序集中指定命名空间下的指定类型的无参构造来创建该类型的实例
object myClass = myAssembly.CreateInstance("MyAssembly.MyClass");
//调用指定实例的指定方法
myClassMethod.Invoke(myClass, new object[]{"学习C#"});
//获取参数与数组中指定类型匹配的构造函数
ConstructorInfo myClassConstructor = myClassType.GetConstructor(new Type[] { typeof(string) });
//该用构造有参构造函数创建类的实例
object myClassAnother = myClassConstructor.Invoke(new object[]{"李四"});
//调用指定实例的指定方法
myClassMethod.Invoke(myClassAnother, new object[] { "学习C++" });


            Console.Read();
        }
    }
}
