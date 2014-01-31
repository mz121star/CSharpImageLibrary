using System;
using System.Collections.Generic;
using System.Drawing;

using System.Text;
 

namespace ImageLibrary
{
   public  class Gray
    {
        /// <summary>
        /// 图像灰度化
        /// </summary>
        /// <param name="srcImage">图片</param>
        /// <param name="m">1，平均值 2，YUC 3，最小值</param>
        /// <returns></returns>
        public static Bitmap GrayScale(Bitmap srcImage, int m)
        {
            var image = srcImage;
            int width = image.Width - 1;
            int height = image.Height - 1;

            Color color;
            for (int i = width; i >= 0; i--)
            {
                for (int j = height; j >= 0; j--)
                {
                    int gray;
                    //读取每一个像素
                    color = image.GetPixel(i, j);        //计算灰度值 
                    if (m == 1)
                    {
                         gray = (int)((color.R+ color.G  + color.B)/3 ); 
                    }
                    if (m == 2)
                    {
                         gray = (int)(color.B * 0.3 + color.G * 0.59 + color.R * 0.11);   
                    }
                    else
                    {
                        gray = (int)(Math.Min(Math.Min(color.R, color.G), color.B));    
                    }
                    
                    //int gray = (color.R + color.G + color.B) / 3;
                    Color colorResult = Color.FromArgb(255, gray, gray, gray);
                    //设置像素为灰度
                    image.SetPixel(i, j, colorResult);
                }
            }
            return image;
        }
       /// <summary>
       /// 生成灰度直方图（范围为0-255）
       /// </summary>
       /// <param name="sBitmap">灰度化之后的图像</param>
       /// <returns></returns>
        public static int[] GrayScaleHistogram(Bitmap srcImage)
       {
           int[] histogram=new int[256];
           var image = srcImage;
           int width = image.Width - 1;
           int height = image.Height - 1;

           Color color;
           for (int i = width; i >= 0; i--)
           {
               for (int j = height; j >= 0; j--)
               {

                   color = image.GetPixel(i, j);        //计算灰度值 
                   histogram[color.R]++;

               }
           }
           return histogram;

       }
       /// <summary>
       /// 二值化
       /// </summary>
       /// <param name="srcImage"></param>
       /// <param name="threshold">阈值</param>
       /// <returns></returns>
        public static Bitmap BinaryZation(Bitmap srcImage, int threshold)
        {
            var image = srcImage;
            int width = image.Width - 1;
            int height = image.Height - 1;

            Color color;
            for (int i = width; i >= 0; i--)
            {
                for (int j = height; j >= 0; j--)
                {
                    
                    color = image.GetPixel(i, j);        //计算灰度值 
                    Color colorResult;
                    if (color.R > threshold)
                    {
                          colorResult = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        colorResult = Color.FromArgb(0, 0, 0); 
                    }
                    //设置像素为灰度
                    image.SetPixel(i, j, colorResult);
                }
            }
            return image;
        }
       /// <summary>
       /// 中值滤波降噪
       /// </summary>
       /// <param name="srcImage"></param>
       /// <returns></returns>
       public static Bitmap NoiseReduction(Bitmap srcImage)
       {
           var image = srcImage;
           int width = image.Width - 1;
           int height = image.Height - 1;
           int count = 0;
           Color color;
           for (int i = 0; i <width; i++)
           {
               for (int j =0;  j <=height; j++)
               {
                   count = 0;
                   color = image.GetPixel(i, j);        //计算灰度值 
                   Color colorResult;
                   if (i > 0 && j > 0)
                   {
                       try
                       {
                           count = image.GetPixel(i - 1, j - 1).R + image.GetPixel(i, j - 1).R +
                                   image.GetPixel(i + 1, j - 1).R
                                   + image.GetPixel(i - 1, j).R + image.GetPixel(i + 1, j).R
                                   + image.GetPixel(i - 1, j + 1).R + image.GetPixel(i, j + 1).R +
                                   image.GetPixel(i + 1, j + 1).R;
                       }
                       catch (Exception)
                       {

                       }

                       if (count == 2040)
                       {
                           colorResult = Color.FromArgb(255, 255, 255);
                           image.SetPixel(i, j, colorResult);
                       }
                   }
                   //设置像素为灰度
                 
               }
           }
           return image;
       }
     /// <summary>
     /// 生成文字图形（srcImage必须为二值化后的图像）
     /// </summary>
     /// <param name="srcImage"></param>
     /// <returns></returns>
       public static int[,] PixelImage(Bitmap srcImage)
       {
           var image = srcImage;
           int width = image.Width - 1;
           int height = image.Height - 1;
           StringBuilder stringBuilder = new StringBuilder();
           Color color;
           var imagearray = new int[height,width];

           for (int i = 0; i < height; i++)
           {
               for (int j =0;j< width;  j++)
               {

                   color = image.GetPixel(j,i);        //计算灰度值 
                    
                   //设置像素为灰度
                   var v = color.R == 255 ? 1 : 0;
                   stringBuilder.Append(v);
                   imagearray[i, j] = v;
               }
               stringBuilder.Append("\r");
           }
           return imagearray;

       }
       
    }
}
