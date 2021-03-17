using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3_2
{
    class Circle:Shape
    {
    
        public double Draw()
        {
            Random ran = new Random();
            int radium = ran.Next(1, 100);
            double area = 0.5 * Math.PI * radium * radium;
            return area;
        }
    }
}
