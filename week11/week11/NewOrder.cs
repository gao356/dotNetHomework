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
    public partial class NewOrder : Form
    {
        public Form1 FatherForm { get; set; }
        public string CusName { get; set; }
        public int Id { get; set; }
        public string Addr { get; set; }
        public string GoodName { get; set; }
        public int GoodNum { get; set; }
        public double GoodPrice { get; set; }

        public List<OrderDetails> detailList = new List<OrderDetails>();

        public NewOrder()
        {
            InitializeComponent();
            tb_cusName.DataBindings.Add("Text", this, "CusName");
            tb_id.DataBindings.Add("Text", this, "Id");
            tb_addr.DataBindings.Add("Text", this, "Addr");
            tb_amount.DataBindings.Add("Text", this, "GoodNum");
            tb_goodName.DataBindings.Add("Text", this, "GoodName");
            tb_goodPrice.DataBindings.Add("Text", this, "GoodPrice");
            addDetailBinding.DataSource = detailList;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (Id != 0 && CusName != null && Addr != null)
            {
                Order order = new Order();
                order.ID = Id;
                order.Customer = new Customer(CusName, Addr);
                order.OrderDetails = detailList;
                order.getAndSetTotalPrice();
                FatherForm.orderService.AddOrder(order);
                this.Close();
            }
            else 
            {
                MessageBox.Show("请填写完整的信息");
            }
        }

        private void btn_addDetail_Click(object sender, EventArgs e)
        {
            detailList = new List<OrderDetails>(detailList);
            detailList.Add(new OrderDetails(new Good(GoodPrice, GoodName), GoodNum));
            addDetailBinding.DataSource = detailList;
        }
    }
}
