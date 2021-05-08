using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08
{
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public int ID { get; set; }

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

        public override string ToString()
        {
            return "Customer name:" + Name + "    Customer address:" + Address;
        }

        public override int GetHashCode()
        {
            int hashCode = -1876505879;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            return hashCode;
        }
    }
}
