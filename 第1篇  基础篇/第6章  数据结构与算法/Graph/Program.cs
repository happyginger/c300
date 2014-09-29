using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "遍历城市网";


string[] cities = new string[] { "北京", "上海", "天津", "重庆", "武汉","深圳","成都","西安"};
AdjacencyList graph = new AdjacencyList(cities);
graph.AddEdge(cities[0], cities[1]);
graph.AddEdge(cities[0], cities[2]);
graph.AddEdge(cities[1], cities[3]);
graph.AddEdge(cities[1], cities[4]);
graph.AddEdge(cities[2], cities[5]);
graph.AddEdge(cities[2], cities[6]);
graph.AddEdge(cities[3], cities[7]);
graph.AddEdge(cities[4], cities[7]);
graph.AddEdge(cities[5], cities[6]);
graph.DepthFirstSearch();


            Console.ReadLine();
        }

        //邻接表
class AdjacencyList
{
    VertexNode[] vertexes;                              //顶点顺序表
    public VertexNode this[int index]                   //检索指定顶点
    {
        get { return vertexes[index]; }
    }
    public AdjacencyList(string[] cities)
    {
        vertexes = new VertexNode[cities.Length];
        for (int i = 0; i < cities.Length; i++)
        {
            vertexes[i] = new VertexNode(cities[i]);
        }
    }
    //在两个城市间建立连接
    public void AddEdge(string city1, string city2)
    {
        VertexNode vertex1 = null, vertex2 = null;
        foreach (var item in vertexes)
        {
            if (vertex1 == null && item.City == city1) vertex1 = item;
            if (vertex2 == null && item.City == city2) vertex2 = item;
        }
        if (vertex1 == null || vertex2 == null || vertex1 == vertex2) return;
        AdjacencyNode node = vertex1.FirstNode;
        //检测边是否已经存在
        while (node != null)
        {
            if (node.Vertex == vertex2) return;
            node = node.Next;
        }
        //将城市2插入到城市1的邻接表中
        vertex1.FirstNode = new AdjacencyNode(vertex2, vertex1.FirstNode);
        //将城市1插入到城市2的邻接表中
        vertex2.FirstNode = new AdjacencyNode(vertex1, vertex2.FirstNode);
    }
    //深度优先遍历
    public void DepthFirstSearch()
    {
        foreach (VertexNode vertex in vertexes)
        {
            DepthFirstSearchVertex(vertex);
        }
    }
    //深度优先遍历顶点
    void DepthFirstSearchVertex(VertexNode vertex)
    {
        if (vertex == null || vertex.Visited) return;
        Console.Write(vertex.City + "\t");
        vertex.Visited = true;
        AdjacencyNode node = vertex.FirstNode;          //第一个邻接结点
        while (node != null)
        {
            DepthFirstSearchVertex(node.Vertex);
            node = node.Next;
        }
    }
}

        //邻接表结点
class AdjacencyNode
{
    public readonly VertexNode Vertex;                  //结点指向的顶点
    public AdjacencyNode Next { get; set; }             //结点指向的下一结点
    public AdjacencyNode(VertexNode vertex, AdjacencyNode next)
    {
        this.Vertex = vertex;
        this.Next = next;
    }
}

        //邻接表顶点
class VertexNode
{
    public bool Visited { get; set; }                   //标记是否被访问
    public readonly string City;                        //城市名称
    public AdjacencyNode FirstNode { get; set; }        //邻接表头结点
    public VertexNode(string city)
    {
        Visited = false;
        this.City = city;
    }
}
    }
}
