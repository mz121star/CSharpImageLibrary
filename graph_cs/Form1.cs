using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        private void btn_OpenImage_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                Image img = Image.FromFile(openFileDialog1.FileName);

                Bitmap bitmap = new Bitmap(img);
                befor_pic.Image = bitmap;
                
            }

        }

      

        private void btn_ImageGray_Click(object sender, EventArgs e)
        {
            after_pic.Image =ImageLibrary.Gray.GrayScale((Bitmap)befor_pic.Image,2);
        }

        private void btn_ImageGray2_Click(object sender, EventArgs e)
        {
            after_pic.Image = ImageLibrary.Gray.GrayScale((Bitmap)befor_pic.Image, 1);
        }

        private void btn_ImageGray3_Click(object sender, EventArgs e)
        {
            after_pic.Image = ImageLibrary.Gray.GrayScale((Bitmap)befor_pic.Image, 3);
        }

        private void btn_binary_Click(object sender, EventArgs e)
        {
            var image = ImageLibrary.Gray.GrayScale((Bitmap)befor_pic.Image, 2);
            after_pic.Image = ImageLibrary.Gray.BinaryZation(image, int.Parse(txtthreshold.Text));
        }
    }
}
