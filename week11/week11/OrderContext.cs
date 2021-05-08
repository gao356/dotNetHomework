using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08;

namespace week11
{
    class OrderContext:DbContext
    {
        public OrderContext() : base("OrderDatabase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Good> Good { get; set; }
        public DbSet<Customer> Customer { set; get; }
    }
}
