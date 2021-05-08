using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week08
{
    public partial class Form1 : Form
    {
        public int Id { get; set; }
        public string GoodName { get; set; }
        public string CusName { get; set; }

        public OrderService orderService = new OrderService();

        private List<Order> tempList;

        public Form1()
        {
            InitializeComponent();
            // orderService.Import();
            tb_id.DataBindings.Add("Text", this, "Id");
            tb_goodName.DataBindings.Add("Text", this, "GoodName");
            tb_cusName.DataBindings.Add("Text", this, "CusName");
            orderBinding.DataSource = tempList;
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            orderBinding.DataSource = orderService.FindAll();
        }

        private void btn_idSearch_Click(object sender, EventArgs e)
        {
            Order temp = orderService.SearchOrderById(Id);
            tempList = new List<Order>();
            if (temp != null)
            {
                tempList.Add(temp);
                MessageBox.Show("查询到1条记录");
            }
            else 
            {
                MessageBox.Show("没有查询到记录");
            }
            orderBinding.DataSource = tempList;
        }

        private void btn_goodNameSearch_Click(object sender, EventArgs e)
        {
            tempList = orderService.SearchOrderByGoodName(GoodName);

            if (tempList.Count == 0) MessageBox.Show("没有查询到记录");
            else MessageBox.Show("查询到" + tempList.Count + "条记录");
            orderBinding.DataSource = tempList;
        }

        private void btn_searchByCusName_Click(object sender, EventArgs e)
        {
            tempList = orderService.SearchOrderByCustomerName(CusName);

            if (tempList.Count == 0) MessageBox.Show("没有查询到记录");
            else MessageBox.Show("查询到" + tempList.Count + "条记录");
            orderBinding.DataSource = tempList;
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {
            NewOrder newOrder = new NewOrder();
            newOrder.FatherForm = this;
            newOrder.ShowDialog();
            // orderService.Export();
        }

        private void btn_changeOrder_Click(object sender, EventArgs e)
        {
            Order order;
            order = orderService.SearchOrderById(Id);
            if (order == null)
            {
                MessageBox.Show("id" + Id + "对应的订单不存在");
            }
            else
            {
                orderService.DeleteOrder(order.ID);
                NewOrder newOrder = new NewOrder();
                newOrder.FatherForm = this;
                newOrder.Id = Id;
                newOrder.CusName = CusName;
                newOrder.Addr = order.Customer.Address;
                newOrder.detailList = new List<OrderDetails>(order.OrderDetails);
                newOrder.ShowDialog();
                // orderService.Export();
            }
        }

        private void btn_deleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                orderService.DeleteOrder(Id);
                // orderBinding.DataSource = orderService.orderList;
                // orderService.Export();
            }
            catch (Exception excp)
            {
                MessageBox.Show("删除未完全成功");
            }

        }

        private void btn_showDetails_Click(object sender, EventArgs e)
        {
            Order order;
            order = orderService.SearchOrderById(Id);
            if (order == null)
            {
                MessageBox.Show("id" + Id + "对应的订单不存在");
            }
            else
            {
                ShowDetails sd = new ShowDetails(order.OrderDetails);

                sd.ShowDialog();
            }
        }
    }
}
