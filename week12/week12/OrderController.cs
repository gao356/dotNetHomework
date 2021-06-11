using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week06;

namespace week12
{
    [ApiController]
    [Route("orderAPI")]
    public class OrderController:ControllerBase
    {
        private OrderService orderService = new OrderService();
        private Context context;

        public OrderController(Context context)
        {
            this.context = context;
            OrderServiceEF.Context = context;
        }

        [HttpGet("searchById/{id}")]
        public ActionResult<Order> searchOrderById(int id)
        {
            Order o = orderService.SearchOrderById(id);
            if (o == null) return NotFound();
            return o;
        }

        [HttpGet("searchByCusName/{name}")]
        public ActionResult<List<Order>> searchOrderByCusName(string name)
        {
            List<Order> o = orderService.SearchOrderByCustomerName(name);
            if (o.Count == 0) return NotFound();
            return o;
        }

        [HttpGet("searchByGoodName/{name}")]
        public ActionResult<List<Order>> searchOrderByGoodName(string name)
        {
            List<Order> o = orderService.SearchOrderByGoodName(name);
            if (o.Count == 0) return NotFound();
            return o;
        }

        [HttpGet("searchByPrice/{from}/{to}")]
        public ActionResult<List<Order>> searchOrderByPrice(int from, int to)
        {
            List<Order> o = orderService.SearchOrderByTotalPrice(from,to);
            if (o.Count == 0) return NotFound();
            return o;
        }

        [HttpGet("deleteById/{id}")]
        public ActionResult<Order> deleteOrderById(int id)
        {
            Order order = orderService.SearchOrderById(id);
            if (order == null) return NotFound();
            else
            {
                try
                {
                    orderService.DeleteOrder(order);
                }
                catch (Exception e)
                {
                    return NotFound();
                }
                orderService.Export();
                return order;
            }
        }

        [HttpPost("addOrder")]
        public ActionResult<Order> addOrder(Order o)
        {
            orderService.AddOrder(o);
            orderService.Export();
            return o;            
        }

        [HttpPost("changeOrder")]
        public ActionResult<Order> changeOrder(Order o)
        {
            Order order = orderService.SearchOrderById(o.ID);
            if (order == null) return NotFound();
            orderService.ChangeOrder(order, o);
            orderService.Export();
            return o;
        }
    }
}
