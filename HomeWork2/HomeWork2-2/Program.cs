using System;

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = GetArrays();
            int max = 0;
            int min = 0;
            int avr = 0;
            GetMaxMinAvrNum(num,out max,out min,out avr);    
            PrintResult(max,min,avr);
        }

        public static int[] GetArrays()
        {
            Console.WriteLine("请输入一组数（5个）：");
            int[] num;
            num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第" + (i + 1) + "个数:");
                String str = Console.ReadLine();
                int n = Convert.ToInt32(str);
                num[i] = n;
            }
            return num;
        }

        public static void PrintResult(int max,int min,int avr)
        {
            Console.WriteLine("您输入的这组数的最大值为：{0}", max);
            Console.WriteLine("您输入的这组数的最小值为：{0}", min);
            Console.WriteLine("您输入的这组数的平均值为：{0}", avr);
            Console.ReadLine();
        }

        public static int GetMaxMinAvrNum(int[] num,out int max ,out int min ,out int avr) 
        {
            max = 0;
            min = 0;
            avr = 0;
            int sum = 0;
            foreach (int nums in num)
            {
                max = min = num[0];
                if (max < nums)
                {
                    max = nums;
                }
                if (min > nums)
                {
                    min = nums;
                }
                
                sum+= nums;
            }
            avr = sum / num.Length;            
             return 0;
        }
    }
}
