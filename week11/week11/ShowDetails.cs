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
    public partial class ShowDetails : Form
    {
        public List<OrderDetails> details;

        public ShowDetails(List<OrderDetails> d)
        {
            InitializeComponent();
            details = d;
            detailBinding.DataSource = details;
        }
    }
}
