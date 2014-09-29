//// TestCPPDLL.cpp : ���� DLL Ӧ�ó���ĵ���������
////
//
//#include "stdafx.h"
//#include "TestCPPDLL.h"
//
//
//// ���ǵ���������һ��ʾ��
//TESTCPPDLL_API int nTestCPPDLL=0;
//
//// ���ǵ���������һ��ʾ����
//TESTCPPDLL_API int fnTestCPPDLL(void)
//{
//	return 42;
//}
//
//// �����ѵ�����Ĺ��캯����
//// �й��ඨ�����Ϣ������� TestCPPDLL.h
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

//�������ͻ������
TESTCPPDLL_API double __stdcall MixedOperation(short a, int b, long c, bool d, char e, wchar_t f, float g, double h)
{
	cout<<"C++ short ���� "<<a<<endl
		<<"C++ int ���� "<<b<<endl
		<<"C++ long ���� "<<c<<endl
		<<"C++ bool ���� "<<d<<endl
		<<"C++ char ���� "<<e<<endl
		<<"C++ wchar_t ���� "<<f<<endl
		<<"C++ float ���� "<<g<<endl
		<<"C++ double ���� "<<h<<endl;
	return a + b - c * d / e + f - g * h;
}

//������ַ����ַ���
TESTCPPDLL_API void __stdcall COutString(wchar_t* wstring)
{
	//��ȡ���ַ�������
	int len= WideCharToMultiByte(CP_ACP,0,wstring,wcslen(wstring),NULL,0,NULL,NULL);  
    char* string = new char[len+1];  //���ַ���
	//�����ַ���ת���ɿ��ַ���
    WideCharToMultiByte(CP_ACP,0,wstring,wcslen(wstring),string,len,NULL,NULL);  
    string[len]='\0'; 
	cout<<"C++ ���ַ��� �ַ��� "<<string;
}

TESTCPPDLL_API void __stdcall COutArray(int* intArray, int length)
{
	cout<<"C++ ������� ";
	for (int i = 0; i < length; i++) cout<<*intArray++<<" ";
}

TESTCPPDLL_API void __stdcall SetCAddCallback(CAddCallback addCallback)
{
	int a = 352, b = 288;
	cout<<"C++ ���� a = "<<a<<" b = "<<b<<endl;
	addCallback(a, b);									//����C#�е�ί��
}

TESTCPPDLL_API void __stdcall COutStruct(CAddStruct addStruct)
{
cout<<endl<<"C++ ����ṹ���е���"<<endl<<addStruct.A<<" + "<<addStruct.B<<" + "<<addStruct.C<<" = "<<addStruct.A + addStruct.B + addStruct.C;
cout<<endl<<"C++ ����ṹ���е��ַ���"<<endl<<addStruct.D<<endl;
}

TESTCPPDLL_API void __stdcall COutStringPointer(char** pString)
{
	cout<<"C++ ��� "<<*pString;
}