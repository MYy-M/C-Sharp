using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3_2
{
     public class Rectangle: Shape
    {
        public double Draw()
        {
            Random num = new Random();
            double length = num.Next(1, 100);
            double width = num.Next(1, 100);
            double area = length * width;
            return area;
        }
    }
}
