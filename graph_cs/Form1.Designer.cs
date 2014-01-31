namespace graph_cs
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_OpenImage = new System.Windows.Forms.Button();
            this.befor_pic = new System.Windows.Forms.PictureBox();
            this.after_pic = new System.Windows.Forms.PictureBox();
            this.btn_ImageGray1 = new System.Windows.Forms.Button();
            this.btn_ImageGray2 = new System.Windows.Forms.Button();
            this.btn_ImageGray3 = new System.Windows.Forms.Button();
            this.btn_binary = new System.Windows.Forms.Button();
            this.txtthreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_pixelImage = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.btn_histogram = new System.Windows.Forms.Button();
            this.pic_histogram = new System.Windows.Forms.PictureBox();
            this.btn_denoise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.befor_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.after_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "图片文件(*.jpg,*.bmp,*.png)|*.jpg;*.bmp";
            // 
            // btn_OpenImage
            // 
            this.btn_OpenImage.Location = new System.Drawing.Point(25, 35);
            this.btn_OpenImage.Name = "btn_OpenImage";
            this.btn_OpenImage.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenImage.TabIndex = 0;
            this.btn_OpenImage.Text = "Open Image";
            this.btn_OpenImage.UseVisualStyleBackColor = true;
            this.btn_OpenImage.Click += new System.EventHandler(this.btn_OpenImage_Click);
            // 
            // befor_pic
            // 
            this.befor_pic.Location = new System.Drawing.Point(121, 21);
            this.befor_pic.Name = "befor_pic";
            this.befor_pic.Size = new System.Drawing.Size(298, 146);
            this.befor_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.befor_pic.TabIndex = 1;
            this.befor_pic.TabStop = false;
            // 
            // after_pic
            // 
            this.after_pic.Location = new System.Drawing.Point(500, 21);
            this.after_pic.Name = "after_pic";
            this.after_pic.Size = new System.Drawing.Size(266, 146);
            this.after_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.after_pic.TabIndex = 2;
            this.after_pic.TabStop = false;
            // 
            // btn_ImageGray1
            // 
            this.btn_ImageGray1.Location = new System.Drawing.Point(25, 65);
            this.btn_ImageGray1.Name = "btn_ImageGray1";
            this.btn_ImageGray1.Size = new System.Drawing.Size(75, 23);
            this.btn_ImageGray1.TabIndex = 3;
            this.btn_ImageGray1.Text = "YUV变灰";
            this.btn_ImageGray1.UseVisualStyleBackColor = true;
            this.btn_ImageGray1.Click += new System.EventHandler(this.btn_ImageGray_Click);
            // 
            // btn_ImageGray2
            // 
            this.btn_ImageGray2.Location = new System.Drawing.Point(25, 95);
            this.btn_ImageGray2.Name = "btn_ImageGray2";
            this.btn_ImageGray2.Size = new System.Drawing.Size(90, 23);
            this.btn_ImageGray2.TabIndex = 4;
            this.btn_ImageGray2.Text = "取平均值变灰";
            this.btn_ImageGray2.UseVisualStyleBackColor = true;
            this.btn_ImageGray2.Click += new System.EventHandler(this.btn_ImageGray2_Click);
            // 
            // btn_ImageGray3
            // 
            this.btn_ImageGray3.Location = new System.Drawing.Point(25, 125);
            this.btn_ImageGray3.Name = "btn_ImageGray3";
            this.btn_ImageGray3.Size = new System.Drawing.Size(90, 23);
            this.btn_ImageGray3.TabIndex = 5;
            this.btn_ImageGray3.Text = "取最小值变灰";
            this.btn_ImageGray3.UseVisualStyleBackColor = true;
            this.btn_ImageGray3.Click += new System.EventHandler(this.btn_ImageGray3_Click);
            // 
            // btn_binary
            // 
            this.btn_binary.Location = new System.Drawing.Point(25, 196);
            this.btn_binary.Name = "btn_binary";
            this.btn_binary.Size = new System.Drawing.Size(75, 23);
            this.btn_binary.TabIndex = 6;
            this.btn_binary.Text = "二值化";
            this.btn_binary.UseVisualStyleBackColor = true;
            this.btn_binary.Click += new System.EventHandler(this.btn_binary_Click);
            // 
            // txtthreshold
            // 
            this.txtthreshold.Location = new System.Drawing.Point(61, 223);
            this.txtthreshold.Name = "txtthreshold";
            this.txtthreshold.Size = new System.Drawing.Size(39, 21);
            this.txtthreshold.TabIndex = 7;
            this.txtthreshold.Text = "127";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "阈值：";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(25, 461);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "识别";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(121, 284);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1077, 331);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btn_pixelImage
            // 
            this.btn_pixelImage.Location = new System.Drawing.Point(25, 349);
            this.btn_pixelImage.Name = "btn_pixelImage";
            this.btn_pixelImage.Size = new System.Drawing.Size(75, 21);
            this.btn_pixelImage.TabIndex = 12;
            this.btn_pixelImage.Text = "生成像素图";
            this.btn_pixelImage.UseVisualStyleBackColor = true;
            this.btn_pixelImage.Click += new System.EventHandler(this.btn_pixelImage_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.Location = new System.Drawing.Point(25, 386);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(90, 23);
            this.btn_cut.TabIndex = 13;
            this.btn_cut.Text = "截取内容区域";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.btn_cut_Click);
            // 
            // btn_histogram
            // 
            this.btn_histogram.Location = new System.Drawing.Point(25, 155);
            this.btn_histogram.Name = "btn_histogram";
            this.btn_histogram.Size = new System.Drawing.Size(75, 23);
            this.btn_histogram.TabIndex = 14;
            this.btn_histogram.Text = "直方图";
            this.btn_histogram.UseVisualStyleBackColor = true;
            this.btn_histogram.Click += new System.EventHandler(this.btn_histogram_Click);
            // 
            // pic_histogram
            // 
            this.pic_histogram.Location = new System.Drawing.Point(800, 21);
            this.pic_histogram.Name = "pic_histogram";
            this.pic_histogram.Size = new System.Drawing.Size(410, 257);
            this.pic_histogram.TabIndex = 15;
            this.pic_histogram.TabStop = false;
            // 
            // btn_denoise
            // 
            this.btn_denoise.Location = new System.Drawing.Point(25, 255);
            this.btn_denoise.Name = "btn_denoise";
            this.btn_denoise.Size = new System.Drawing.Size(75, 23);
            this.btn_denoise.TabIndex = 16;
            this.btn_denoise.Text = "降噪";
            this.btn_denoise.UseVisualStyleBackColor = true;
            this.btn_denoise.Click += new System.EventHandler(this.btn_denoise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 626);
            this.Controls.Add(this.btn_denoise);
            this.Controls.Add(this.pic_histogram);
            this.Controls.Add(this.btn_histogram);
            this.Controls.Add(this.btn_cut);
            this.Controls.Add(this.btn_pixelImage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtthreshold);
            this.Controls.Add(this.btn_binary);
            this.Controls.Add(this.btn_ImageGray3);
            this.Controls.Add(this.btn_ImageGray2);
            this.Controls.Add(this.btn_ImageGray1);
            this.Controls.Add(this.after_pic);
            this.Controls.Add(this.befor_pic);
            this.Controls.Add(this.btn_OpenImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.befor_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.after_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_OpenImage;
        private System.Windows.Forms.PictureBox befor_pic;
        private System.Windows.Forms.PictureBox after_pic;
        private System.Windows.Forms.Button btn_ImageGray1;
        private System.Windows.Forms.Button btn_ImageGray2;
        private System.Windows.Forms.Button btn_ImageGray3;
        private System.Windows.Forms.Button btn_binary;
        private System.Windows.Forms.TextBox txtthreshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_pixelImage;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Button btn_histogram;
        private System.Windows.Forms.PictureBox pic_histogram;
        private System.Windows.Forms.Button btn_denoise;
    }
}

