using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Data;
using System.Drawing;

namespace OfficeOperator
{
public class WordOperator
{
    Application WordApp;                                //Word应用对象
    Document WordDoc;                                   //Word文档对象

public WordOperator()
{
    WordApp = new Application();                        //创建Word应用对象
    WordApp.Visible = true;                             //创建完成后是否显示Word文档
}

public void CreateWord()
{
    WordDoc = WordApp.Documents.Add();                  //创建Word文档对象
    WordDoc.PageSetup.Orientation = WdOrientation.wdOrientPortrait;//模板还是竖板
    //WordDocument.PageSetup.TextColumns.SetCount(2);//分栏
    WordDoc.PageSetup.LeftMargin = WordApp.CentimetersToPoints(0.5f);//左边距
    WordDoc.PageSetup.RightMargin = WordApp.CentimetersToPoints(0.5f);//右边距
    WordDoc.PageSetup.TopMargin = WordApp.CentimetersToPoints(0.5f);//上边距
    WordDoc.PageSetup.BottomMargin = WordApp.CentimetersToPoints(0.5f);//下边距
    WordDoc.PageSetup.PageWidth = 400;                  //页宽，单位：像素
    WordDoc.PageSetup.PageHeight = 600;                 //页高，单位：像素
}


public void OpenWord(string fileName)
{
    object FileName = fileName;                         //Word文档文件名称
    WordDoc = WordApp.Documents.Open(ref FileName);     //打开Word文档
}

public void SaveWord(string fileName)
{
    object FileName = fileName;                         //文档名称
    object FileFormat = WdSaveFormat.wdFormatDocument;  //Word文档保存格式
    object LockComments = false;                        //是否锁定批注
    object Password = "";                               //打开Word文档密码
    object WritePassword = "";                          //修改Word文档密码
    object AddToRecentFiles = true;                     //是否将文档添加到近期使用文件菜单中
    WordDoc.SaveAs(ref FileName, ref FileFormat, ref LockComments, ref Password
        , ref AddToRecentFiles, ref WritePassword);     //保存Word文档
}

public void InsertText(string Text, int FontSize, WdColor FontColor, int FontBold, WdParagraphAlignment TextAlignment, string FontName)
{
    WordApp.Application.Selection.Font.Size = FontSize;     //字体大小
    WordApp.Application.Selection.Font.Bold = FontBold;     //是否粗体,0-否,1-是
    WordApp.Application.Selection.Font.Color = FontColor;   //字体颜色
    WordApp.Application.Selection.ParagraphFormat.Alignment = TextAlignment;//字体排布
    WordApp.Application.Selection.Font.Name = FontName;     //字体名称
    WordApp.Application.Selection.TypeText(Text);           //文字内容
}

public void NewLine()
{
    WordApp.Application.Selection.TypeParagraph();          //换行    
}

public void NewPage()
{
    object BreakType = WdBreakType.wdSectionBreakNextPage;  //换页
    WordDoc.Application.Selection.InsertBreak(ref BreakType);//插入换页
}

public void SetPageHeader(string Text)
{
    WordApp.ActiveWindow.View.Type = WdViewType.wdOutlineView;//设置视图类型
    WordApp.ActiveWindow.View.SeekView = WdSeekView.wdSeekPrimaryHeader;//选定页眉
    WordApp.ActiveWindow.ActivePane.Selection.InsertAfter(Text);//向页眉中添加文字
    WordApp.Selection.ParagraphFormat.Alignment =               //设置居中对齐
        WdParagraphAlignment.wdAlignParagraphCenter;
    WordApp.ActiveWindow.View.SeekView = WdSeekView.wdSeekMainDocument;//跳出页眉设置
}

public void SetPageFooter(string Text)
{
    WordApp.ActiveWindow.View.Type = WdViewType.wdOutlineView;//设置视图类型
    WordApp.ActiveWindow.View.SeekView = WdSeekView.wdSeekPrimaryFooter;//选定页脚
    WordApp.ActiveWindow.ActivePane.Selection.InsertAfter(Text);//向页脚中添加文字
    WordApp.Selection.ParagraphFormat.Alignment =               //设置居中对齐  
        WdParagraphAlignment.wdAlignParagraphCenter;
    WordApp.ActiveWindow.View.SeekView = WdSeekView.wdSeekMainDocument;//跳出页脚设置
}

public void InsertPageNumber(bool isFirstPage)
{
    object Alignment = WdPageNumberAlignment.wdAlignPageNumberRight;//页码对齐方式
    object IsFirstPage = isFirstPage;                           //是否从首页开始
    //对所有页眉页脚设置页码
    WdHeaderFooterIndex WdFooterIndex = WdHeaderFooterIndex.wdHeaderFooterPrimary;
    WordApp.Selection.Sections[1].Footers[WdFooterIndex].PageNumbers.Add(ref Alignment, ref IsFirstPage);
}

public void InsertPicture(string FileName, int Width, int Height)
{
    object LinkToFile = false;                          //是否连接到文件
    object SaveWithDocument = true;                     //是否保存到文档中
    object Range = System.Reflection.Missing.Value;
    WordApp.Selection.ParagraphFormat.Alignment =       //设置段落对齐方式
        WdParagraphAlignment.wdAlignParagraphCenter;
    InlineShape inlineShape = WordDoc.Application.Selection.InlineShapes.AddPicture(
        FileName, ref LinkToFile, ref SaveWithDocument, ref Range);//添加图片
    if (Width != 0 || Height != 0)
    {
        inlineShape.Width = Width;                  //设置图像宽度
        inlineShape.Height = Height;                //设置图像高度
    }
    //Shape shape = inlineShape.ConvertToShape();
    //shape.WrapFormat.Type = WdWrapType.wdWrapSquare;//将图片设置为四周环绕型
}

public void InsertTable(DataSet dataSet)
{
    WordDoc.Tables.Add(WordApp.Selection.Range,         //添加表格
        dataSet.Tables[0].Rows.Count, dataSet.Tables[0].Columns.Count);
    //WordDoc.Tables[1].Rows.HeightRule = WdRowHeightRule.wdRowHeightAtLeast;//设置行高规则
    WordDoc.Tables[1].Rows.Height = WordApp.CentimetersToPoints(0.8f);//设置行高
    WordDoc.Tables[1].Range.Font.Size = 10;             //设置字体大小
    WordDoc.Tables[1].Range.Font.Name = "宋体";         //设置字体类型
    WordDoc.Tables[1].Range.ParagraphFormat.Alignment = //设置段落对齐
        WdParagraphAlignment.wdAlignParagraphCenter;
    WordDoc.Tables[1].Range.Cells.VerticalAlignment =   //设置表格元素垂直对齐
        WdCellVerticalAlignment.wdCellAlignVerticalCenter;
    WordDoc.Tables[1].Borders[WdBorderType.wdBorderLeft].LineStyle = //设置左边框
        WdLineStyle.wdLineStyleDouble;
    WordDoc.Tables[1].Borders[WdBorderType.wdBorderRight].LineStyle =  //设置右边框
        WdLineStyle.wdLineStyleDouble;
    WordDoc.Tables[1].Borders[WdBorderType.wdBorderTop].LineStyle =  //设置上边框
        WdLineStyle.wdLineStyleDouble;
    WordDoc.Tables[1].Borders[WdBorderType.wdBorderBottom].LineStyle =  //设置下边框
        WdLineStyle.wdLineStyleDouble;
    WordDoc.Tables[1].Borders[WdBorderType.wdBorderHorizontal].LineStyle =  //设置水平边框
        WdLineStyle.wdLineStyleSingle;
    WordDoc.Tables[1].Borders[WdBorderType.wdBorderVertical].LineStyle =  //设置垂直边框
        WdLineStyle.wdLineStyleSingle;
    //将数据集中的数据填充到表格中
    for (int i = 1; i <= dataSet.Tables[0].Rows.Count; i++)
    {
        for (int j = 1; j <= dataSet.Tables[0].Columns.Count; j++)
        {
            WordDoc.Tables[1].Cell(i, j).Range.Text = dataSet.Tables[0].Rows[i - 1][j - 1].ToString();
        }
    }
}

public string ReadTable()
{
    string stringTable = string.Empty;
    foreach (Table table in WordDoc.Tables)
    {//遍历Word文档中的表格
        for (int row = 1; row <= table.Rows.Count; row++)
        {//遍历表格中的行
            for (int column = 1; column <= table.Columns.Count; column++)
            {//遍历表格中的列
                stringTable += table.Cell(row, column).Range.Text;//读取表格元素
                stringTable = stringTable.Remove(stringTable.Length - 2, 2);//删除\r\a
                stringTable += "\t";
            }
            stringTable += "\n";
        }
    }
    return stringTable;
}


public void QuitWord()
{
    ((_Document)WordDoc).Close();                       //关闭Word文档
    ((_Application)WordApp).Quit();                     //退出Word应用
}

}
}
