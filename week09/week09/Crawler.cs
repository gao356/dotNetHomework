using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week09
{
    class SimpleCrawler
    {
        public RichTextBox successTextBox { get; set; }
        public Hashtable urls = new Hashtable();
        private int count = 0;
        public string CertainWebsite{ get; set; }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;


                // 只有爬取指定类型网页才解析爬取下一级URL
                if (current.Contains(".html") || current.Contains(".aspx") || current.Contains(".jsp") || count <= 1) { }
                else 
                {
                    urls[current] = true;
                    continue; 
                }

                successTextBox.Text += ("爬行" + current + "页面!\n");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接
                successTextBox.Text += ("爬行" + current + "结束\n");

            }
            MessageBox.Show("全部爬行结束");
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                successTextBox.Text += (ex.Message + ":" + url + "\n");
                return "";
            }
        }

        public void Parse(string html, string currentUrl)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');

                // 只爬取指定网址
                if (!strRef.Contains(CertainWebsite))
                {
                    continue;
                }
                // MessageBox.Show(strRef);

                //相对路径转绝对
                if (strRef.Contains(".."))
                {
                    if (currentUrl.EndsWith(@"/"))
                    {
                        strRef = currentUrl + strRef.Replace("..", "");
                    }
                    else 
                    {
                        strRef = currentUrl.Substring(0, currentUrl.LastIndexOf('/') + 1) + strRef.Replace("..", "");
                    } 
                }

                if (strRef.Length == 0) continue;
                if (!strRef.Contains("http"))
                {
                    strRef = "http:" + strRef;
                }
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
