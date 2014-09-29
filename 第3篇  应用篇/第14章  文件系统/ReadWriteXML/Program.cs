using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace ReadWriteXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "读写XML文档";

XmlDocument xmlDoc = new XmlDocument();
xmlDoc.Load("300 classic examples.xml");                //加载Xml文档

XmlNode section1 = xmlDoc.SelectSingleNode("基础篇");
XmlNode chapter1 = section1.SelectSingleNode("开发环境");
XmlElement example1 = (XmlElement)chapter1.SelectSingleNode("创建控制台应用程序");
example1.SetAttribute("ID", "3");

XmlNode chapter3 = xmlDoc.CreateElement("程序流程");        //创建二级节点
section1.AppendChild(chapter3);                         //在根元素下添加二级节点
XmlElement example19 = xmlDoc.CreateElement("模拟超市商品打折");
example19.SetAttribute("ID", "19");                     //为三级元素设置ID属性
example19.InnerText = "介绍了C#中if条件判断语句的使用方法";
chapter3.AppendChild(example19);                        //在二级节点下添加三级元素
XmlElement example20 = xmlDoc.CreateElement("判断字符串各字符类型");
example20.SetAttribute("ID", "20");                     //为三级元素设置ID属性
example20.InnerText = "介绍了C#中if-else条件判断语句的使用方法";
chapter3.AppendChild(example20);                        //在二级节点下添加三级元素

xmlDoc.Save("300 classic examples.update.xml");         //保存Xml文档
StreamReader reader = File.OpenText("300 classic examples.update.xml");//打开Xml文档
Console.Write(reader.ReadToEnd());                      //输出Xml文档内容
reader.Close();

            Console.ReadLine();
        }
    }
}
