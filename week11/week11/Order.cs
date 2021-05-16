using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace week08
{
    [Serializable]
    public class Order : IComparable
    {
        [Key]
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }

        public Order() { }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   ID == order.ID;
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
            getAndSetTotalPrice();
        }

        public override int GetHashCode()
        {
            int hashCode = 898167170;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(OrderDetails);
            return hashCode;
        }
    }
}
