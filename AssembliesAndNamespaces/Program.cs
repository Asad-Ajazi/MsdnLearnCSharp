using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {

        //site:microsoft.com. ustilising c# classes to achieve what I want.
        //in this case, getting the html string from a website and storing the contents to a text file.
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");
            
            Console.WriteLine("Hello world");
            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\asus\Desktop\Programming\CSharp\learncs\AssembliesAndNamespaces\WriteText.txt", reply);

            Console.ReadLine();
        }
    }
}
