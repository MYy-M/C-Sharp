using System;

namespace HomeWork4_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x <= 10; x++)
            {
                intlist.Add(x);

            }
            int max;
            int min;
            int sum = 0;
            max = min = intlist.Head.Data;
            
            intlist.ForEach(d => sum+=d);
            intlist.ForEach(d =>
            {
                if (d > max)
                    max = d;           
            });
            intlist.ForEach(d => 
            {
                if (d < min)
                    min = d;
            });
            Console.WriteLine("最大值是：" + max);
            Console.WriteLine("最小值是：" + min);
            Console.WriteLine("和是：" + sum);
            Console.ReadLine();

        }


       
       
        
        
        
       

        

       
    }
}
