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
using System.Threading;


/*
  改进书上例子9-10的爬虫程序。
 （1）只爬取某个指定网站上的网页 
 （2）只有当爬取的是html/html/aspx/jsp等网页时，才解析并爬取下一级URL。
 （3）相对地址(test/page.html, ./test/page.html, ../test2/page2.html, /test3/page.html)转成完整地址进行爬取。
 （4） 尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。
*/

namespace Homework9
{


    static class Program
    {
        /*
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }
        */

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
