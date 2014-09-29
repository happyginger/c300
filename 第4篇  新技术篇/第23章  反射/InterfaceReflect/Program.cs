using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MyInterface;

namespace InterfaceReflect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "利用接口代替反射";

//加载指定路径上的程序集
Assembly myAssembly = Assembly.LoadFile("V:\\MyAssembly.dll");
//获取程序集中指定命名空间下的指定类型
Type myClassType = myAssembly.GetType("MyAssembly.MyInterfaceClass");
//获取参数与数组中指定类型匹配的构造函数
ConstructorInfo myClassConstructor = myClassType.GetConstructor(new Type[] { typeof(string) });
//该用构造有参构造函数创建类的实例
IMyInterface myInterfaceClass = myClassConstructor.Invoke(new object[] { "张三" }) as IMyInterface;
if (myInterfaceClass != null)
{
    myInterfaceClass.DoWork("学习C#");
    myInterfaceClass.Name = "李四";
}

            Console.Read();
        }
    }
}
