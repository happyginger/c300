using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvinceCity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "生成省市信息表";
//创建省份列表
Dictionary<string, List<string>> provinces = new Dictionary<string, List<string>>();
List<string> HeBei = new List<string>();                //创建河北省
provinces.Add("河北", HeBei);                             //将河北省添加到省份列表中
HeBei.Add("石家庄");                                       //添加城市
HeBei.Add("唐山");                                        //添加城市
List<string> ShanXi = new List<string>();               //创建山西省
provinces.Add("山西", ShanXi);                            //将山西省添加到省份列表中
ShanXi.Add("太原");                                       //添加城市
ShanXi.Add("大同");                                       //添加城市
List<string> JiangSu = new List<string>();                  //创建江苏省
provinces.Add("江苏", JiangSu);                           //将江苏省添加到省份列表中
JiangSu.Add("南京");                                      //添加城市
JiangSu.Add("苏州");                                      //添加城市


foreach (KeyValuePair<string,List<string>> province in provinces)
{//遍历省份信息
    Console.WriteLine("{0}省：", province.Key);
    foreach (string city in province.Value)
    {//遍历城市信息
        Console.WriteLine("\t{0}市", city);
    }
}

Console.WriteLine("请输入需要查询的省份：");
string pro = Console.ReadLine();
if (provinces.ContainsKey(pro))
{
    foreach (string city in provinces[pro])
        Console.WriteLine("\t{0}市", city);
}
else
{
    Console.WriteLine("您需要查询的省份不存在！");
}
            

            Console.ReadLine();
        }
    }
}
