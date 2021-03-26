using System;
using System.Collections.Generic;
using System.Text;

namespace week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Good good1 = new Good(5000, "Laptop");
            Good good2 = new Good(6000, "Phone");
            Good good3 = new Good(4000, "Screen");

            Customer customer1 = new Customer("zhangsan", "whu");
            Customer customer2 = new Customer("lisi", "whu");

            Order order1 = new Order(123, customer1);
            Order order2 = new Order(124, customer2);
            order1.AddDetail(new OrderDetails(good1, 3));
            order1.AddDetail(new OrderDetails(good1, 7));
            order1.AddDetail(new OrderDetails(good3, 4));
            order2.AddDetail(new OrderDetails(good2, 6));
            order2.AddDetail(new OrderDetails(good3, 6));
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);

            List<Order> list1 = service.SearchOrderByGoodName("Screen");
            foreach (Order o in list1)
            {
                Console.WriteLine(o);
            }

            /* Console.WriteLine(service.SearchOrderById(123));*/
        }
    }
}
