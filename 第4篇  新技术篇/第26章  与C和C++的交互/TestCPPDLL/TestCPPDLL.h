//// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
//// ��ı�׼�������� DLL �е������ļ��������������϶���� TESTCPPDLL_EXPORTS
//// ���ű���ġ���ʹ�ô� DLL ��
//// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
//// TESTCPPDLL_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
//// ������Ϊ�Ǳ������ġ�
//#ifdef TESTCPPDLL_EXPORTS
//#define TESTCPPDLL_API __declspec(dllexport)
//#else
//#define TESTCPPDLL_API __declspec(dllimport)
//#endif
//
//// �����Ǵ� TestCPPDLL.dll ������
//class TESTCPPDLL_API CTestCPPDLL {
//public:
//	CTestCPPDLL(void);
//	// TODO: �ڴ�������ķ�����
//};
//
//extern TESTCPPDLL_API int nTestCPPDLL;
//
//TESTCPPDLL_API int fnTestCPPDLL(void);

//��һ�д����ж�����һ����Ϊ"TESTCPPDLL_API"�ĺ꣬
//�ú��Ӧ��������"__declspec(dllexport)"��˼��
//���������ε����ݶ���ΪDLL��Ҫ���������ݡ�
//��Ȼ��Ҳ���Բ�ʹ������꣬����ֱ�ӽ�
//"__declspec(dllexport)"д��Ҫ�����ĺ���ǰ�档
//�ڶ����е�"EXTERN_C"������"winnt.h"�ж���ĺ꣬
//�ں���ǰ�����"EXTERN_C"��ͬ���ں���ǰ�����extern "C",
//��˼�Ǹú����ڱ��������ʱʹ��C���Եķ�ʽ���Ա�֤�������ֲ��䡣
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