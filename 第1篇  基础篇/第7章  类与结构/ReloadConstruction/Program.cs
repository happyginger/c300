using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReloadConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "自定义日期类型";

Date now = new Date(2012, 10, 15);                      //实例化日期类型
Console.WriteLine("昨天日期为：" + now);
now = new Date(DateTime.Now);                           //实例化日期类型
Console.WriteLine("当前日期为：" + now);

            Console.ReadLine();
        }
    }
//日期类型
class Date
{
    public readonly int Year;                           //年
    public readonly int Month;                          //月
    public readonly int Day;                            //日
    public Date(int year, int month, int day)           //传递年、月、日三个参数的构造函数
    {
        this.Year = year;                               //为年赋值
        this.Month = month;                             //为月赋值
        this.Day = day;                                 //为日赋值
    }
    public Date(DateTime datetime)                      //传递DateTime类型参数的构造函数
    {
        this.Year = datetime.Year;                      //为年赋值
        this.Month = datetime.Month;                    //为月赋值
        this.Day = datetime.Day;                        //为日赋值
    }
    //重写object的ToString方法，将日期转换为字符串
    public override string ToString()
    {
        return string.Format("{0}年{1}月{2}日",this.Year, this.Month, this.Day);
    }
}
}
