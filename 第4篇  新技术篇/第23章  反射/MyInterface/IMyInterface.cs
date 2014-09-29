using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyInterface
{
public interface IMyInterface
{
    string Name { get; set; }                       //属性
    void DoWork(string something);                  //方法
}
}
