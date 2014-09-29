using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AttributeReflect
{
    class Program
    {
        static void Main(string[] args)
        {
            //加载指定路径上的程序集
            Assembly myAssembly = Assembly.LoadFile("V:\\MyAssembly.dll");
            //Type myOwnClassType = myAssembly.GetType("MyAssembly.MyOwnClass");
            Type attributeType = myAssembly.GetType("MyAssembly.MyOwnAttribute");
            PropertyInfo nameInfo = attributeType.GetProperty("Name");

            foreach (var myOwnClassType in myAssembly.GetTypes())
            {
                object[] attributes = myOwnClassType.GetCustomAttributes(attributeType, true);
                if (attributes.Length > 0)
                {
                    Console.WriteLine("类型 {0} 具有特性 {1}", myOwnClassType.Name, attributeType.Name);
                    foreach (var myOwnClassAttribute in attributes)
                    {
                        Console.WriteLine("\t特性Name属性为：{0}", nameInfo.GetValue(myOwnClassAttribute, null));
                    }
                }
                else
                    Console.WriteLine("类型 {0} 不具有特性 {1}", myOwnClassType.Name, attributeType.Name);

                foreach (var method in myOwnClassType.GetMethods())
                {
                    object[] methodAttributes = method.GetCustomAttributes(attributeType, true);

                    if (methodAttributes.Length > 0)
                    {
                        Console.WriteLine("\t方法 {0} 具有特性 {1}", method.Name, attributeType.Name);

                        foreach (var myOwnClassAttribute in methodAttributes)
                        {
                            Console.WriteLine("\t\t特性Name属性为：{0}", nameInfo.GetValue(myOwnClassAttribute, null));
                        }
                    }
                }
            }

            Console.Read();
        }
    }
}
