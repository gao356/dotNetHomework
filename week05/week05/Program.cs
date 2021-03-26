using System;
using System.Collections.Generic;
using System.Text;

namespace week05
{
    class Program
    {
        static int orderID = 0;
        static OrderService service = new OrderService();
        static void Main(string[] args)
        {
            /*Good good1 = new Good(5000, "Laptop");
            Good good2 = new Good(6000, "Phone");
            Good good3 = new Good(4000, "Screen");

            Customer customer1 = new Customer("zhangsan", "whu");
            Customer customer2 = new Customer("lisi", "whu");

            Order order1 = new Order(123, customer1);
            Order order2 = new Order(124, customer2);
            order1.AddDetail(new OrderDetails(good1, 3));
            order1.AddDetail(new OrderDetails(good1, 7));
            order1.AddDetail(new OrderDetails(good3, 4));
            //order1.AddDetail(new OrderDetails(good3, 4));
            order2.AddDetail(new OrderDetails(good2, 6));
            order2.AddDetail(new OrderDetails(good3, 9));
            OrderService service = new OrderService();
            service.AddOrder(order1);
            service.AddOrder(order2);
            //service.AddOrder(order1);

            //service.ShowAllOrder();

            List<Order> list1 = service.SearchOrderByTotalPrice(60000,700000);
            foreach (Order o in list1)
            {
                Console.WriteLine(o);
            }
            //Console.WriteLine(service.SearchOrderById(123));*/
            
            bool ifBreakMain = false;
            
            while (true)
            {
                if (ifBreakMain) break;
                
                Console.WriteLine("1.add order");
                Console.WriteLine("2.delete order");
                Console.WriteLine("3.change order");
                Console.WriteLine("4.search order");
                Console.WriteLine("5.exit");
                Console.WriteLine("Input a number to choose a option above:");

                char input = Console.ReadLine()[0];
                switch (input)
                {
                    case '1': AddOrder();break;
                    case '2': DeleteOrder(); break;
                    case '3': ChangeOrder(); break;
                    case '4': SearchOrder(); break;
                    case '5': ifBreakMain = true; break;
                    default: Console.WriteLine("Wrong input! Please try again!"); break;
                }
            }


        }

        private static void AddOrder()
        {
            orderID++;
            Console.WriteLine("Input customer name:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Input customer address:");
            string customerAddr = Console.ReadLine();
            Customer customer = new Customer(customerName, customerAddr);
            Order order = new Order(orderID, customer);
            service.AddOrder(order);

            while (true)
            {
                Console.WriteLine("Want to add order details?[y/n]");
                char yesOrNo = Console.ReadLine()[0];
                if (yesOrNo == 'n') break;
                else if (yesOrNo == 'y')
                {
                    try
                    {
                        Console.Write("Input goods' name:");
                        string goodName = Console.ReadLine();
                        Console.Write("Input good's price:");
                        string goodPrice = Console.ReadLine();
                        double price = Double.Parse(goodPrice);
                        Good good = new Good(price, goodName);

                        Console.Write("Input number of "+goodName+":");
                        int numOfGood = Int32.Parse(Console.ReadLine());

                        OrderDetails detail = new OrderDetails(good, numOfGood);
                        order.AddDetail(detail);
                    }
                    catch (Exception e)
                    {
                        Console.Write("Input error!");
                    }
                }
                else Console.WriteLine("Wrong input!");
            }
        }

        private static void DeleteOrder()
        {
            if (service.orderList.Count == 0)
            {
                Console.WriteLine("There is no existing order!");
                return;
            }
            service.ShowAllOrder();
            Console.Write("Input a id to delete an order:");
            try
            {
                int id = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < service.orderList.Count;i++)
                {
                    Order order = service.orderList[i];
                    if (order.ID.Equals(id))
                    {
                        service.DeleteOrder(order);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Wrong input!!!");
            }
        }

        private static void SearchOrder()
        {
            Console.WriteLine("1.Search by id");
            Console.WriteLine("2.Search by good's name");
            Console.WriteLine("3.Search by customer name");
            Console.WriteLine("4.Search by total price");
            Console.WriteLine("Input a number to choose a option above:");

            char input = Console.ReadLine()[0];
            switch (input)
            {
                case '1': IDSearch(); break;
                case '2': GoodNameSearch(); break;
                case '3': CustomerNameSearch(); break;
                case '4': TotalPriceSearch(); break;
                default: Console.WriteLine("Wrong input!"); break;
            }
        }

        private static void IDSearch()
        {
            Console.Write("Input a id to search an order:");
            try
            {
                int id = Int32.Parse(Console.ReadLine());
                Order order = service.SearchOrderById(id);
                if (order == null)
                {
                    Console.WriteLine("Can't find such order!");
                }
                Console.WriteLine(order);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong input!!!");
            }
        }

        private static void GoodNameSearch()
        {
            Console.Write("Input a good's name to search an order:");
            string name = Console.ReadLine();
            List<Order> list = service.SearchOrderByGoodName(name);
            if (list.Count == 0)
            {
                Console.WriteLine("Can't find such order!");
                return;
            }
            else 
            {
                foreach(Order order in list)
                {
                    Console.WriteLine(order);
                }
            }
        }

        private static void CustomerNameSearch()
        {
            Console.Write("Input a customer's name to search an order:");
            string name = Console.ReadLine();
            List<Order> list = service.SearchOrderByCustomerName(name);
            if (list.Count == 0)
            {
                Console.WriteLine("Can't find such order!");
                return;
            }
            else
            {
                foreach (Order order in list)
                {
                    Console.WriteLine(order);
                }
            }
        }

        private static void TotalPriceSearch()
        {
            try
            {
                Console.Write("Input maxinum total price:");
                double max = Double.Parse(Console.ReadLine());
                Console.Write("Input mininum total price:");
                double min = Double.Parse(Console.ReadLine());

                List<Order> list = service.SearchOrderByTotalPrice(min, max);
                if (list.Count == 0)
                {
                    Console.WriteLine("Can't find such order!");
                    return;
                }
                else
                {
                    foreach (Order order in list)
                    {
                        Console.WriteLine(order);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ChangeOrder()
        {
            DeleteOrder();
            AddOrder();
        }
    }
}
