using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week06;

namespace week12
{
    public class OrderServiceEF
    {
        public static Context Context { get; set; }


        public bool AddOrder(Order o)
        {
            if (Context.Order.SingleOrDefault(o => o.ID.Equals(o.ID)) != null) return false;
            Context.Order.Add(o);
            Context.SaveChanges();
            return true;
        }

        public bool DeleteOrder(Order o)
        {
            Order order = Context.Order.Include(o => o.OrderDetails).SingleOrDefault(o => o.ID.Equals(o.ID));
            if (order == null) return false;
            Context.Order.Remove(order);
            Context.SaveChanges();
            return true;
        }

        public bool ChangeOrder(Order o)
        {
            if (DeleteOrder(o) == false) return false;
            return AddOrder(o);
        }

        public Order SearchOrderById(int id)
        {
            return Context.Order
                .Include(o => o.Customer).Include(o => o.OrderDetails).ThenInclude(od => od.goods).SingleOrDefault(o => o.ID.Equals(id));
        }

        public List<Order> SearchOrderByGoodName(string name)
        {
            List<Order> orderList = Context.Order.Include(o => o.Customer).Include(o => o.OrderDetails).ThenInclude(od => od.goods)
                .ToList();
            List<Order> list = new List<Order>();
            foreach (Order order in orderList)
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
            return Context.Order
                .Include(o => o.Customer).Include(o => o.OrderDetails).ThenInclude(od => od.goods)
                .Where(o => o.Customer.Name.Equals(customer)).ToList();
        }

        public List<Order> SearchOrderByTotalPrice(double from_, double to)
        {
            return Context.Order
                .Include(o => o.Customer).Include(o => o.OrderDetails).ThenInclude(od => od.goods)
                .Where(o => o.TotalPrice >= from_ && o.TotalPrice <= to).ToList();
        }
    }
}
