using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "计算学生年级平均成绩";

Result[] results = new Result[4];
results[0] = new Result(86, 75, 98, 62, 76);            //一年级成绩表
results[1] = new Result(96, 84, 88, 59);                //二年级成绩表
results[2] = new Result(76, 65, 68, 67, 86);            //三年级成绩表
results[3] = new Result(56, 93, 48, 52, 77, 88);        //四年级成绩表
StudentGPA gpa = new StudentGPA(results);               //实例化年级平均成绩类
//输出各年级平均成绩
for (int i = 1; i < 5; i++) Console.WriteLine("{0}年级平均成绩为：{1}", i, gpa[i]);

            Console.ReadLine();
        }
    }
//学生年级平均成绩类
class StudentGPA
{
    Result[] results;                                   //创建年级成绩表
    public StudentGPA(Result[] results) { this.results = results; }//构造函数
    public double this[int grade]                       //年级平均成绩索引器
    {
        get
        {
            Result result = results[grade - 1];
            if (grade < 1 || grade > 4 || result == null)
                return -1;                              //获取失败
            int sum = 0;
            for (int i = 0; i < result.Count; i++) sum += result[i];//将分数累加
            return (double)sum / result.Count;                  //求成绩平均值
        }
    }
}
//学生成绩类
class Result
{
    int[] scores;                                    //各学科分数
    public Result(params int[] scores) { this.scores = scores; }
    public int this[int index]                      //学科分数索引器
    {
        get { return scores[index]; }               //获取指定索引科目的分数
        set { scores[index] = value; }              //设置指定索引科目的分数
    }
    public int Count { get { return scores.Length; } }//学科数量
}
    ////成绩类
    //class Result
    //{
    //    int DataBase;                                       //数据库
    //    int OperatingSystem;                                //操作系统
    //    int DataStructure;                                  //数据结构
    //    int CompositionPrinciple;                           //组成原理
    //    public Result(int DB, int OS, int DS, int CP)
    //    {
    //    }
    //}
}
