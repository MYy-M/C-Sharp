using System;

namespace HomeWork2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat= new int[7,7];
           

            for(int i = 0; i <= 6; i++)
            {
                for(int j = 0; j <= 6; j++)
                {
                    mat[i,j] = 0;
                }
            }

            Console.WriteLine("请输入一个5*5的矩阵(除0之外)：");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    mat[i,j] = Convert.ToInt32(Console.Read())-'0';
                    Console.Read();
                }
                Console.Read();
            }
           
            bool b = JudgeMatrix(mat);
            
            if (b == true)
            {
                Console.WriteLine("这个矩阵是托普利茨矩阵。");
            }
            else
            {
                Console.WriteLine("这个矩阵不是托普利茨矩阵。");
            }

        }
        public static bool JudgeMatrix(int[,] mat)
         {
            bool b = true;
            for (int m = 1; m <= 5; m++)
            {
                int i = 1;
                int j = m;
                
                while (mat[i,j] != 0)
                {
                    if(mat[1,m] != mat[i,j])
                    {
                        b = false;
                        break;
                    }
                    i += 1;
                    j += 1;
                   
                }
            }

            for (int m = 1; m <= 5; m++)
            {
                int i = m;
                int j = 1;

                while (mat[i, j] != 0)
                {
                    if (mat[1, m] != mat[i, j])
                    {
                        b = false;
                        break;
                    }
                    i += 1;
                    j += 1;

                }
            }

            return b;
        }

            
    }
}


