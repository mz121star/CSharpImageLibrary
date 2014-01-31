using System;
using System.Collections.Generic;
using System.Text;

namespace ImageLibrary
{
    public class Util
    {
        /// <summary>
        /// 把像素数组转为像素的字符串（可视化字符串）
        /// </summary>
        /// <param name="resultArray"></param>
        /// <returns></returns>
        public static string EachArrayToString(int[,] resultArray)
        {
            StringBuilder result=new StringBuilder( );
            var h = resultArray.GetLength(0);
            var w = resultArray.GetLength(1);
            for (var i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    result.Append(resultArray[i, j]);
                }
                result.Append("\r");
            }
            return result.ToString();
        }


        public static string GetValidRegion(int[,] resultArray)
        {
            StringBuilder result = new StringBuilder();
            var h = resultArray.GetLength(0);
            var w = resultArray.GetLength(1);
            for (var i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    result.Append(resultArray[i, j]);
                }
                result.Append("\r");
            }
            return result.ToString();
        }
    }
}
