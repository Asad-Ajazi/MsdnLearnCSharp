using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    //works with the scrape client in 'ReferenceToAssemplies'
    //filePath = @"C:\Users\asus\Desktop\Programming\CSharp\learncs\ReferenceToAssembly\WriteText.txt";
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);
        }

        public string ScrapeWebpage(string url, string filePath)
        {
            string reply = GetWebpage(url);            
            File.WriteAllText(filePath, reply);

            return reply;
        }
        //Private method to encapsulate
        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            reply += "IN THE END, IT DOESN'T EVEN MATTER";
            return reply;
        }

    }
}
