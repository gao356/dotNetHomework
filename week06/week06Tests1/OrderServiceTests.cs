using Microsoft.VisualStudio.TestTools.UnitTesting;
using week06;
using System;
using System.Collections.Generic;
using System.Text;

namespace week06.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        private static List<Order> InitOrder()
        {
            Good good1 = new Good(5000, "Laptop");
            Good good2 = new Good(6000, "Phone");
            Good good3 = new Good(4000, "Screen");

            Customer customer1 = new Customer("zhangsan", "whu");
            Customer customer2 = new Customer("lisi", "whu");

            Order order1 = new Order(1, customer1);
            Order order2 = new Order(2, customer2);
            order1.AddDetail(new OrderDetails(good1, 3));
            order1.AddDetail(new OrderDetails(good2, 7));
            order1.AddDetail(new OrderDetails(good3, 4));
            order2.AddDetail(new OrderDetails(good2, 6));
            order2.AddDetail(new OrderDetails(good3, 9));

            List<Order> list = new List<Order>();
            list.Add(order1);
            list.Add(order2);
            return list;

        }

        [TestMethod()]
        public void AddOrderTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.AddOrder(odList[1]);

            CollectionAssert.AreEqual(odList, service.orderList);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.AddOrder(odList[1]);
            service.DeleteOrder(odList[1]);

            odList.Remove(odList[1]);

            CollectionAssert.AreEqual(odList, service.orderList);
        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.ChangeOrder(odList[0], odList[1]);

            odList.Remove(odList[0]);

            CollectionAssert.AreEqual(odList, service.orderList);
        }

        [TestMethod()]
        public void SearchOrderByIdTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.AddOrder(odList[1]);
            Order o = service.SearchOrderById(1);
            
            Assert.AreEqual(o, odList[0]);
        }

        [TestMethod()]
        public void SearchOrderByGoodNameTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.AddOrder(odList[1]);
            odList.Remove(odList[1]);
            List<Order> list = service.SearchOrderByGoodName("Laptop");

            CollectionAssert.Equals(odList, list);
        }

        [TestMethod()]
        public void SearchOrderByCustomerNameTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.AddOrder(odList[1]);
            odList.Remove(odList[1]);
            List<Order> list = service.SearchOrderByCustomerName("zhangsan");

            CollectionAssert.Equals(odList, list);
        }

        [TestMethod()]
        public void SearchOrderByTotalPriceTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.AddOrder(odList[1]);
            odList.Remove(odList[1]);
            List<Order> list = service.SearchOrderByTotalPrice(0,100000);

            CollectionAssert.Equals(odList, list);
        }

        [TestMethod()]
        public void SortTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.AddOrder(odList[1]);
            service.Sort();

            CollectionAssert.Equals(odList, service.orderList);
        }

        [TestMethod()]
        public void ShowAllOrderTest()
        {
            List<Order> odList = InitOrder();

            OrderService service = new OrderService();
            service.AddOrder(odList[0]);
            service.AddOrder(odList[1]);

            service.ShowAllOrder();
        }

    }
}