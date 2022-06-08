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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void btnSave_Click(object sender, EventArgs e)
        {
             SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image.Save(sf.FileName, ImageFormat.Jpeg);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        float gma = 0;
        private void GammaBar_Scroll(object sender, EventArgs e)
        {
            label1.Text = GammaBar.Value.ToString();
            float value1 = 0.4f;
            gma = value1 * GammaBar.Value / 10;
            Bitmap bm = img.ToBitmap();
            Graphics g = Graphics.FromImage(bm);
            ImageAttributes ia = new ImageAttributes();

            ia.SetGamma(gma);
            Bitmap newBitmap = img.ToBitmap();
            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, ia);

            ///g.Dispose();
            ///ia.Dispose();
            pictureBox2.Image = bm;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
        int Value = 0;
        Bitmap newBitmap;
        public Bitmap AdjustBrightness(Bitmap Image, int Value)
        {
            Bitmap TempBitmap = img.ToBitmap();

            float FinalValue = (float)Value / 255.0f;

            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);

            Graphics NewGraphics = Graphics.FromImage(NewBitmap);

            float[][] FloatColorMatrix = {
                new float[] {1,0,0,0,0},
                new float[] {0,1,0,0,0},
                new float[] {0,0,1,0,0},
                new float[] {0,0,0,1,0},
                new float[] {FinalValue, FinalValue, FinalValue, 1, 1}

            };
            System.Drawing.Imaging.ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

            System.Drawing.Imaging.ImageAttributes Attributes = new ImageAttributes();

            Attributes.SetColorMatrix(NewColorMatrix);

            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);

            Attributes.Dispose();

            NewGraphics.Dispose();

            return NewBitmap;

        }
        private void BrightnessBar_Scroll(object sender, EventArgs e)
        {
            label2.Text = BrightnessBar.Value.ToString();
            pictureBox2.Image = AdjustBrightness(newBitmap, BrightnessBar.Value);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
        float contrast = 0;
        private void ContrastBar_Scroll(object sender, EventArgs e)
        {
            label3.Text = ContrastBar.Value.ToString();
            float contrast = 0.04f * ContrastBar.Value;
            Bitmap bm1 = img.ToBitmap();
            Graphics g1 = Graphics.FromImage(bm1);
            ImageAttributes ia1 = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix(new float[][]
            {   new float[] { contrast, 0f, 0f, 0f, 0f },
                new float[] { 0f, contrast, 0f, 0f, 0f },
                new float[] { 0f, 0f, contrast, 0f, 0f },
                new float[] { 0f, 0f, 0f, 1f, 0f },
                new float[] { 0.001f, 0.001f, 0.001f, 0f, 1f}
            });
            ia1.SetColorMatrix(cm);
            Bitmap newBitmap = img.ToBitmap();
            g1.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, ia1);
            g1.Dispose();
            ia1.Dispose();
            pictureBox2.Image = bm1;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
