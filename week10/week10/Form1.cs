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

namespace week10
{
    public partial class Form1 : Form
    {

        Crawler crawler;
        Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            crawler = new Crawler();
            crawler.MaxNum = 20;
            t = new Thread(crawler.Crawl);

            string originUrl = tb_Url.Text;
            if (!originUrl.Contains("http"))
            {
                tb_Url.Text = "http://" + originUrl;
            }

            crawler.logTextBox = tb_Log;
            crawler.CertainWebsite = tb_CertainWebsite.Text;
            string startUrl = tb_Url.Text;
            crawler.urls.Add(startUrl, false);//加入初始页面
            t.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            t.Abort();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            tb_Log.Text = "";
        }
    }
}
