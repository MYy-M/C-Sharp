using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3_2
{
    class Square:Shape
    {
        public double Draw()
        {
            Random ran = new Random();
            double sidelength = ran.Next(1, 100);         
            double area = sidelength * sidelength;
            return area;
        }
    }
}
