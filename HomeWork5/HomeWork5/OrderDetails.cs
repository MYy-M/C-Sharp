using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class OrderDetails
    {
        private String name;
        public String Name { set; get; }
        
        private double price;
        public Double Price { set; get; }

        public OrderDetails(String name, double price)
        {
            name = this.name;
            price = this.price;
        }

        

    }
}
