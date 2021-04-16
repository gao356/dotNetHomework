using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08
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

        public double getTotalPrice()
        {
            return this.numOfGood * this.goods.Price;
        }

        public override string ToString()
        {
            return goods.ToString() + "   Total price:" + getTotalPrice();
        }

        public override int GetHashCode()
        {
            int hashCode = -1259489816;
            hashCode = hashCode * -1521134295 + EqualityComparer<Good>.Default.GetHashCode(goods);
            hashCode = hashCode * -1521134295 + numOfGood.GetHashCode();
            return hashCode;
        }
    }
}
