using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;

namespace _19021414.Forms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        Mat img = new Mat();
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = file.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            img = Cv2.ImRead(pathBox.Text);
            pictureBox1.Image = img.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(sf.FileName, ImageFormat.Jpeg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mat imggray_sobel = new Mat();
            Cv2.CvtColor(img, imggray_sobel, ColorConversionCodes.BGR2GRAY);
            Mat imgsobel = new Mat();
            Cv2.Sobel(imggray_sobel, imgsobel, -1, 1, 0);
            pictureBox2.Image = imgsobel.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mat imggray_sobel = new Mat();
            Cv2.CvtColor(img, imggray_sobel, ColorConversionCodes.BGR2GRAY);
            Mat imgsobel = new Mat();
            Cv2.Canny(imggray_sobel, imgsobel, 100, 200, 5);
            pictureBox2.Image = imgsobel.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnGauss_Click_1(object sender, EventArgs e)
        {
            Mat imggray_gauss = new Mat();
            Cv2.CvtColor(img, imggray_gauss, ColorConversionCodes.BGR2GRAY);
            Mat imgGauss = new Mat();
            Cv2.GaussianBlur(imggray_gauss, imgGauss, new OpenCvSharp.Size(3, 3), 1);
            pictureBox2.Image = imgGauss.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnLaplaceS_Click(object sender, EventArgs e)
        {
            Mat imggray_gauss = new Mat();
            Cv2.CvtColor(img, imggray_gauss, ColorConversionCodes.BGR2GRAY);
            Mat imgLap = new Mat();
            Cv2.Laplacian(imggray_gauss, imgLap, MatType.CV_16SC1, 3, 1, 0, BorderTypes.Default);
            Cv2.ConvertScaleAbs(imgLap, imgLap, 1, 0);
            pictureBox2.Image = imgLap.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
