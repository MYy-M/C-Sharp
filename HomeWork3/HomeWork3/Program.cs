using System;

namespace HomeWork3
{
    class Program : Rectangle
    {
        
        static void Main(string[] args)
        {
            Program pro = new Program();
            Square sq = new Square();
            Triangle tri = new Triangle();
            Console.WriteLine("请输入您想操作图形的序号：");
            Console.WriteLine("1、长方形");
            Console.WriteLine("2、正方形");
            Console.WriteLine("3、三角形");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        int num1 = SelectFunction();
                        switch (num1)
                        {
                            case 1:
                                {
                                    Console.WriteLine("请输入长方形的长：");
                                    double len = Convert.ToDouble(Console.ReadLine());
                                    pro.Length = len;
                                    Console.WriteLine("请输入长方形的宽：");
                                    double wid = Convert.ToDouble(Console.ReadLine());
                                    pro.Width = wid;
                                    pro.CaculateRecArea();
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("请输入长方形的长：");
                                    double len = Convert.ToDouble(Console.ReadLine());
                                    pro.Length = len;
                                    Console.WriteLine("请输入长方形的宽：");
                                    double wid = Convert.ToDouble(Console.ReadLine());
                                    pro.Width = wid;
                                    pro.isValid();
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        int num1 = SelectFunction();
                        switch (num1)
                        {
                            case 1:
                                {
                                    
                                    Console.WriteLine("请输入正方形的边长：");
                                    double sidelen = Convert.ToDouble(Console.ReadLine());
                                    sq.SideLength = sidelen;
                                    sq.CaculateSquArea();
                                    break;
                                }
                            case 2:
                                {
                                   
                                    Console.WriteLine("请输入正方形的边长：");
                                    double sidelen = Convert.ToDouble(Console.ReadLine());
                                    sq.SideLength = sidelen;
                                    pro.isValid();
                                    break;
                                }
                               
                        }
                        break;
                    }
                case 3:
                    {
                        int num1 = SelectFunction();
                        switch (num1)
                        {
                            case 1:
                                {
                                    Console.WriteLine("请输入三角形的底边长：");
                                    double baselen = Convert.ToDouble(Console.ReadLine());
                                    tri.BaseLength = baselen;
                                    Console.WriteLine("请输入三角形的高：");
                                    double height = Convert.ToDouble(Console.ReadLine());
                                    tri.Height = height;
                                    tri.CaculateTriArea();
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("请输入三角形的底边长：");
                                    double baselen = Convert.ToDouble(Console.ReadLine());
                                    tri.BaseLength = baselen;
                                    Console.WriteLine("请输入三角形的高：");
                                    double height = Convert.ToDouble(Console.ReadLine());
                                    tri.Height = height;
                                    tri.isValid();
                                    break;
                                }

                        }
                        break;
                    }

            }


        }

        public static  int SelectFunction()
        {
            Console.WriteLine("请输入您想进行操作的序号：");
            Console.WriteLine("1、计算面积");
            Console.WriteLine("2、判断合法性");
            int num1 = Convert.ToInt32(Console.ReadLine());
            return num1;
        }
        /*public static void GetRecData()
        {
            Program pro = new Program();
            Console.WriteLine("请输入长方形的长：");
            double len = Convert.ToDouble(Console.ReadLine());
            pro.Length = len;
            Console.WriteLine("请输入长方形的宽：");
            double wid = Convert.ToDouble(Console.ReadLine());
            pro.Width = wid;
        }

        public static void GetSquData()
        {
            Square sq = new Square();
            Console.WriteLine("请输入正方形的边长：");
            double sidelen = Convert.ToDouble(Console.ReadLine());
            sq.SideLength = sidelen;
        }


        public static void GetTriData()
        {
            
            Console.WriteLine("请输入三角形的底边长：");
            double baselen = Convert.ToDouble(Console.ReadLine());
            tri.BaseLength = baselen;
            Console.WriteLine("请输入三角形的高：");
            double height = Convert.ToDouble(Console.ReadLine());
            tri.Height = height;
        }*/
    }
      
}

