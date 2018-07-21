using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceToAssembly
{
    class Program
    {
        //to access parts of the .net framework class library.
        //1. right click references in the solution explorer and add reference.
        //2. Nuget
        //-----
        //Make our own class library to reference, here we scraped a web page and wrote it to a file.
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string result = myScrape.ScrapeWebpage("http://www.msdn.microsoft.com", @"C:\Users\asus\Desktop\Programming\CSharp\learncs\ReferenceToAssembly\WriteText.txt");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
