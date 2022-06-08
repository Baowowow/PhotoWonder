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
    public partial class Form2 : Form
    {
        public Form2()
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
        private void pathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBut_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = RGB[0].ToBitmap();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = file.FileName;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            img = Cv2.ImRead(pathBox.Text);
            pictureBox1.Image = img.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Mat img_gray = new Mat();
            Cv2.CvtColor(img, img_gray, ColorConversionCodes.BGR2GRAY);
            pictureBox2.Image = img_gray.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
        Mat[] RGB = new Mat[3];
        private void btnRGB_Click(object sender, EventArgs e)
        {
            RGB = Cv2.Split(img);
            RBut.Enabled = true;
            Gbut.Enabled = true;
            Bbut.Enabled = true;
            RGBbut.Enabled = true;
            pictureBox2.Image = img.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Gbut_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = RGB[1].ToBitmap();
        }

        private void Bbut_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = RGB[2].ToBitmap();
        }

        private void btnInvert_Click_1(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                new float[] {-1, 0, 0, 0, 0},
                new float[] {0, -1, 0, 0, 0},
                new float[] {0, 0, -1, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {1, 0, 0, 0, 1},
            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmpInverted);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox2.Image = bmpInverted;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(sf.FileName, ImageFormat.Jpeg);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }  
}
