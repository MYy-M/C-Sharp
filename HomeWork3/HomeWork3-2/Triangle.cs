using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3_2
{
    class Triangle : Shape
    {
        public double Draw()
        {
            Random ran = new Random();
            double baselength = ran.Next(1, 100);
            double height = ran.Next(1, 100);
            double area = 0.5*baselength * height;
            return area;
        }
    }
}
