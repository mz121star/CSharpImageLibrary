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
       
    }
}
