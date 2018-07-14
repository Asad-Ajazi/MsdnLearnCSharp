using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        //creates car object. 
        //checks to see age and prints current value/price in £.
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "M3";
            myCar.Model = "bmw";
            myCar.Year = 1999;
            myCar.Color = "Black";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            decimal value=  DetermineMarketValue(myCar);
            Console.WriteLine("{0:C} always 100?",value);

            Console.WriteLine("Current value = {0:c}",myCar.DetermineMarketValue());

            Console.ReadLine();
        }
        //method helper
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.00M;
            return carValue;
        }

    }
    //class
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10050;
            else
                carValue = 2000;
            return carValue;

        }

        
    }


}
