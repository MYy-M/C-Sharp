using System;
using System.Collections;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list = GetPrime();
            
            Console.WriteLine("数字2-100中共有质数：{0}", list.Count);
            foreach (var i in list)
            {
                Console.WriteLine(Convert.ToInt32(i));               
            }
            


        }
        public static ArrayList GetPrime() 
        {           
            ArrayList list = new ArrayList();
            for(int i = 2; i <= 100; i++)
            {
                list.Add(i);
            }
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0 && i/2 !=1)
                {
                    list.Remove(i);

                }


            }

            for (int j = 1; 2*j <= 99; j++)
            {
                for (int i = 2;i<= 100; i++)
                {
                    int m = 2 * j + 1;
                    if(i % m == 0 && i/m !=1)
                    {
                        list.Remove(i);
                    }                                       
                }
            }
                 
            return list;

        }
    }
}
