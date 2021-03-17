using System;

namespace HomeWork3_2
{
    class Program
    {

        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            double totalArea = 0;
            Random random = new Random();
            for (int i = 1; i <= 10; i++) 
            {
                int num = random.Next(1, 4);
                switch (num)
                {
                    case 1:
                        {
                            Shape shape = shapeFactory.GetShape("CIRCLE");
                            totalArea += shape.Draw();
                            break;
                        }
                    case 2:
                        {
                            Shape shape = shapeFactory.GetShape("RECTANGLE");
                            totalArea += shape.Draw();
                            break;
                        }
                    case 3:
                        {
                            Shape shape = shapeFactory.GetShape("SQUARE");
                            totalArea += shape.Draw();
                            break;
                        }
                    case 4:
                        {
                            Shape shape = shapeFactory.GetShape("TRIANGLE");
                            totalArea += shape.Draw();
                            break;
                        }
                }

            }
            Console.WriteLine("随机生成十个图形的面积的总和为：" + totalArea);
            Console.ReadLine();


            


        }


    
    }

      
    }

