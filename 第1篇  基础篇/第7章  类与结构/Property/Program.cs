using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "旅行社费用计算";

TravelService travelService = new TravelService();      //创建旅行社实例
Console.WriteLine("请输入需您想旅游的城市：");
travelService.City = Console.ReadLine();
if (travelService.Cost > 0)
    Console.WriteLine("您需要花费{0:C}元旅行费用！", travelService.Cost);
else Console.WriteLine("本旅行社暂不提供该城市的旅游服务！");

            Console.ReadLine();
        }
    }
//旅行社类
class TravelService
{
    public int Cost                                     //旅游的费用
    {
        get
        {
            switch (city)
            {
                case "北京": return 1000;
                case "上海": return 1500;
                case "三亚": return 3000;
                default: return -1;
            }
        }
    }
    string city = string.Empty;
    public string City                                  //旅游的城市
    {
        get { return city; }
        set
        {
            if (value == "北京" || value == "上海" || value == "三亚")
                city = value;
            else city = string.Empty;
        }
    }
}
}
