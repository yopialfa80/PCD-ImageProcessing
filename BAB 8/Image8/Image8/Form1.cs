﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image8
{
    public partial class Form1 : Form
    {
        Bitmap objBitmap1;
        Bitmap objBitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            pictureBox2.Image = objBitmap;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float[] a = new float[5]; a[1] = (float)0.2; a[2] = (float)0.2; a[3] = (float)0.2; a[4] = (float)0.2; a[0] = (float)0.2;
            objBitmap1 = new Bitmap(objBitmap); for (int x = 1; x < objBitmap.Width - 1; x++) for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y); Color w2 = objBitmap.GetPixel(x + 1, y); Color w3 = objBitmap.GetPixel(x, y - 1);
                    Color w4 = objBitmap.GetPixel(x, y + 1); Color w = objBitmap.GetPixel(x, y); int x1 = w1.R; int x2 = w2.R; int x3 = w3.R;
                    int x4 = w4.R;
                    int xg = w.R; int xb = (int)(a[0] * xg);
                    xb = (int)(xb + a[1] * x1 + a[2] * x2 + a[3] * x3 + a[3] * x4); if (xb < 0) xb = 0;
                    if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb); objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float[] a = new float[10]; a[1] = (float)0.1; a[2] = (float)0.1; a[3] = (float)0.1; a[4] = (float)0.1; a[5] = (float)0.2; a[6] = (float)0.1; a[7] = (float)0.1; a[8] = (float)0.1; a[9] = (float)0.1;
            objBitmap1 = new Bitmap(objBitmap); for (int x = 1; x < objBitmap.Width - 1; x++) for (int y = 1; y < objBitmap.Height - 1; y++)
                {
                    Color w1 = objBitmap.GetPixel(x - 1, y - 1); Color w2 = objBitmap.GetPixel(x - 1, y);
                    Color w3 = objBitmap.GetPixel(x - 1, y + 1);
                    Color w4 = objBitmap.GetPixel(x, y - 1); Color w5 = objBitmap.GetPixel(x, y);
                    Color w6 = objBitmap.GetPixel(x, y + 1);
                    Color w7 = objBitmap.GetPixel(x + 1, y - 1);
                    Color w8 = objBitmap.GetPixel(x + 1, y); Color w9 = objBitmap.GetPixel(x + 1, y + 1); int x1 = w1.R; int x2 = w2.R; int x3 = w3.R; int x4 = w4.R; int x5 = w5.R; int x6 = w6.R; int x7 = w7.R; int x8 = w8.R; int x9 = w9.R; int xb = (int)(a[1] * x1 + a[2] * x2 + a[3] * x3); xb = (int)(xb + a[4] * x4 + a[5] * x5 + a[6] * x6); xb = (int)(xb + a[7] * x7 + a[8] * x8 + a[9] * x9); if (xb < 0) xb = 0; if (xb > 255) xb = 255;
                    Color wb = Color.FromArgb(xb, xb, xb); objBitmap1.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap1;

        }
    }
}
