using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private Graphics graphics;

        int num = 0;
        double length = 0;
        Pen pen;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        private void n_TextChanged(object sender, EventArgs e)
        {
            num = Convert.ToInt32(n.Text);
        }

        private void leng_TextChanged(object sender, EventArgs e)
        {
            length = Convert.ToInt32(leng.Text);
        }

        private void perR_TextChanged(object sender, EventArgs e)
        {
            per1= Convert.ToDouble(perR.Text);
        }

        private void perL_TextChanged(object sender, EventArgs e)
        {
            per2 = Convert.ToDouble(perL.Text);
        }

        private void thR_TextChanged(object sender, EventArgs e)
        {
            th1 = Convert.ToDouble(thR.Text);
        }

        private void thL_TextChanged(object sender, EventArgs e)
        {
            th2 = Convert.ToDouble(thL.Text);
        }

        private void Colour_TextChanged(object sender, EventArgs e)
        {
        }
        private void draw_Click(object sender, EventArgs e)
        {

            if (graphics == null) 
                graphics = panel2.CreateGraphics();
            drawCayleyTree(num, 150, 200, length, -Math.PI / 2);
        }
        
       

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {

            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0,double x1, double y1)
        {
            graphics.DrawLine(pen,(int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color color = colorDialog1.Color;
            pen = new Pen(color);
        }
    }
}
