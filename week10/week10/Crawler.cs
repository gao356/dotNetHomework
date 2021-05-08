using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace week10
{
    class Crawler
    {
        public RichTextBox logTextBox { get; set; }
        public Hashtable urls = null;
        public int MaxNum { get; set; }
        private int count = 0;
        private int numOfTask = 0;
        private List<Task> taskList;
        public string CertainWebsite { get; set; }

        public void Crawl()
        {
            taskList = new List<Task>();
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (count > MaxNum) break;

                if (current == null) 
                {
                    // if (numOfTask > 0) continue;
                    /*if (isAllFinished(taskList)) break;
                    else continue;*/
                    Task.WaitAll(taskList.ToArray());
                    foreach (string url in urls.Keys)
                    {
                        if ((bool)urls[url]) continue;
                        current = url;
                    }
                    if (current == null) break;
                }


                // 只有爬取指定类型网页才解析爬取下一级URL
                if (current.Contains(".htm") || current.Contains(".aspx") || current.Contains(".jsp") || count <= 1) { }
                else
                {
                    urls[current] = true;
                    continue;
                }

                urls[current] = true;
                lock (this)
                {
                    numOfTask++;
                    taskList.Add(Task.Run(() => DownLoadAndParse(current)));
                }
                // while (numOfTask >= 5) { }
                // Task.Run(() => DownLoadAndParse(current));

                // Task.WaitAll(Task.Run(() => DownLoadAndParse(current)));
                /*Thread.Sleep(5000);*/

            }
            MessageBox.Show("全部爬行结束");
            numOfTask = 0;
            count = 0;
            // urls = Hashtable.Synchronized(new Hashtable());
        }

        private bool isAllFinished(ArrayList tl)
        {
            foreach (Task task in tl)
            {
                if (task.Status != TaskStatus.RanToCompletion) return false;
            }
            return true;
        }

        public string DownLoadAndParse(string url)
        {
            lock (this)
            {
                logTextBox.Text += ("爬行" + url + "页面!\n");
            }
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = "";
                lock (this)
                {
                    count++;
                    fileName = count.ToString();
                }
                File.WriteAllText(fileName, html, Encoding.UTF8);
                Parse(html, url);//解析,并加入新的链接
                return html;
            }
            catch (Exception ex)
            {
                lock (this)
                {
                    logTextBox.Text += (ex.Message + ":" + url + "\n");
                }
                return "";
            }
            finally
            {
                lock (this)
                {
                    logTextBox.Text += ("爬行" + url + "结束\n");
                    numOfTask--;
                }
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
                    /*if (!strRef.Contains("//")) strRef = "//" + strRef;
                    strRef = "http:" + strRef;*/
                }
                else 
                {
                    if (urls[strRef] == null) urls[strRef] = false; 
                }
               
            }
        }
    }
}
