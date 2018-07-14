using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        //using and manipulating strings.
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line"; //~n
            //string myString = "Go to c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //string myString = string.Format("Hi {1} + {0} how's it going","good","bad");
            //string myString = string.Format("currency {0:c}",123.45); // money
            //string myString = string.Format("long number {0:n}", 12323423455.45);
            //string myString = string.Format("percentage {0:p}", .45);
            //string myString = string.Format(@"Phone {0:(###) ####-####}", 02085478523);

            //string myString = " We're on the road to Viridian city";

            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /*
            myString = String.Format("Length Before:{0} Length after:{1}",
                myString.Length,myString.Trim().Length );
            */

            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */
            
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }
            


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}