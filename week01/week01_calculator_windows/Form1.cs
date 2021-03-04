using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week01_calculator_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.Items.Add("%");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tem = num1.Text;
            int n1 = Int32.Parse(tem);
            tem = num2.Text;
            int n2 = Int32.Parse(tem);

            char c = comboBox1.SelectedIndex.ToString().ToCharArray()[0];
            if (c == '0') result.Text = (n1 + n2).ToString();
            if (c == '1') result.Text = (n1 - n2).ToString();
            if (c == '2') result.Text = (n1 * n2).ToString();
            if (c == '3') result.Text = (n1 / n2).ToString();
            if (c == '4') result.Text = (n1 % n2).ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
