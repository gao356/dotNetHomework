using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using week11;

namespace week08
{
    public class OrderService
    {
        public List<Order> orderList { get; set; }

        public OrderService()
        {
            orderList = new List<Order>();
        }

        public void AddOrder(Order o)
        {
            if (orderList.IndexOf(o) != -1) throw new Exception("This order has existed");
            // orderList.Add(o);
            using (var db = new OrderContext()) {
                db.Order.Add(o);
                db.SaveChanges();
            }
        }

        public void DeleteOrder(int id)
        {
            /*int index = orderList.IndexOf(o);
            if (index == -1) throw new Exception("This order is not exist!");
            orderList.Remove(o);*/
            using (var context = new OrderContext())
            {
                var order = context.Order.Include("OrderDetails").Include("Good").Include("Customer").FirstOrDefault(o => o.ID == id);
                if (order != null)
                {
                    context.Order.Remove(order);
                    context.SaveChanges();
                }
            }
        }

        public void ChangeOrder(Order preO, Order lastO)
        {
            // if (orderList.IndexOf(preO) == -1) throw new Exception("This order is not exist!");
            // if (orderList.IndexOf(lastO) != -1) throw new Exception("The order you want to add has existed1");
            // orderList.Remove(preO);
            // orderList.Add(lastO);
            using (var context = new OrderContext())
            {
                var order = context.Order.Include("OrderDetails").Include("Good").Include("Customer").FirstOrDefault(o => o.ID == preO.ID);
                if (order != null)
                {
                    order.Customer = lastO.Customer;
                    order.OrderDetails = lastO.OrderDetails;
                    order.TotalPrice = lastO.TotalPrice;
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Error!");
                }
            }
        }

        public Order SearchOrderById(int id)
        {
            using (var context = new OrderContext())
            {
                var query = context.Order.Include("OrderDetails").Include("Good").Include("Customer").Where(i => (i.ID == id));
               
                return query.FirstOrDefault();
            }
            return null;
        }

        public List<Order> SearchOrderByGoodName(string name)
        {
            List<Order> list = new List<Order>();
            /*foreach (Order order in orderList)
            {
                foreach (OrderDetails detail in order.OrderDetails)
                {
                    if (detail.goods.Name.Equals(name))
                    {
                        list.Add(order);
                        break;
                    }

                }
            }*/

            using (var context = new OrderContext())
            {
                var query = context.Order.Include("OrderDetails").Include("Good").Include("Customer");

                foreach (var order in query)
                {
                    foreach (var detail in order.OrderDetails)
                    {
                        if (detail.goods.Name.Equals(name))
                        {
                            list.Add(order);
                            break;
                        }
                    }
                }
            }
            return list;
        }

        public List<Order> FindAll() 
        {
            List<Order> list = new List<Order>();
            using (var context = new OrderContext())
            {
                var query = context.Order.Include("OrderDetails").Include("Good").Include("Customer");

                foreach (var order in query)
                {
                    list.Add(order);
                }
            }
            return list;
        }

        public List<Order> SearchOrderByCustomerName(string customer)
        {
            List<Order> list = new List<Order>();

            using (var context = new OrderContext())
            {
                var query = context.Order.Include("OrderDetails").Include("Good").Include("Customer");

                foreach (var order in query)
                {
                    if (order.Customer.Name.Equals(customer))
                    {
                        list.Add(order);
                    }
                }
            }
            return list;
        }

        public List<Order> SearchOrderByTotalPrice(double from_, double to)
        {
            List<Order> list = new List<Order>();
            using (var context = new OrderContext())
            {
                var query = context.Order.Include("OrderDetails").Include("Good").Include("Customer")
                    .Where(o => o.TotalPrice >= from_ && o.TotalPrice <= to);

                foreach (var order in query)
                {
                    list.Add(order);
                }
            }
            return list;
        }

/*        public void Sort()
        {
            orderList.Sort();
        }*/

/*        public void Sort(IComparer<Order> comparer)
        {
            orderList.Sort(comparer);
        }

        public void ShowAllOrder()
        {
            foreach (Order o in orderList)
            {
                Console.WriteLine(o);
            }
        }*/

/*        public void Export()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Create))
            {
                serializer.Serialize(fs, orderList);
            }
        }*/

/*        public void Import()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                orderList = (List<Order>)serializer.Deserialize(fs);
            }
        }*/
    }
}
