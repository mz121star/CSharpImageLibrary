using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            var result=ImageLibrary.Gray.PixelImage(BinaryImage);
            richTextBox1.Text = result;
        }
    }
}
