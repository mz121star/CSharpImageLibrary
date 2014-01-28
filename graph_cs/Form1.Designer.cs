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
            ((System.ComponentModel.ISupportInitialize)(this.befor_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.after_pic)).BeginInit();
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
            this.befor_pic.Size = new System.Drawing.Size(357, 234);
            this.befor_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.befor_pic.TabIndex = 1;
            this.befor_pic.TabStop = false;
            // 
            // after_pic
            // 
            this.after_pic.Location = new System.Drawing.Point(121, 270);
            this.after_pic.Name = "after_pic";
            this.after_pic.Size = new System.Drawing.Size(357, 289);
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
            this.txtthreshold.Location = new System.Drawing.Point(51, 226);
            this.txtthreshold.Name = "txtthreshold";
            this.txtthreshold.Size = new System.Drawing.Size(49, 21);
            this.txtthreshold.TabIndex = 7;
            this.txtthreshold.Text = "127";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "阈值：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 626);
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
    }
}

