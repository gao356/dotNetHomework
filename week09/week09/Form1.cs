using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string originUrl = URLTextBox.Text;
            if (!originUrl.Contains("http")) {
                URLTextBox.Text = "http://" + originUrl;
            }

            SimpleCrawler myCrawler = new SimpleCrawler();
            myCrawler.successTextBox = successText;
            myCrawler.CertainWebsite = TB_website.Text;
            string startUrl = URLTextBox.Text;
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
