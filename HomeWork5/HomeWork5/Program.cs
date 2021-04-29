using System;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想要进行的操作序号：");
            Console.WriteLine("1、添加订单");
            Console.WriteLine("2、删除订单");
            Console.WriteLine("3、修改订单");
            Console.WriteLine("4、查询订单");
            int num =Convert.ToInt32( Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        OrderService.AddOrder();
                        break;
                    }
                case 2:
                    {
                        OrderService.DeleteOrder();
                        break;
                    }
                case 3:
                    {
                        OrderService.ModifyOrder();
                        break;
                    }
                case 4:
                    {
                        OrderService.SearchOrder();
                        break;
                    }
            }

        }
    }
}
