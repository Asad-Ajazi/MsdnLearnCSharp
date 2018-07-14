using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic use of variables taking an input and outputting the result.
            /*
            int x = 5;
            int t = x + 7;
            Console.WriteLine(t);
            Console.ReadLine();
            */
            Console.WriteLine("What is your first name?");
            Console.Write("Type your first name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            Console.Write("Type your last name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Hello your name is "+fName+" "+lName+".");
            Console.WriteLine("This is first name: {0} and this is last name: {1}", fName, lName);
            Console.ReadLine();

        }
    }
}
