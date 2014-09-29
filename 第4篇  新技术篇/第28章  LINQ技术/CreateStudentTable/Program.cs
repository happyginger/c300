using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateStudentTable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
//数据库连接字串
string connection = "Data Source=.\\SQLExpress;Initial Catalog=DataStudentsDataContext;Trusted_Connection=true";
//实例化DataStudentsDataContext类
DataStudentsDataContext linq = new DataStudentsDataContext(connection);

                #region 删除数据库
                if (linq.DatabaseExists()) linq.DeleteDatabase();
                //return;
                #endregion

                #region 创建数据库
                //如果DataStudents数据库不存在则创建该数据库
                if (!linq.DatabaseExists()) linq.CreateDatabase();
                #endregion

                #region 添加表记录
                Console.Title = "在数据库中创建学生信息表";

                //清空学生信息表
                var stsClear = from st in linq.student select st;
                linq.student.DeleteAllOnSubmit(stsClear);
                linq.SubmitChanges();

                string[] surnames = new string[] {              //姓数组
    "郑", "胡", "张", "李", "王", "赵", "周", "刘", "钱", "孙"};
                string[] names = new string[] {                 //名数组
    "一","二","三","四","五", "六","七","八","九","十"};
                int number = 20120001;                          //学号起始值
                Random r = new Random();                        //伪随机数生成器
                for (int i = 0; i < 20; i++)
                {//随机生成学生信息
                    student student = new student();            //创建学生类
                    student.grade = (uint)r.Next(1, 5);         //1到4之间随机年级
                    student.number = (uint)number++;            //学号从起始值开始自增
                    student.name = surnames[r.Next(surnames.Length)] + names[r.Next(names.Length)];                                 //随机产生学生姓名
                    student.sex = r.Next(2) == 0 ? "男" : "女";  //男或女随机性别
                    student.age = (uint)r.Next(16, 24);          //16到23之间随机年龄
                    student.result = (uint)r.Next(101);          //0到100之间随机成绩
                    linq.student.InsertOnSubmit(student);       //向数据库学生表中插入学生信息
                    linq.SubmitChanges();                       //保存修改
                }

                //分组查询添加的学生信息，并进行排序
                var sts = from st in linq.student
                          orderby st.grade, st.sex, st.result descending//按姓名，性别升序，按成绩降序
                          group st by new { st.grade, st.sex } into gst //按年级和性别分组
                          select new { gst.Key, gst };
                sts.ToList().ForEach(gst =>
                {                   //遍历每个分组，并统计
                    gst.gst.ToList().ForEach(st => Console.WriteLine(st));
                });//遍历每组学生信息并输出

                #endregion

Console.ReadLine(); Console.Clear();

                #region 查询表记录
Console.Title = "查询数据库成绩合格的男生信息";
var stsSel = (from st in linq.student                   //查询表学生信息表
              where st.sex == "男" && st.result >= 60  //选择成绩大于60的男生
              select st).OrderBy(st => st.number);    //按学号排序

//查询成绩合格的男生信息
Console.WriteLine("成绩合格 的 男生 信息如下：");
stsSel.ToList().ForEach(st => Console.WriteLine(st));

                #endregion

Console.ReadLine(); Console.Clear();

                #region 修改表数据

Console.Title = "在数据库中修改姓王的学生成绩";
var stsUpd = from st in linq.student
             where st.name.StartsWith("王")          //模糊搜索
             select st;
Console.WriteLine("姓王的学生信息如下：");
foreach (var st in stsUpd) Console.WriteLine(st);

foreach (var st in stsUpd)
{
    if (st.result > 90) st.result = 100;            //大于90分的修改成100分
    else if (st.result < 60) st.result = 60;        //小于60分的修改成60分
    else st.result += 10;                           //60到90之间的加10分
}
linq.SubmitChanges();                               //保存修改

Console.ReadLine(); Console.Clear();

//查询并显示修改后姓王的学生信息
var stsSelLeft = from st in linq.student where st.name.StartsWith("王") select st;
Console.WriteLine("修改后姓王的学生信息如下：");
foreach (var st in stsUpd) Console.WriteLine(st);

                #endregion

Console.ReadLine(); Console.Clear();

                #region 排序表数据
Console.Title = "降序排列数据库中各年级男生的成绩";
var stsSort = from st in linq.student   //查询学生表
              orderby st.grade                    //分组按年级升序排序
              where st.sex == "男"                //按性别过滤
              group st by st.grade into gst       //按年级分组
              select new
              {
                  gst.Key,                        //年级
                  sts = gst.OrderByDescending(s => s.result)//各年级内学生按成绩降序排序
              };
foreach (var gst in stsSort)
{//显示各年级男生信息
    Console.WriteLine("{0}年级的男生信息如下：", gst.Key);
    foreach (var st in gst.sts) Console.WriteLine(st);
}
                #endregion

Console.ReadLine(); Console.Clear();

                #region 统计表数据
Console.Title = "统计各年级学生成绩总分和平均年龄";
var stsSta = from st in linq.student
             group st by st.grade into gst               //按年级分组
             select new
             {
                 gst.Key,                       //年级
                 sum = gst.Sum(st => st.result),         //各年级成绩总和
                 avg = gst.Average(st => st.age)
             };      //各年级平均年龄

foreach (var gst in stsSta)                     //输出各年级部分和平抑年龄
    Console.WriteLine("{0} 年级成绩总分为: {1} 平均年龄为: {2}", gst.Key, gst.sum, gst.avg);

Console.ReadLine();
Console.Clear();

Console.Title = "统计男生和女生成绩的最高和最低分";
var stsBG = from st in linq.student
            group st by st.sex into gst                 //按性别分组
            select new
            {
                gst.Key,                       //性别
                max = gst.Max(st => st.result),     //最好成绩
                min = gst.Min(st => st.result)
            };    //最差成绩
foreach (var gst in stsBG)
    Console.WriteLine("{0}生 最高分为: {1} 最低分为: {2}", gst.Key, gst.max, gst.min);
                #endregion

Console.ReadLine(); Console.Clear();

                #region 查询操作符
Console.Title = "查询年龄在20岁以上和成绩在60分以下的学生";
//年龄在20以上
var stsAge = from st in linq.student where st.age > 20 select st;
//成绩在60以下
var stsRes = from st in linq.student where st.result < 60 select st;

//年龄在20以上 和 成绩在60以下的学生,自动过滤相同项
var stsUnion = stsAge.Union(stsRes).OrderBy(st => st.number);
Console.WriteLine("年龄在20以上 和 成绩在60以下不含相同项的学生信息如下：");
foreach (var st in stsUnion) Console.WriteLine(st);

Console.ReadLine(); Console.Clear();

//年龄在20以上 和 成绩在60以下的学生,不过滤相同项
var stsConcat = stsAge.Concat(stsRes).OrderBy(st => st.number);
Console.WriteLine("年龄在20以上 和 成绩在60以下含相同项的学生信息如下：");
foreach (var st in stsConcat) Console.WriteLine(st);

Console.ReadLine(); Console.Clear();

//年龄在20以上 且 成绩在60以下的学生
var stsIntersect = stsAge.Intersect(stsRes).OrderBy(st => st.number);
Console.WriteLine("年龄在20以上 且 成绩在60以下的学生信息如下：");
foreach (var st in stsIntersect) Console.WriteLine(st);

Console.ReadLine(); Console.Clear();

//年龄在20以上 且 成绩 不 在60以下的学生
var stsExcept = stsAge.Except(stsRes).OrderBy(st => st.number);
Console.WriteLine("年龄在20以上 且 成绩 不 在60以下的学生信息如下：");
foreach (var st in stsExcept) Console.WriteLine(st);

Console.ReadLine(); Console.Clear();

//查询并显示数据库第11到第15条学生信息
Console.Title = "查询数据库第11到第15条学生信息";
var stsSkip = (from st in linq.student select st).Skip(10).Take(5);
Console.WriteLine("第11到第15条学生信息如下：");
foreach (var st in stsSkip) Console.WriteLine(st);
                #endregion

Console.ReadLine(); Console.Clear();

                #region 删除表记录

Console.Title = "从数据库中删除成绩不合格的学生信息";
//查询并显示成绩不合格的学生信息
var stsDel = from st in linq.student where st.result < 60 select st;
Console.WriteLine("成绩不合格的学生信息如下：");
foreach (var st in stsDel) Console.WriteLine(st);

linq.student.DeleteAllOnSubmit(stsDel);//从数据库中删除成绩不合格的学生信息
linq.SubmitChanges();                   //保存修改

Console.ReadLine(); Console.Clear();

var stsAll = from st in linq.student select st;     //查询并显示所有学生信息
Console.WriteLine("成绩合格的学生信息如下：");
foreach (var st in stsAll) Console.WriteLine(st);

                #endregion

                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
