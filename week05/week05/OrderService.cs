using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace week05
{
    class OrderService
    {
        public List<Order> orderList { get; set; }

        public OrderService()
        {
            orderList = new List<Order>();
        }

        public void AddOrder(Order o)
        {
            if (orderList.IndexOf(o) != -1) throw new Exception("This order has existed");
            orderList.Add(o);
        }

        public void DeleteOrder(Order o)
        {
            int index = orderList.IndexOf(o);
            if (index == -1) throw new Exception("This order is not exist!");
            orderList.Remove(o);
        }

        public void ChangeOrder(Order preO, Order lastO)
        {
            if (orderList.IndexOf(preO) == -1) throw new Exception("This order is not exist!");
            if (orderList.IndexOf(lastO) != -1) throw new Exception("The order you want to add has existed1");
            orderList.Remove(preO);
            orderList.Add(lastO);
        }

        public Order SearchOrderById(int id) 
        {
            if (orderList.Count == 0) return null;
            var query = from order in orderList where order.ID.Equals(id) orderby order.ID select order;
            return query.FirstOrDefault();
        }

        public List<Order> SearchOrderByGoodName(string name)
        {
            List<Order> list = new List<Order>();
            foreach(Order order in orderList)
            {
                foreach (OrderDetails detail in order.OrderDetails)
                {
                    if (detail.goods.Name.Equals(name))
                    {
                        list.Add(order);
                        break;
                    }
                   
                }
            }
            return list;
        }

        public List<Order> SearchOrderByCustomerName(string customer)
        {
            List<Order> list = new List<Order>();
            var query = from order in orderList where order.Customer.Name.Equals(customer) orderby order.ID select order;
            if (query.FirstOrDefault() == null) return list;
            else
            { 
                foreach(Order order in query)
                {
                    list.Add(order);
                }
                return list;
            }
        }

        public List<Order> SearchOrderByTotalPrice(double from_, double to)
        {
            List<Order> list = new List<Order>();
            var _query = from order in orderList where order.getAndSetTotalPrice() >= from_ orderby order.ID select order;
            var query = from order in _query where order.getAndSetTotalPrice() <= to orderby order.ID select order;
            if (query.FirstOrDefault() == null) return list;
            else
            {
                foreach (Order order in query)
                {
                    list.Add(order);
                }
                return list;
            }
        }

        public void Sort()
        {
            orderList.Sort();
        }

        public void Sort(IComparer<Order> comparer)
        {
            orderList.Sort(comparer);
        }

        public void ShowAllOrder()
        {
            foreach (Order o in orderList)
            {
                Console.WriteLine(o);
            }
        }
    }
}
