using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace week06
{
    [Serializable]
    public class Good
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public OrderDetails OrderDetails { get; set; }

        [Key]
        public int GoodId { get; set; }

        public Good() { }

        public override bool Equals(object obj)
        {
            return obj is Good good &&
                   Price == good.Price &&
                   Name == good.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Price, Name);
        }

        public Good(double price, string name)
        {
            Price = price;
            Name = name;
        }

        public override string ToString()
        {
            return "Good name:" + Name + ".   Good price:" + Price;
        }
    }
}
