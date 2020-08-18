using System;
using System.Net;

namespace BasicWebCrawlerWebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            var text = client.DownloadString("https://www.mahoningctc.com");

            Console.WriteLine(text);
        }
    }
}
