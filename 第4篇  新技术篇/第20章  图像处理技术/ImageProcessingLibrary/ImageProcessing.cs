using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace ImageProcessingLibrary
{
public static class ImageProcessing
{
/// 将彩色图像转换成灰度图像
/// <param name="image">需要处理的图像</param>
/// <returns></returns>
public static void GreyImage(Bitmap image)
{
    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//将图像锁定到内存中
    byte[] datas = new byte[data.Stride * image.Height];    //图像数组
    Marshal.Copy(data.Scan0, datas, 0, datas.Length);       //将图像在内存中的数据复制到图像数组中
    //计算灰度矩阵
    for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
    {
        for (int x = 0; x < image.Width * 3; x += 3)
        {
            int index = y + x;                              //颜色在内存中的索引
            byte Blue = datas[index];                       //蓝色值
            byte Green = datas[index + 1];                  //绿色值
            byte Red = datas[index + 2];                    //红色值
            datas[index] = datas[index + 1] = datas[index + 2] =
                (byte)((Red * 19595 + Green * 38469 + Blue * 7472) >> 16);//灰度值
        }
    }
    Marshal.Copy(datas, 0, data.Scan0, datas.Length);       //将图像数组复制到内存中
    image.UnlockBits(data);
}

/// 将图像进制中值滤波处理
/// <param name="image">需要处理的图像</param>
public static void MedianFilter(Bitmap image)
{
    BitmapData dataImage = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//将图像锁定到内存中
    unsafe
    {
        byte* pImage = (byte*)dataImage.Scan0.ToPointer();//获取图像头指针
        for (int y = 1; y < image.Height - 1; y++)
        {
            for (int x = 1; x < image.Width - 1; x++)
            {
                List<byte>[] datas = new List<byte>[3];     //创建存放8邻居像素颜色值的列表
                for (int k = 0; k < 3; k++) datas[k] = new List<byte>();
                for (int yy = -1; yy < 2; yy++)
                {
                    for (int xx = -1; xx < 2; xx++)
                    {
                        int index = (y + yy) * dataImage.Stride + (x + xx) * 3;//8邻域像素索引
                        //将8邻域像素颜色值添加到列表中
                        for (int k = 0; k < 3; k++) datas[k].Add(pImage[index + k]);
                    }
                }
                for (int k = 0; k < 3; k++) datas[k].Sort();    //对八邻域颜色值排序
                int indexMedian = y * dataImage.Stride + x * 3;
                for (int k = 0; k < 3; k++)
                {
                    pImage[indexMedian + k] = datas[k][4];      //取排序后的中间值作为像素颜色值
                    datas[k].Clear();
                }
                datas = null;
            }
        }
    }
    image.UnlockBits(dataImage);
}

/// 获取直方图数组，并绘制直方图
/// <param name="image">需要处理的图像</param>
/// <param name="indexColor">处理的颜色索引值，Blue：0，Green：1，Red：2</param>
/// <param name="histogram">直方图统计数组</param>
/// <returns>绘制好的直方图</returns>
public static Bitmap GetHistogram(Bitmap image, int indexColor, out int[] histogram)
{
    histogram = new int[256];                               //直方图统计数组
    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);//将图像锁定到内存中
    byte[] datas = new byte[data.Stride * image.Height];    //图像数组
    Marshal.Copy(data.Scan0, datas, 0, datas.Length);       //将图像在内存中的数据复制到图像数组中
    for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
    {
        for (int x = 0; x < image.Width * 3; x += 3)
        {
            int index = y + x;                              //颜色在内存中的索引
            histogram[datas[index + indexColor]]++;
        }
    }
    image.UnlockBits(data);
    byte maxValue = 0;                                       //直方图中最大值
    for (int value = 1; value < 256; value++)
    {
        if (histogram[value] > histogram[maxValue]) maxValue = (byte)value;
    }
    Bitmap imageHistogram = new Bitmap(256, 256);
    Graphics GHistogram = Graphics.FromImage(imageHistogram);
    GHistogram.Clear(Color.Blue);
    for (int value = 1; value < 256; value++)
    {
        int length = byte.MaxValue * histogram[value] / histogram[maxValue];
        GHistogram.DrawLine(new Pen(Color.FromArgb(value, value, value), 1f), value, 256, value, 256 - length);//绘制直方图
    }
    Font font = new Font("宋体", 9f);
    //绘制统计标识
    for (int value = 32; value < 256; value += 32)
    {
        int count = histogram[maxValue] / 8 * value / 32;
        Pen pen = new Pen(Color.Lime);
        pen.DashStyle = DashStyle.DashDot;
        SizeF sizeCount = GHistogram.MeasureString(count.ToString(), font);
        GHistogram.DrawLine(pen, 0, 255 - value, 255, 255 - value);//绘制数量等级线
        GHistogram.DrawString(count.ToString(), font, Brushes.Red, 5, 255 - value - sizeCount.Height / 2);
        SizeF sizeValue = GHistogram.MeasureString(value.ToString(), font);
        GHistogram.DrawLine(Pens.Red, value, 250, value, 255);//绘制颜色值等级线
        GHistogram.DrawString(value.ToString(), font, Brushes.Red, value - sizeValue.Width / 2, 240);
    }
    font.Dispose();
    return imageHistogram;
}

/// 对图像进行边缘提取
/// <param name="image">灰度图像</param>
/// <param name="threshold">边缘阈值</param>
public static void ExtractEdge(Bitmap image)
{
    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//将图像锁定到内存中
    byte[] datas = new byte[data.Stride * image.Height];    //图像数组
    byte[] edges = new byte[data.Stride * image.Height];    //图像边界
    Marshal.Copy(data.Scan0, datas, 0, datas.Length);       //将图像在内存中的数据复制到图像数组中
    for (int y = data.Stride; y < image.Height * data.Stride - data.Stride; y += data.Stride)
    {
        for (int x = 3; x < image.Width * 3 - 3; x += 3)
        {
            int index = y + x;
            byte grey = datas[index];                        //像素灰度值
            int value = 0;
            //遍历像素点的8邻域像素点，将像素点的灰度值与周围8个点分别求差的绝对值再求和
            for (int yy = -data.Stride; yy <= data.Stride; yy += data.Stride)
            {
                for (int xx = -3; xx <= 3; xx += 3)
                {
                    if (yy == 0 && xx == 0) continue;
                    index = x + y + xx + yy;
                    value += Math.Abs(grey - datas[index]);
                }
            }
            //上一步求和的结果除以8赋值给边界数组
            edges[index] = edges[index + 1] = edges[index + 2] = (byte)(value >> 3);
        }
    }
    Marshal.Copy(edges, 0, data.Scan0, datas.Length);   //将边界数组复制到内存中
    image.UnlockBits(data);                                 //将图像从内存中解锁
}

/// 将图像进行二值化处理
/// <param name="image">需要处理的图像</param>
/// <param name="indexColor">处理的颜色索引值，Blue：0，Green：1，Red：2</param>
/// <param name="thresholdMin">阈值下限</param>
/// <param name="thresholdMax">阈值上限</param>
public static void BinaryImage(Bitmap image, int indexColor, int thresholdMin, int thresholdMax)
{
    //将图像锁定到内存中
    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
    byte[] datas = new byte[data.Stride * image.Height];    //图像数组
    Marshal.Copy(data.Scan0, datas, 0, datas.Length);       //将图像在内存中的数据复制到图像数组中
    for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
    {
        for (int x = 0; x < image.Width * 3; x += 3)
        {
            int index = y + x;
            //根据阈值将图像分成黑色和白色，其中阈值内的为黑色，阈值外的为白色
            if (datas[index + indexColor] >= thresholdMin && datas[index + indexColor] <= thresholdMax)
                datas[index] = datas[index + 1] = datas[index + 2] = 0;
            else
                datas[index] = datas[index + 1] = datas[index + 2] = 255;
        }
    }
    Marshal.Copy(datas, 0, data.Scan0, datas.Length);       //将图像数组复制到内存中
    image.UnlockBits(data);                                 //将图像从内存中解锁
}

/// 利用自动对比度增强方法，对图像进行对比度增强处理
/// <param name="image">需要处理的灰度图像</param>
/// <param name="sourceMin">原始图像灰度下界</param>
/// <param name="sourceMax">原始图像灰度上界</param>
/// <param name="destMin">目标图像灰度下界</param>
/// <param name="destMax">目标图像灰度上界</param>
public static void EnhanceImage(Bitmap image, int sourceMin, int sourceMax, int destMin, int destMax)
{
    //将图像锁定到内存中
    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
    byte[] datas = new byte[data.Stride * image.Height];    //图像数组
    Marshal.Copy(data.Scan0, datas, 0, datas.Length);       //将图像在内存中的数据复制到图像数组中
    for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
    {
        for (int x = 0; x < image.Width * 3; x += 3)
        {
            int index = y + x;            //颜色在内存中的索引
            float value = (float)(destMax - destMin) / (float)(sourceMax - sourceMin)
                * (float)(datas[index] - sourceMin) + destMin;	//灰度值映射关系
            datas[index] = datas[index + 1] = datas[index + 2]
                = value < byte.MinValue ? byte.MinValue : (value > byte.MaxValue ? byte.MaxValue : (byte)value);
        }
    }
    Marshal.Copy(datas, 0, data.Scan0, datas.Length);       //将图像数组复制到内存中
    image.UnlockBits(data);
}

        /// <summary>
        /// 对比度增强
        /// </summary>
        /// <param name="image">需要增强的图像</param>
        /// <param name="n">增强倍率</param>
        public static void EnhanceImage(Bitmap image, float n)
        {
            //将图像锁定到内存中
            BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            byte[] datas = new byte[data.Stride * image.Height];    //图像数组
            Marshal.Copy(data.Scan0, datas, 0, datas.Length);       //将图像在内存中的数据复制到图像数组中
            //计算灰度矩阵
            for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
            {
                for (int x = 0; x < image.Width * 3; x += 3)
                {
                    int index = y + x;            //颜色在内存中的索引
                    float value = datas[index] * n;
                    datas[index] = datas[index + 1] = datas[index + 2]
                        = value < byte.MinValue ? byte.MinValue : (value > byte.MaxValue ? byte.MaxValue : (byte)value);
                }
            }
            Marshal.Copy(datas, 0, data.Scan0, datas.Length);       //将图像数组复制到内存中
            image.UnlockBits(data);
        }

/// 联通区域标记
/// <param name="image">二值图像</param>
public static void ConnectRegion(Bitmap image)
{
    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//将图像锁定到内存中
    byte[] datas = new byte[data.Stride * image.Height];    //图像数组
    Marshal.Copy(data.Scan0, datas, 0, datas.Length);       //将图像在内存中的数据复制到图像数组中
    int sign = 40;
    for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
    {
        for (int x = 0; x < image.Width * 3; x += 3)
        {
            int index = y + x;            //颜色在内存中的索引
            if (datas[index] == 0)
            {
                SignRegion(datas, x, y, sign, data.Stride, image.Width, image.Height);
                sign += 40;
            }
        }
    }
    Marshal.Copy(datas, 0, data.Scan0, datas.Length);       //将图像数组复制到内存中
    image.UnlockBits(data);
}

//区域标记
static void SignRegion(byte[] datas, int x, int y, int sign, int stride, int width, int height)
{
    datas[y + x] = datas[y + x + 1] = datas[y + x + 2] = (byte)sign;//标记区域
    if (x > 0 && datas[y + x - 3] == 0)
    {
        SignRegion(datas, x - 3, y, sign, stride, width, height);//搜索左边像素
    }
    if (x < width * 3 - 3 && datas[y + x + 3] == 0)
    {
        SignRegion(datas, x + 3, y, sign, stride, width, height);//搜索右边像素
    }
    if (y > 0 && datas[y - stride + x] == 0)
    {
        SignRegion(datas, x, y - stride, sign, stride, width, height);//搜索上边像素
    }
    if (y < stride * height && datas[y + stride + x] == 0)
    {
        SignRegion(datas, x, y + stride, sign, stride, width, height);//搜索下边像素
    }
}

//缩小
public static void Dilation(Bitmap image, float horizon, float verticale)
{

    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//将图像锁定到内存中
    byte[] datasOld = new byte[data.Stride * image.Height];    //图像数组
    byte[] datasNew = new byte[data.Stride * image.Height];    //图像数组
    //将图像在内存中的数据复制到图像数组中
    Marshal.Copy(data.Scan0, datasOld, 0, datasOld.Length);
    for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
    {
        for (int x = 0; x < image.Width * 3; x += 3)
        {
            int xNew = x / 3, yNew = y / data.Stride;
            int xOld = (int)(xNew / horizon);
            int yOld = (int)(yNew / verticale);
            if (xOld < 0 || xOld >= image.Width
                || yOld < 0 || yOld >= image.Height) continue;
            int indexOld = yOld * data.Stride + xOld * 3;
            int indexNew = y + x;

            datasNew[indexNew] = datasNew[indexNew + 1] = datasNew[indexNew + 2] = datasOld[indexOld];
        }
    }
    Marshal.Copy(datasNew, 0, data.Scan0, datasOld.Length);       //将图像数组复制到内存中
    image.UnlockBits(data);                                 //将图像从内存中解锁
}
//平移
public static void Translation(Bitmap image, float horizon, float verticale)
{

    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//将图像锁定到内存中
    byte[] datasOld = new byte[data.Stride * image.Height];    //图像数组
    byte[] datasNew = new byte[data.Stride * image.Height];    //图像数组
    //将图像在内存中的数据复制到图像数组中
    Marshal.Copy(data.Scan0, datasOld, 0, datasOld.Length);
    for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
    {
        for (int x = 0; x < image.Width * 3; x += 3)
        {
            int xNew = x / 3, yNew = y / data.Stride;
            int xOld = (int)(xNew - horizon);
            int yOld = (int)(yNew - verticale);
            if (xOld < 0 || xOld >= image.Width
                || yOld < 0 || yOld >= image.Height) continue;
            int indexOld = yOld * data.Stride + xOld * 3;
            int indexNew = y + x;
            datasNew[indexNew] = datasNew[indexNew + 1] = datasNew[indexNew + 2] = datasOld[indexOld];
        }
    }
    Marshal.Copy(datasNew, 0, data.Scan0, datasOld.Length);       //将图像数组复制到内存中
    image.UnlockBits(data);                                 //将图像从内存中解锁
}
//旋转
public static void Rotation(Bitmap image, float angle, Point center)
{
    BitmapData data = image.LockBits(new Rectangle(new Point(), image.Size), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);//将图像锁定到内存中
    byte[] datasOld = new byte[data.Stride * image.Height];    //图像数组
    byte[] datasNew = new byte[data.Stride * image.Height];    //图像数组
    Marshal.Copy(data.Scan0, datasOld, 0, datasOld.Length);       //将图像在内存中的数据复制到图像数组中
    for (int y = 0; y < image.Height * data.Stride; y += data.Stride)
    {
        for (int x = 0; x < image.Width * 3; x += 3)
        {
            int xNew = x / 3, yNew = y / data.Stride;
            int xOld = (int)((xNew - center.X) * Math.Cos(angle * Math.PI / 180)
                - (yNew - center.Y) * Math.Sin(angle * Math.PI / 180) + center.X);
            int yOld = (int)((xNew - center.X) * Math.Sin(angle * Math.PI / 180)
                + (yNew - center.Y) * Math.Cos(angle * Math.PI / 180) + center.Y);
            if (xOld < 0 || xOld >= image.Width
                || yOld < 0 || yOld >= image.Height) continue;
            int indexOld = yOld * data.Stride + xOld * 3;
            int indexNew = y + x;
            datasNew[indexNew] = datasNew[indexNew + 1] = datasNew[indexNew + 2] = datasOld[indexOld];
        }
    }
    Marshal.Copy(datasNew, 0, data.Scan0, datasOld.Length);       //将图像数组复制到内存中
    image.UnlockBits(data);                                 //将图像从内存中解锁
}

        //离散傅立叶变换
        public static void DiscreteFourierTransform(Bitmap image)
        {
        }

        //逆离散傅立叶变换
        public static void InverseDiscreteFourierTransform(Bitmap image)
        {
        }
    }
}
