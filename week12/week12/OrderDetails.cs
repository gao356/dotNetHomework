using System;
using System.Collections.Generic;
using System.Text;

namespace week06
{

    [Serializable]
    public class OrderDetails
    {
        public Good goods { get; set; }
        public int numOfGood { get; set; }

        public OrderDetails() { }

        public OrderDetails(Good goods, int numOfGood)
        {
            this.goods = goods;
            this.numOfGood = numOfGood;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   this.numOfGood == details.numOfGood &&
                   this.goods.Equals(details.goods);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(goods, numOfGood);
        }

        public double getTotalPrice()
        {
            return this.numOfGood * this.goods.Price;
        }

        public override string ToString()
        {
            return goods.ToString() + "   Total price:" + getTotalPrice();
        }
    }
}
