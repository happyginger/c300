using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyAssembly
{
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
    AllowMultiple = true, Inherited = true)]
public sealed class MyOwnAttribute : System.Attribute
{
    string name;
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public MyOwnAttribute()
    {
        this.name = "基类";
    }
    public MyOwnAttribute(string name)
    {
        this.name = name;
    }
}

[MyOwn()]
public class MyOwnBase
{
    [MyOwn("基类方法")]
    public void DoWork() { }
}
[MyOwn(Name = "子类")]
public class MyOwnClass : MyOwnBase
{
    [MyOwn("子类方法")]
    public new void DoWork() { }
}
public class MyOwnOtherClass { }

}
