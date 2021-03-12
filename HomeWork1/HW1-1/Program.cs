using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_1
{
    class Program
    {
  

        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            String Str1 = Console.ReadLine();
            double m = double.Parse(Str1);
            
            Console.WriteLine("请输入运算符：");
            String Str3 = Console.ReadLine();
            char c = Convert.ToChar(Str3);
            
            Console.WriteLine("请输入第二个数字：");
            String Str2 = Console.ReadLine();
            double n = double.Parse(Str2);

            if (c == '+')
            {
                Console.WriteLine("运算结果为：", m + n);
                Console.ReadLine();


            }
            else if (c == '-')
            {

               // double a = m - n; 
                Console.Write("运算结果为：{0}", m - n);
                Console.ReadLine();

            }
            else if (c == '*')
            {
                Console.WriteLine("运算结果为：{0}", m * n);
                Console.ReadLine();

            }
            else if (c == '/')
            {
                Console.WriteLine("运算结果为：{0}", m / n);
                Console.ReadLine();

            }
            else if (c == '%')
            {
                Console.Write("运算结果为：{0}", m % n);
                Console.ReadLine();

            }
            else
            {
                Console.Write("运算符不合法！");
                Console.ReadLine();
            }



        }
    }
}
