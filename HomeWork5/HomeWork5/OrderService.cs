using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class OrderService
    {
        public static int num = 100000;
        public static String orderName;
        public static double total;
        static List<Order> orderList = new List<Order>();

        public static int CreateID()
        {
            return num++;
        }

        public static bool Equals(String name,int id)
        {
            if (orderList !=null)
            {
               foreach(Order i in orderList)
                {
                    return i.Name  == name && i.ID == id;
                }

            }
            return true;
        }

        public static void AddOrder()
        {
            
            Console.WriteLine("请输入订单的名称：");
            orderName = Console.ReadLine();
            
            List<OrderDetails> productlist = new List<OrderDetails>();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("请输入您想购买的商品(小于十件,一次只能输入一件商品，输入完您想要购买的商品后，请输入“完成”):");
                String name = Console.ReadLine();
                Console.WriteLine("请输入您想购买的商品的单价:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入您想购买的商品的数量:");
                double num = Convert.ToDouble(Console.ReadLine());
                total = total + price * num;
                OrderDetails product = new OrderDetails(name, price);
                productlist.Add(product);

                if (Console.ReadLine() == "完成") break;

            }
            int id = CreateID();
            Order order = new Order(id, orderName, productlist, total);
            if (Equals(orderName, id))
            {
                orderList.Add(order);
            }

        }
        public static void DeleteOrder()
        {
            Console.WriteLine("请输入您想要删除的订单的订单号：");
            int id =Convert.ToInt32( Console.ReadLine());
            foreach (Order i in orderList)
            {
                if(i.ID == id)
                {
                    orderList.Remove(i);
                }
                else
                {
                    throw new FormatException("您输入的订单不存在");
                }
            }
        }
        public static void ModifyOrder()
        {
            Console.WriteLine("请输入您想修改的信息的序号：");
            Console.WriteLine("1、订单名称");
            Console.WriteLine("2、订单明细");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("请输入您想要修改的订单的订单号：");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入您想要修改名称：");
                        String name = Console.ReadLine();
                        foreach (Order i in orderList)
                        {
                            if (i.Name != name && i.ID == id)
                                i.Name = name;
                            else
                                throw new Exception("您输入的名称已存在");
                            
                        }
                            break;
                    }
                case 2:
                    {

                        Console.WriteLine("请输入您想要修改的订单明细：");
                        Console.WriteLine("1、添加商品：");
                        Console.WriteLine("2、删除商品：");
                        Console.WriteLine("3、修改商品价格");
                        Console.WriteLine("4、修改商品数量");
                        int n = Convert.ToInt32(Console.ReadLine());
                        switch (n)
                        {
                            case 1:
                                {
                                    
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine(""); 
                                    break;
                                }
                            case 3:
                                {
                                    
                                    break;
                                }
                            case 4:
                                {
                                    
                                    break;
                                }
                        }

                    }
                    break;
                    }
               
            }
        public static void SearchOrder()
        {

        }
    
    
    
    }
       

}



