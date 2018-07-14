using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    class Program
    {
        //basic if statment pick a door game.
        static void Main(string[] args)
        {
            /* Console.WriteLine("A big giveaway.");
             Console.Write("Pick a door: 1, 2 or 3: ");
             string userValue = Console.ReadLine();

             string message = "";

             if (userValue == "1")
                 message = "You won a car";
             else if (userValue == "2")
                 message = "You won a boat";
             else if (userValue == "3")
                 message = "You won a cat";
             else
             {
                 message = "You ran into the door, ";
                 message += "you lose";
             }
             Console.WriteLine(message);
             Console.ReadLine();
             */

            Console.WriteLine("A big giveaway.");
            Console.Write("Pick a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "Lint"; //boolea, if true message = left/boat. if false then right/Lint.

            //Console.Write("You won a " + message+".");
            Console.WriteLine("You won a {0}.", message);
            Console.ReadLine();

        }
    }
}
