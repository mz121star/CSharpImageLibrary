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
        
        private void btn_start_Click(object sender, EventArgs e)
        {

           /* tessnet2.Tesseract ocr = new tessnet2.Tesseract();//声明一个OCR类
            ocr.SetVariable("tessedit_char_whitelist", "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"); //设置识别变量，当前只能识别数字。
            ocr.Init(Application.StartupPath + @"\\tmpe", "eng", true); //应用当前语言包。注，Tessnet2是支持多国语的。语言包下载链接：http://code.google.com/p/tesseract-ocr/downloads/list
            Bitmap bitmap = new Bitmap(after_pic.Image);
            List<tessnet2.Word> result = ocr.DoOCR(bitmap, Rectangle.Empty);//执行识别操作
            string code = result[0].Text;
            label2.Text = code;*/
        }
    }
}
