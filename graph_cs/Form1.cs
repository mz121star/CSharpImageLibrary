using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

using System.Text;

using System.Windows.Forms;
using ImageLibrary;
namespace graph_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ImagePath;
        private void btn_OpenImage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePath = openFileDialog1.FileName;

                ViewImage();
            }

        }
        private void ViewImage()
        {
            Image img = Image.FromFile(ImagePath);
            Bitmap bitmap = new Bitmap(img);
            befor_pic.Image = bitmap;
        }


        private void btn_ImageGray_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(ImagePath);
            Bitmap bitmap = new Bitmap(img);
            after_pic.Image = ImageLibrary.Gray.GrayScale(bitmap, 2);
        }

        private void btn_ImageGray2_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(ImagePath);
            Bitmap bitmap = new Bitmap(img);
            after_pic.Image = ImageLibrary.Gray.GrayScale(bitmap, 1);
        }

        private void btn_ImageGray3_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(ImagePath);
            Bitmap bitmap = new Bitmap(img);
            after_pic.Image = ImageLibrary.Gray.GrayScale(bitmap, 3);
        }

        private void btn_binary_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(ImagePath);
            Bitmap bitmap = new Bitmap(img);
            var image = ImageLibrary.Gray.GrayScale(bitmap, 2);
            after_pic.Image = ImageLibrary.Gray.BinaryZation(image, int.Parse(txtthreshold.Text));
        }



        private void btn_pixelImage_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(ImagePath);
            Bitmap bitmap = new Bitmap(img);
            var image = ImageLibrary.Gray.GrayScale(bitmap, 2);
            var BinaryImage = ImageLibrary.Gray.BinaryZation(image, int.Parse(txtthreshold.Text));
            var resultArray = ImageLibrary.Gray.PixelImage(BinaryImage);


            richTextBox1.Text = ImageLibrary.Util.EachArrayToString(resultArray);
        }


        private void btn_cut_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(ImagePath);
            Bitmap bitmap = new Bitmap(img);
            var image = ImageLibrary.Gray.GrayScale(bitmap, 2);
            var BinaryImage = ImageLibrary.Gray.BinaryZation(image, int.Parse(txtthreshold.Text));
            var resultArray = ImageLibrary.Gray.PixelImage(BinaryImage);

            richTextBox1.Text = ImageLibrary.Util.GetValidRegion(resultArray);

        }

        private void btn_histogram_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(ImagePath);
            Bitmap bitmap = new Bitmap(img);

            var histogramArray = ImageLibrary.Gray.GrayScaleHistogram(ImageLibrary.Gray.GrayScale(bitmap, 2));


            Graphics g = pic_histogram.CreateGraphics();
          
            Color red = Color.FromArgb(0, 0, 0);
            Pen blackPen = new Pen(red, 1);
            for (int i = 0; i < histogramArray.Length; i++)
            {
                Point point1 = new Point(i, 0); //坐标（100，100）
                Point point2 = new Point(i, histogramArray[i]  ); //坐标（500，100）
                g.DrawLine(blackPen, point1, point2); //两个坐标连成直线
            }
           

        }

        private void btn_denoise_Click(object sender, EventArgs e)
        {
            
            after_pic.Image = ImageLibrary.Gray.NoiseReduction((Bitmap)after_pic.Image);
        }
    }
}
