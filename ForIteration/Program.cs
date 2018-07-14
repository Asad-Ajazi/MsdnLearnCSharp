using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //goes through 1-10 and stops when 7 is found
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i==7)
                {
                    Console.WriteLine("found 7");
                    break;
                }
            }
            Console.WriteLine("next app");

            //can use any name instead of i
            for (int myVal = 1; myVal < 10; myVal++)
            {
                Console.WriteLine(myVal);
            }

            Console.ReadLine();
        }
    }
}
