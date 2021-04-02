using System;
using System.Collections.Generic;
using System.Text;

namespace week06
{

    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer() { }

        public Customer(string n, string addr)
        {
            Name = n;
            Address = addr;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Name == customer.Name &&
                   Address == customer.Address;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Address);
        }

        public override string ToString()
        {
            return "Customer name:" + Name + "    Customer address:" + Address;
        }
    }
}
