using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           //takes input and uses methods to reverse string
           //reverse string method converts string to char and reverses
           //standard display results method shows results
           //override method take one perameter instead of 3.


            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();
                      
            //standard method.3 parameters in one.
            DisplayResults(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city));

            Console.WriteLine();
            
            //override method in use. 
            DisplayResults(ReverseString(firstName) +" "+
                ReverseString(lastName) + " "+
                ReverseString(lastName) + " " + //can use twice
                ReverseString(city));

            DisplayResults("overload method alone.");

            Console.ReadLine();

        }
        //  METHODS START HERE  
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResults(
            string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {
            Console.WriteLine("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }


        private static void DisplayResults(string message)
        {
            Console.WriteLine("Results(override method): ");
            Console.Write(message);
        }

    }
}
