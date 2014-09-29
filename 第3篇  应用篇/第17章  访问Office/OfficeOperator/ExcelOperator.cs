using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace OfficeOperator
{
public class ExcelOperator
{
    public Application ExcelApplication;                //Excel应用对象
    public Workbook ExcelWorkbook;                      //Excel工作薄对象
    public Worksheet ExcelWorksheet;                    //Excel工作表对象
    public ExcelOperator()
    {
        ExcelApplication = new Application();           //创建Application对象
    }

public Range this[object indexRow, object indexColumn]
{
    get { return ExcelWorksheet.Cells[indexRow, indexColumn]; }//返回指定单元格
}

public void OpenExcel(string fileName)
{
    ExcelWorkbook = ExcelApplication.Workbooks.Open(fileName);//打开Excel表格
    ExcelWorksheet = ExcelWorkbook.Worksheets[1] as Worksheet;//获取工作表
}

public void CreateExcel()
{
    ExcelApplication.Visible = true;                    //创建完成后是否打开Excel
    ExcelWorkbook = ExcelApplication.Workbooks.Add(true);//添加工作薄
    ExcelWorksheet = ExcelWorkbook.Worksheets[1] as Worksheet;//获取工作表
}

public void SaveExcel(string fileName)
{
    ExcelApplication.DisplayAlerts = false;             //设置禁止弹出保存询问提示框
    ExcelApplication.AlertBeforeOverwriting = false;    //设置禁止弹出覆盖询问提示框
    object FileName = fileName;                         //需要保存Excel文件的名称
    object Password = "";                               //打开Excel文档密码，少于16位
    object WriteResPassword = "";                       //修改Excel文档密码，少于16位
    object ReadOnlyRecommended = false;                 //Excel以只读形式打开是否提示
    object CreateBackup = false;                        //是否创建备份
    ExcelWorkbook.SaveAs(FileName, Missing.Value, Password, WriteResPassword, 
        ReadOnlyRecommended, CreateBackup, XlSaveAsAccessMode.xlNoChange);
}

public void QuitExcel()
{
    ExcelApplication.Quit();                            //退出Excel应用
}
    }
}
