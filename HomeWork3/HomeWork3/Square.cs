using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class Square
    {
        private double sidelength;
        

        public double SideLength
        {
            get
            {
                return sidelength;
            }
            set
            {
                sidelength = value;
            }
        }
       
        public void isValid()
        {
            
            if(sidelength != 0 )
            {
                Console.WriteLine("形状合法！");
            }
            else
            {
                Console.WriteLine("形状不合法！");
            }            
        }

        public void CaculateSquArea()
        {
            double area = sidelength * sidelength;

            Console.WriteLine("面积是：" + area);
        }



    }
}
