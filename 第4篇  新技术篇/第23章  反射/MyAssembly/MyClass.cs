using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAssembly
{
    //定义一个类
    public class MyClass
    {
        string name;
        public string Name { get { return name; } }     //姓名
        //无参构造函数
        public MyClass()
        {
            this.name = "张三";
            Console.WriteLine(this.name + "创建成功！");
        }
        //有参构造函数
        public MyClass(string name)
        {
            this.name = name;
            Console.WriteLine(this.name + "创建成功！");
        }
        //定义一个带参函数
        public void DoWork(string work)
        {
            Console.WriteLine(this.name + work);
        }
    }
}
