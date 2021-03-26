using System;
using System.Collections.Generic;
using System.Text;

namespace week05
{
    class Order : IComparable
    {
        public int ID { get; set; }
        public double TotalPrice { get; set; } 
        public Customer Customer { get; set; }
        public List<OrderDetails> OrderDetails{get;set;}

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   ID == order.ID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, TotalPrice, Customer, OrderDetails);
        }

        public Order(int iD, Customer customer)
        {
            ID = iD;
            TotalPrice = 0;
            Customer = customer;
            OrderDetails = new List<OrderDetails>();
        }

        public double getAndSetTotalPrice()
        {
            TotalPrice = 0;
            foreach (OrderDetails d in OrderDetails)
            {
                TotalPrice += d.getTotalPrice();
            }
            return TotalPrice;
        }

        public override string ToString()
        {
            string str = "Order id:" + ID + "     Total price:" + getAndSetTotalPrice() + "     " + Customer.ToString() + "\n";
            foreach (OrderDetails d in OrderDetails)
            {
                str += d.ToString() + "\n";
            }
            str += "\n---------------------------------------------------------";
            return str;
        }

        public int CompareTo(object obj)
        {
            Order order = (Order)obj;
            return this.ID - order.ID;
        }

        public void AddDetail(OrderDetails d)
        {
            if (OrderDetails.IndexOf(d) == -1) OrderDetails.Add(d);
            else throw new Exception("This detail has existed in this order!");
        }
    }
}
