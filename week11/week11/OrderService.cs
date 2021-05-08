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
            // if (orderList.IndexOf(o) != -1) throw new Exception("This order has existed");
            // orderList.Add(o);
            using (var db = new OrderContext()) {
                db.Order.Add(o);
                var cus = db.Customer.Where(cu => cu.ID == o.Customer.ID).FirstOrDefault();
                if (cus == null)
                {
                    db.Customer.Add(new Customer(o.Customer.Name, o.Customer.Address, o.Customer.ID));
                }
                for (int i = 0; i < o.OrderDetails.Count;i++) // (OrderDetails od in o.OrderDetails)
                {
                    OrderDetails od = o.OrderDetails[i];
                    // OrderDetail newOd = new OrderDetail();
                    // newOd.
                    var good = db.Good.Where(g => g.ID == od.goods.ID).FirstOrDefault();
                    if (good == null)
                    {
                        db.Good.Add(new Good(od.goods.Price, od.goods.Name, od.goods.ID));
                    }
                    od.GoodID = od.goods.ID;
                    od.OrderID = o.ID;
                    db.OrderDetails.Add(od);
                }
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
                var order = context.Order.Include("OrderDetails").FirstOrDefault(o => o.ID == id);
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
                var order = context.Order.Include("OrderDetails").Include("Customer").FirstOrDefault(o => o.ID == preO.ID);
                for (int i = 0; i < order.OrderDetails.Count; i++)
                {
                    order.OrderDetails[i].goods = context.Good.Where(g => g.ID == order.OrderDetails[i].goods.ID).FirstOrDefault();
                }
                if (order != null)
                {
                    DeleteOrder(order.ID);
                    AddOrder(lastO);
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
                var order = context.Order.Include("OrderDetails").Include("Customer").Where(o => o.ID == id).FirstOrDefault();
                if (order == null) return null;
                for (int i = 0; i < order.OrderDetails.Count; i++)
                {
                    order.OrderDetails[i].goods = context.Good.Where(g => g.ID == order.OrderDetails[i].goods.ID).FirstOrDefault();
                }
                return order;
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
                var order = context.Order.Include("OrderDetails").Include("Customer");
                if (order == null) return null;
                

                foreach (var o in order)
                {
                    for (int i = 0; i < o.OrderDetails.Count; i++)
                    {
                        o.OrderDetails[i].goods = context.Good.Where(g => g.ID == o.OrderDetails[i].goods.ID).FirstOrDefault();
                    }
                    foreach (var detail in o.OrderDetails)
                    {
                        if (detail.goods.Name.Equals(name))
                        {
                            list.Add(o);
                            break;
                        }
                    }
                }
                
                // return list;
            }

            return list;
        }

        public List<Order> FindAll() 
        {
            List<Order> list = new List<Order>();
            using (var context = new OrderContext())
            {
                list = context.Order.Include("OrderDetails").Include("Customer").ToList<Order>();

                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < list[i].OrderDetails.Count; j++)
                    {
                        list[i].OrderDetails[j].goods = context.Good.Where(g => g.ID == list[i].OrderDetails[j].GoodID).FirstOrDefault();
                    }
                }
            }
            return list;
        }

        public List<Order> SearchOrderByCustomerName(string customer)
        {
            List<Order> list = new List<Order>();

            using (var context = new OrderContext())
            {
                var query = context.Order.Include("Customer").Where(o => o.Customer.Name == customer).ToList<Order>();

                foreach(var order in query)
                {
                    list.Add(SearchOrderById(order.ID));
                }
            }
            return list;
        }

        public List<Order> SearchOrderByTotalPrice(double from_, double to)
        {
            List<Order> list = new List<Order>();
            using (var context = new OrderContext())
            {
                var query = context.Order.Include("OrderDetails").Include("Customer")
                    .Where(o => o.TotalPrice >= from_ && o.TotalPrice <= to).ToList<Order>();

                for (int i = 0; i < query.Count; i++)
                {
                    for(int j = 0;j<query[i].OrderDetails.Count;j++)
                    {
                        query[i].OrderDetails[j].goods = context.Good.Where(g => g.ID == query[i].OrderDetails[j].GoodID).FirstOrDefault();
                    }
                }
                list = query;
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
