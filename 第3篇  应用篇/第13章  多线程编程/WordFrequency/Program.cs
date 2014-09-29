using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WordFrequency
{
    class Program
    {
static Random random = new Random();
static AutoResetEvent locker = new AutoResetEvent(false);//线程锁
static int count = 0;                                   //线程计数标识
static Dictionary<string, int>[] groupFrequencies = new Dictionary<string, int>[10];//单词分组词频
static string[][] wordsGroups = new string[10][];       //单词分组

static void Main(string[] args)
{
    Console.Title = "统计单词词频";

string[] words = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
for (int i = 0; i < 10; i++)
{
    groupFrequencies[i] = new Dictionary<string, int>();//初始化单词分组词频数组
    //随机初始化单词分组
    wordsGroups[i] = new string[random.Next(100000, 200000)];
    for (int j = 0; j < wordsGroups[i].Length; j++)
        wordsGroups[i][j] = words[random.Next(10)];
    Thread thread = new Thread(new ParameterizedThreadStart(Map));//创建单词分组统计词频线程
    thread.Start(i);
}

locker.WaitOne();                                   //等待所有分组统计完毕
//单词词频数组列表
Dictionary<string, List<int>> wordFrequencies = new Dictionary<string, List<int>>();
//生成单词词频数组映射表
for (int i = 0; i < 10; i++)
{
    foreach (var item in groupFrequencies[i])
    {
        if (wordFrequencies.ContainsKey(item.Key))
            wordFrequencies[item.Key].Add(item.Value);//将单词在各分组中的词频添加到单词词频数组中
        else
            wordFrequencies.Add(item.Key, new List<int>());
    }
}

    foreach (var item in wordFrequencies)               //汇总各单词的词频
    {
        Thread thread = new Thread(new ParameterizedThreadStart(Reduce));//创建统计单词总词频线程
        thread.Start(item);
    }

    Console.ReadLine();
}

static void Map(object state)                           //分组中单词词频映射线程函数
{
    int index = (int)state;
    foreach (string word in wordsGroups[index])         //统计分组中各单词的词频
    {
        if (groupFrequencies[index].ContainsKey(word))
            groupFrequencies[index][word]++;            //如果存储该单词则词频加1
        else groupFrequencies[index].Add(word, 1);      //如果不存在该单词将建立单词词频映射
    }
    count++;
    if (count == 10) locker.Set();                      //释放线程锁
}

static void Reduce(object state)                        //单词词频汇总线程函数
{
    KeyValuePair<string, List<int>> frequencies = (KeyValuePair<string, List<int>>)state;
    int frequency = 0;
    foreach (var item in frequencies.Value) frequency += item;//计算单词总词频
    Console.WriteLine("单词{0}的词频为{1}", frequencies.Key, frequency);
}
    }
}
