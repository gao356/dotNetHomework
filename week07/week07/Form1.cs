using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            try
            {
                n_ = Int32.Parse(depth.Text);
                leng_ = Double.Parse(length.Text);
                per1_ = Double.Parse(per_1.Text);
                per2_ = Double.Parse(per_2.Text);
                th1_ = Double.Parse(th_1.Text);
                th2_ = Double.Parse(th_2.Text);
                color_ = c.Text;
            }
            catch (Exception excpetion)
            {
                n_ = 10;
                leng_ = 200;
                per1_ = 0.5;
                per2_ = 0.5;
                th1_ = 0.5;
                th2_ = 0.5;
                color_ = "black";
            }

            if (graphics == null) graphics = panel1.CreateGraphics();
            DrawCayLeyTree(n_, 300, 460, leng_, -Math.PI / 2);
        }

        private Graphics graphics;
        private int n_;
        private double per1_;
        private double per2_;
        private double leng_;
        private double th1_;
        private double th2_;
        private string color_;

        void DrawCayLeyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayLeyTree(n - 1, x1, y1, per1_ * leng, th + th1_);
            DrawCayLeyTree(n - 1, x1, y1, per2_ * leng, th - th2_);
        }

        void DrawLine(double x0, double y0, double x1, double y1) 
        {
            if (color_.Equals("red")) graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
            if (color_.Equals("green")) graphics.DrawLine(Pens.Green, (int)x0, (int)y0, (int)x1, (int)y1);
            if (color_.Equals("blue")) graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
            else graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
