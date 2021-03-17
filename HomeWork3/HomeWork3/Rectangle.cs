using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    public abstract class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public void isValid()
        {

            if (length != 0 && width != 0)
            {
                Console.WriteLine("形状合法！");
            }
            else
            {
                Console.WriteLine("形状不合法！");
            }
        }

        public void CaculateRecArea()
        {
            double area = length * width;

            Console.WriteLine("面积是：" + area);
        }

    }
}
