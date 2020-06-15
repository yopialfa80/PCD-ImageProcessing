﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image7
{
    public partial class Form1 : Form
    {
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
            float[] h = new float[256]; float[] c = new float[256]; int i;
            for (i = 0; i < 256; i++) h[i] = 0; for (int x = 0; x < objBitmap.Width; x++) for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y); int xg = w.R; h[xg] = h[xg] + 1;
                }
            c[0] = h[0];
            for (i = 1; i < 256; i++) c[i] = c[i - 1] + h[i]; int nx = objBitmap.Width; int ny = objBitmap.Height; for (int x = 0; x < objBitmap.Width; x++) for (int y = 0; y < objBitmap.Height; y++)
                {
                    Color w = objBitmap.GetPixel(x, y); int xg = w.R; int xb = (int)(255 * c[xg] / nx / ny); Color wb = Color.FromArgb(xb, xb, xb); objBitmap.SetPixel(x, y, wb);
                }
            pictureBox2.Image = objBitmap;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
