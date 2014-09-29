//// 下列 ifdef 块是创建使从 DLL 导出更简单的
//// 宏的标准方法。此 DLL 中的所有文件都是用命令行上定义的 TESTCPPDLL_EXPORTS
//// 符号编译的。在使用此 DLL 的
//// 任何其他项目上不应定义此符号。这样，源文件中包含此文件的任何其他项目都会将
//// TESTCPPDLL_API 函数视为是从 DLL 导入的，而此 DLL 则将用此宏定义的
//// 符号视为是被导出的。
//#ifdef TESTCPPDLL_EXPORTS
//#define TESTCPPDLL_API __declspec(dllexport)
//#else
//#define TESTCPPDLL_API __declspec(dllimport)
//#endif
//
//// 此类是从 TestCPPDLL.dll 导出的
//class TESTCPPDLL_API CTestCPPDLL {
//public:
//	CTestCPPDLL(void);
//	// TODO: 在此添加您的方法。
//};
//
//extern TESTCPPDLL_API int nTestCPPDLL;
//
//TESTCPPDLL_API int fnTestCPPDLL(void);

//第一行代码中定义了一个名为"TESTCPPDLL_API"的宏，
//该宏对应的内容是"__declspec(dllexport)"意思是
//将后面修饰的内容定义为DLL中要导出的内容。
//当然你也可以不使用这个宏，可以直接将
//"__declspec(dllexport)"写在要导出的函数前面。
//第二行中的"EXTERN_C"，是在"winnt.h"中定义的宏，
//在函数前面添加"EXTERN_C"等同于在函数前面添加extern "C",
//意思是该函数在编译和连接时使用C语言的方式，以保证函数名字不变。
#define TESTCPPDLL_API __declspec(dllexport)
EXTERN_C TESTCPPDLL_API double __stdcall MixedOperation(short a, int b, long c, bool d, char e, wchar_t f, float g, double h);
EXTERN_C TESTCPPDLL_API void __stdcall COutString(wchar_t* string);
EXTERN_C TESTCPPDLL_API void __stdcall COutArray(int* intArray, int length);

typedef void (__stdcall *CAddCallback)(int a, int b);
EXTERN_C TESTCPPDLL_API void __stdcall SetCAddCallback(CAddCallback addCallback);

struct CAddStruct
{
	int A, B, C;
	char D[100];
};

EXTERN_C TESTCPPDLL_API void __stdcall COutStruct(CAddStruct addStruct);


EXTERN_C TESTCPPDLL_API void __stdcall COutStringPointer(char** pString);