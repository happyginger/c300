using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyInterface;

namespace MyAssembly
{
public class MyInterfaceClass : IMyInterface
{
    public MyInterfaceClass(string name)
    {
        this.name = name;
        Console.WriteLine("我的名字叫 {0}", name);
    }
    #region IMyInterface 成员
    string name;
    public string Name
    {
        get { return this.name; }
        set
        {
            if (this.name == value) return;
            Console.WriteLine("{0} 的名字改为 {1}", this.name, value);
            this.name = value; 
        }
    }
    public void DoWork(string something)
    {
        Console.WriteLine("我在 {0}", something);
    }
    #endregion
}
}
