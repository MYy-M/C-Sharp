using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetNum();
            int MAX = 100;  
            for (int i =2; i<MAX; i++) 
            {
                if(num%i == 0)
                {
                    Console.WriteLine(i);
                }
                
                while (num % i == 0)
                {
                    num /= i;  
                }                
            }               
        }
        public static int GetNum()
        {
            Console.WriteLine("请输入一个小于100的正整数：");
            String str = Console.ReadLine();
            int num1 = Convert.ToInt32(str);
            return num1;
        }


        }
    }


