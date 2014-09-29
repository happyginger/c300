//// TestCPPDLL.cpp : 定义 DLL 应用程序的导出函数。
////
//
//#include "stdafx.h"
//#include "TestCPPDLL.h"
//
//
//// 这是导出变量的一个示例
//TESTCPPDLL_API int nTestCPPDLL=0;
//
//// 这是导出函数的一个示例。
//TESTCPPDLL_API int fnTestCPPDLL(void)
//{
//	return 42;
//}
//
//// 这是已导出类的构造函数。
//// 有关类定义的信息，请参阅 TestCPPDLL.h
//CTestCPPDLL::CTestCPPDLL()
//{
//	return;
//}

#include "stdafx.h"
#include "TestCPPDLL.h"

#include <iostream>
#include <iomanip>
#include <bitset>
using namespace std;

//各种类型混合运算
TESTCPPDLL_API double __stdcall MixedOperation(short a, int b, long c, bool d, char e, wchar_t f, float g, double h)
{
	cout<<"C++ short 类型 "<<a<<endl
		<<"C++ int 类型 "<<b<<endl
		<<"C++ long 类型 "<<c<<endl
		<<"C++ bool 类型 "<<d<<endl
		<<"C++ char 类型 "<<e<<endl
		<<"C++ wchar_t 类型 "<<f<<endl
		<<"C++ float 类型 "<<g<<endl
		<<"C++ double 类型 "<<h<<endl;
	return a + b - c * d / e + f - g * h;
}

//输出宽字符集字符串
TESTCPPDLL_API void __stdcall COutString(wchar_t* wstring)
{
	//获取宽字符集长度
	int len= WideCharToMultiByte(CP_ACP,0,wstring,wcslen(wstring),NULL,0,NULL,NULL);  
    char* string = new char[len+1];  //多字符集
	//将宽字符集转换成宽字符集
    WideCharToMultiByte(CP_ACP,0,wstring,wcslen(wstring),string,len,NULL,NULL);  
    string[len]='\0'; 
	cout<<"C++ 多字符集 字符串 "<<string;
}

TESTCPPDLL_API void __stdcall COutArray(int* intArray, int length)
{
	cout<<"C++ 输出数组 ";
	for (int i = 0; i < length; i++) cout<<*intArray++<<" ";
}

TESTCPPDLL_API void __stdcall SetCAddCallback(CAddCallback addCallback)
{
	int a = 352, b = 288;
	cout<<"C++ 输入 a = "<<a<<" b = "<<b<<endl;
	addCallback(a, b);									//调用C#中的委托
}

TESTCPPDLL_API void __stdcall COutStruct(CAddStruct addStruct)
{
cout<<endl<<"C++ 计算结构体中的数"<<endl<<addStruct.A<<" + "<<addStruct.B<<" + "<<addStruct.C<<" = "<<addStruct.A + addStruct.B + addStruct.C;
cout<<endl<<"C++ 输出结构体中的字符串"<<endl<<addStruct.D<<endl;
}

TESTCPPDLL_API void __stdcall COutStringPointer(char** pString)
{
	cout<<"C++ 输出 "<<*pString;
}