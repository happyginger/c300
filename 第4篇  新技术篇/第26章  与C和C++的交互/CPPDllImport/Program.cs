using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace CPPDllImport
{
    class Program
    {
[DllImport("TestCPPDLL.dll", EntryPoint = "MixedOperation")]
extern static double MixedOperation(short a, int b, int c, bool d, byte e, char f, float g, double h);

[DllImport("TestCPPDLL.dll", EntryPoint = "COutString")]
extern static unsafe void COutString(char* String);

[DllImport("TestCPPDLL.dll", EntryPoint = "COutArray")]
extern static unsafe void COutArrayPointer(int* intArray, int length);
[DllImport("TestCPPDLL.dll", EntryPoint = "COutArray")]
extern static void COutArray(ref int intArray, int length);

[DllImport("TestCPPDLL.dll", EntryPoint = "SetCAddCallback")]
extern static void SetCAddCallback(CAddCallback addCallback);

//定义一个输入参数为两个整型的委托类型
public delegate void CAddCallback(int a, int b);
//与C++中两数相加的函数想匹配
static void CAdd(int a, int b)
{
    Console.WriteLine("C# 计算 a + b = {0}", a + b);
}

[StructLayout(LayoutKind.Sequential)]
//定义一个结构体，与C++中的结构体相匹配
struct CAddStruct
{
    public int A, B, C;
    //固定数组的长度，与C++中的结构体想匹配
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
    public byte[] D;
}

[DllImport(@"TestCPPDLL.dll", EntryPoint = "COutStruct")]
extern static void COutStruct(CAddStruct addStruct);

[DllImport(@"TestCPPDLL.dll", EntryPoint = "COutStringPointer")]
extern static unsafe void COutStringPointer(IntPtr pString);

        static void Main(string[] args)
        {
            #region 实例266  C/C++中的基本类型在C#中传递
//Console.Title = "C/C++中的基本类型在C#中传递";
//short a = 10000;                            //有符号短整型
//int b = 1000000000, c = 1000000000;         //有符号整型
//bool d = true;                              //布尔型
//byte e = 100;                               //字节型
//char f = 'a';                               //字符型
//float g = 3.1415926f;                       //单精度浮点型
//double h = 3.1415926;                       //双精度浮点型
////调用C++的MixedOperation方法获取混合运算结果
//double mixed = MixedOperation(a, b, c, d, e, f, g, h);
//Console.WriteLine("C# short 类型 {0}\nC# int 类型 {1}\nC# int 类型 {2}\nC# bool 类型 {3}\nC# byte 类型 {4}\nC# char 类型 {5}\nC# float 类型 {6}\nC# double 类型 {7}\n", a, b, c, d, e, f, g, h);
//Console.WriteLine("C++ MixedOperation {0}", mixed);
            #endregion

            #region 实例267  C/C++中的结构体在C#中传递
//Console.Title = "C/C++中的结构体在C#中传递";
//CAddStruct addStruct = new CAddStruct() { A = 352, B = 288, C = 576 };//实例化需要传递的结构体
//addStruct.D = new byte[100];                            //为结构体中的字节数组赋值
////将需要传递的字符串转换为字节数组
//byte[] byteString = Encoding.Default.GetBytes("300 classic examples");
//Console.WriteLine("C# 输入结构体 \nCOutStruct.A = {0}\nCOutStruct.B = {1}\nCOutStruct.C = {2}", addStruct.A, addStruct.B, addStruct.C);
//StringBuilder SB = new StringBuilder("COutStruct.D = ");
//for (int i = 0; i < byteString.Length; i++)
//{
//    SB.Append(Convert.ToChar(byteString[i]));
//    addStruct.D[i] = byteString[i];                     //将字符串字节数组赋值给结构体中的字节数组
//}
//Console.WriteLine(SB);
//COutStruct(addStruct);                                  //调用C++中的输出结构体方法
            #endregion
            
            #region 实例268  C/C++中的指针在C#中传递
//Console.Title = "C/C++中的指针在C#中传递";
//Random r = new Random();
//int[] numbers = new int[10];                //创建整型数组
//Console.Write("C# 输入数组");
//for (int i = 0; i < 10; i++)
//{
//    numbers[i] = r.Next(100);               //为数组元素随机赋值
//    Console.Write(" " + numbers[i]);
//}
//Console.WriteLine();
//COutArray(ref numbers[0], 10);              //传递数组第一个元素的引用
//Console.WriteLine();
//unsafe
//{
//    fixed (int* pNumber = &numbers[0])       //取整型数组第一个元素的地址做为指针
//    {
//        COutArrayPointer(pNumber, 10);      //传递整型指针
//    }
//}
            #endregion

            #region 实例269  C/C++中的函数指针在C#中传递
//Console.Title = "C/C++中的函数指针在C#中传递";
////将CAdd的函数指针以委托的形式传递到C++的中
//SetCAddCallback(new CAddCallback(CAdd));
            #endregion

            #region 实例270  C/C++中指针的指针在C#中传递
//Console.Title = "C/C++中指针的指针在C#中传递";
//string String = "\"300 classic examples\"";
//Console.WriteLine("C# 输入 {0} 指针的指针", String);
//unsafe
//{
//    byte[] byteString = Encoding.Default.GetBytes(String);  //将字符串转换成字节数组
//    //为字节数组分配非托管内存可访问的句柄
//    GCHandle hObject = GCHandle.Alloc(byteString, GCHandleType.Pinned);
//    IntPtr pObject = hObject.AddrOfPinnedObject();          //获取字节数组的指针
//    //为字节数组指针分配可访问句柄
//    GCHandle hIntPtr = GCHandle.Alloc(pObject, GCHandleType.Pinned);
//    IntPtr pIntPtr = hIntPtr.AddrOfPinnedObject();          //获取数组指针的指针
//    COutStringPointer(pIntPtr);                             //将字符串指针的指针转递到C++的函数中
//    if (hObject.IsAllocated) hObject.Free();                //释放字节数组句柄
//    if (hIntPtr.IsAllocated) hIntPtr.Free();                //释放字节数组指针句柄
//}
            #endregion

            Console.Read();
        }
    }
}
