using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    { //aka cheat sheet
        static void Main(string[] args)
        {
            // Variable declaration
            int x, y, a, b;

            // Assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // THERE ARE MANY MATHEMATICAL OPERATORS...

            // Addition operator
            x = 3 + 4;

            // Subtraction operator
            x = 4 - 3;

            // Multiplication operator
            x = 10 * 5;

            // Division operator
            x = 10 / 5;

            // Order of operations using parenthesis
            x = (x + y) * (a - b);

            // THERE ARE MANY OPERATORS USED TO EVALUATE VALUES...

            // Equals operator
            if (x == y)
            {
            }

            // Greater than operator
            if (x > y)
            {
            }

            // Less than operator
            if (x < y)
            {
            }

            // Greater than or equal to operator
            if (x >= y)
            {
            }

            // Less than or equal to operator
            if (x >= y)
            {
            }

            // THERE ARE TWO "CONDITIONAL" OPERATORS THAT CAN BE USED TO
            // EXPAND/ENHANCE AND EVAULATION...
            // ... AND THEY CAN BE COMBINED TOGETHER MULTIPLE TIMES.

            // Conditional AND operator...
            if ((x > y) && (a>b))
            {
            }

            // Conditional OR operator...
            if ((x > y) || (a > b)) 
            {
            }

            // Also, here's the in-line conditional operator I
            //learned about previously...
            string message = (x == 1) ? "Car" : "Boat";

            // Member access and Method invocation
            Console.WriteLine("Hi");

        }
    }
}
