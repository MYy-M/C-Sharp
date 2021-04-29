using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Order
    {
        public int ID { get; set; } //订单ID       
        public String Name { get; set; }//订单名称
        public Double priceSum; //订单总价

        List<OrderDetails> list = new List<OrderDetails>();

        public Order(int id,String name,List<OrderDetails> list,double priceSum)
        {
            ID = id;
            Name = name;
            this.list = list;
            this.priceSum = priceSum;
        }

       
    }
}
