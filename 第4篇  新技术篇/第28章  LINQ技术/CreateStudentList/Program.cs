using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateStudentList
{
    class Program
    {
        static void Main(string[] args)
        {
var sts = Student.GetStudents(20);  //生成含有20条学生信息的列表

            #region 实例281  查询年龄大于20岁的学生信息
//查询年龄大于20的学生信息
Console.Title = "查询年龄大于20的学生信息";
var stsAge = from st in sts where st.Age > 20 select st;
Console.WriteLine("年龄大于20的学生如下：");
stsAge.ToList().ForEach(st => Console.WriteLine(st));
            #endregion

Console.ReadLine(); Console.Clear();

            #region 实例282  输出成绩在指定范围内的学生信息
//查询成绩在60到80之间的学生信息
Console.Title = "输出成绩在指定范围内的学生信息";
var stsResult = Array.FindAll(sts, st => st.Result >= 60 && st.Result <= 80);
Console.WriteLine("\n成绩在60到80之间的学生如下：");
stsResult.ToList().ForEach(st => Console.WriteLine(st));
            #endregion

Console.ReadLine(); Console.Clear();

            #region 实例283  对学生成绩进行排序
//查询所有学生成绩的信息，并对其进行降序排列。
Console.Title = "对学生成绩进行排序";
var stsSort = from st in sts orderby st.Result descending select st;
Console.WriteLine("\n对学生成绩进行降序排列：");
stsSort.ToList().ForEach(st => Console.WriteLine(st));
            #endregion

Console.ReadLine(); Console.Clear();
            
            #region 实例284  按年级和性别分组查询学生信息
Console.Title = "按年级和性别分组查询学生信息";
var stsGroup = from st in sts        //从学生列表中查询学生信息
    //按年级和性别递增按成绩递减排序
    orderby st.Grade, st.Sex, st.Result descending
    group st by                         //按性别和年级分组
    new { st.Sex, st.Grade } into gst
    where gst.Count() > 2               //限制每组的数量
    select new
    {
        gst.Key,                        //年级,性别
        count = gst.Count(),            //统计各年级学生总数
        count60 = gst.Count(st => st.Result >= 60),//及格学生数量
        sts = gst                       //学生分组列表
    };

Console.WriteLine("\n对学生按年级和性别分组排序且每组人数大于2的学生信息如下：");
stsGroup.ToList().ForEach(gst =>{       //遍历每个分组，并统计
    Console.WriteLine(" {0} 年级的 {1} 学生数量为 {2}, 成绩在 60 分以上学生数量为 {3}", gst.Key.Grade, gst.Key.Sex, gst.count, gst.count60);
    gst.sts.ToList().ForEach(st => Console.WriteLine(st));});//遍历每组学生信息并输出

            #endregion

            Console.ReadLine();
        }
    }
}
