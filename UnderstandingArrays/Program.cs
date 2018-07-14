using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        //converts array to char and prints in reverse.
        static void Main(string[] args)
        {
            //arrays #1
            /*
            int[] num = new int[5];

            num[0] = 4;
            num[1] = 8;
            num[2] = 15;
            num[3] = 16;
            num[4] = 23;

            Console.WriteLine(num[1]);
            Console.WriteLine(num.Length);
            Console.ReadLine();
            */

            //int[] numbers = new int[] { 4, 8, 15, 16, 23 };

            
            string[] names = new string[] { "eddie", "alexa", "john" };
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
            /*
                //FOREACH LOOP
            foreach (string name in names)
              //temp value 'name' to store array values
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */


            //THIS CODE REVERSES THE ENTIRE STRING LETTER BY LETTER
            string zig = "You can get what you want out of life"+
                "if you help enough other people get what they want.";

            char[] charArray = zig.ToCharArray(); //converts string to char array
            Array.Reverse(charArray);

            foreach (char item in charArray)
            {
                Console.Write(item);
            }
            Console.ReadLine();

        }
    }
}
