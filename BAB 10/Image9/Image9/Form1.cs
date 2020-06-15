using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image9
{
    public partial class Form1 : Form
    {
        Bitmap objBitmap;
        Bitmap objBitmap1;
        Bitmap objBitmap2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            objBitmap2 = new Bitmap(objBitmap1); 
            for (int x = 1; x < objBitmap.Width - 1; x++) 
                for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap1.GetPixel(x - 1, y - 1); Color w2 = objBitmap1.GetPixel(x - 1, y);
                    Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap1.GetPixel(x, y - 1); Color w5 = objBitmap1.GetPixel(x, y);
                    Color w6 = objBitmap1.GetPixel(x, y + 1);
                    Color w7 = objBitmap1.GetPixel(x + 1, y - 1); Color w8 = objBitmap1.GetPixel(x + 1, y); Color w9 = objBitmap1.GetPixel(x + 1, y + 1);
                    int x1 = w1.R; int x2 = w2.R; int x3 = w3.R; int x4 = w4.R; int x5 = w5.R; int x6 = w6.R; int x7 = w7.R; int x8 = w8.R; int x9 = w9.R;
                    int xb = (int)((x1 + x2 + x3 + x4 + x5 + x6 +
               x7 + x8 + x9) / 9);
                    if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb);
                    objBitmap2.SetPixel(x, y, wb);
                }
            pictureBox3.Image = objBitmap2;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            objBitmap2 = new Bitmap(objBitmap1); for (int x = 1; x < objBitmap.Width - 1; x++) for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap1.GetPixel(x - 1, y - 1); Color w2 = objBitmap1.GetPixel(x - 1, y);
                    Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap1.GetPixel(x, y - 1);
                    Color w5 = objBitmap1.GetPixel(x, y);
                    Color w6 = objBitmap1.GetPixel(x, y + 1);
                    Color w7 = objBitmap1.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap1.GetPixel(x + 1, y); Color w9 = objBitmap1.GetPixel(x + 1, y + 1); int x1 = w1.R;
                    int x2 = w2.R; int x3 = w3.R; int x4 = w4.R; int x5 = w5.R; int x6 = w6.R; int x7 = w7.R; int x8 = w8.R; int x9 = w9.R;
                    int xb = (int)((x1 + x2 + x3 + x4 + 4 * x5 + x6
                    + x7 + x8 + x9) / 13); if (xb < 0) xb = 0; if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb); objBitmap2.SetPixel(x, y, wb);
                }
            pictureBox3.Image = objBitmap2;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] xt = new int[10]; objBitmap2 = new Bitmap(objBitmap1); 
            for (int x = 1; x < objBitmap.Width - 1; x++) 
                for (int y = 1; y < objBitmap.Height - 1; y++){
                Color w1 = objBitmap1.GetPixel(x - 1, y - 1);
                Color w2 = objBitmap1.GetPixel(x - 1, y);
                Color w3 = objBitmap1.GetPixel(x - 1, y + 1);
                Color w4 = objBitmap1.GetPixel(x, y - 1);
                Color w5 = objBitmap1.GetPixel(x, y);
                Color w6 = objBitmap1.GetPixel(x, y + 1);
                Color w7 = objBitmap1.GetPixel(x + 1, y - 1); 
                Color w8 = objBitmap1.GetPixel(x + 1, y); 
                Color w9 = objBitmap1.GetPixel(x + 1, y + 1); xt[1] = w1.R; xt[2] = w2.R; xt[3] = w3.R; xt[4] = w4.R; xt[5] = w5.R; xt[6] = w6.R; xt[7] = w7.R; xt[8] = w8.R; xt[9] = w9.R; for (int i = 1; i < 9; i++) for (int j = 1; j < 9; j++)
                    {
                        if (xt[j] > xt[j + 1])
                        {
                            int a = xt[j]; xt[j] = xt[j + 1]; xt[j + 1] = a;
                        }
                    }

                int xb = xt[5];
                Color wb = Color.FromArgb(xb, xb, xb); objBitmap2.SetPixel(x, y, wb);
            }
            pictureBox3.Image = objBitmap2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog(); if (d == DialogResult.OK)
            {
                objBitmap = new Bitmap(openFileDialog1.FileName); pictureBox1.Image = objBitmap;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < objBitmap.Width; x++) for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y); int r = w.R; int g = w.G; int b = w.B; int xg = (int)((r + g + b) / 3); Color wb = Color.FromArgb(xg, xg, xg); objBitmap.SetPixel(x, y, wb);
                }
            pictureBox1.Image = objBitmap;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap); Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++) for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y); int xg = w.R; int xb = xg; int nr = r.Next(0, 100); if (nr < 20)
                    {
                        int ns = r.Next(0, 256) - 128; xb = (int)(xg + ns); if (xb < 0) xb = -xb; if (xb > 255) xb = 255;
                    }
                    Color wb = Color.FromArgb(xb, xb, xb); objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap); Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++) for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y); int xg = w.R; int xb = xg; int nr = r.Next(0, 100); if (nr < 20) xb = 0;
                    Color wb = Color.FromArgb(xb, xb, xb); objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            objBitmap1 = new Bitmap(objBitmap); Random r = new Random();
            for (int x = 0; x < objBitmap.Width; x++) for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y); int xg = w.R; int xb = xg; int nr = r.Next(0, 100); if (nr < 20) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb); objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;

        }
    }
}
