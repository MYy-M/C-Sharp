using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class Triangle
    {
        private double baselength;
        private double height;

        public double BaseLength
        {
            get
            {
                return baselength;
            }
            set
            {
                baselength = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public void isValid()
        {

            if (baselength != 0 && height != 0)
            {
                Console.WriteLine("形状合法！");
            }
            else
            {
                Console.WriteLine("形状不合法！");
            }
        }

        public void CaculateTriArea()
        {
            double area = 0.5*baselength * height;

            Console.WriteLine("面积是：" + area);
        }
    }

}
