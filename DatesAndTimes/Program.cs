using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime myValue = DateTime.Now;
            
            //formatting dates/times.
            Console.WriteLine(myValue.ToString()); // -mm/dd/yyyy hms
            Console.WriteLine(myValue.ToShortDateString()); // -mm/dd/yyyy
            Console.WriteLine(myValue.ToShortTimeString()); // hh/mm
            Console.WriteLine(myValue.ToLongDateString()); // 12 february 2018 
            Console.WriteLine(myValue.ToLongTimeString()); //hh/mm/ss
            Console.WriteLine();

            //add or subtract from current date/time.
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());
            Console.WriteLine();
            //print out the int value of the month.
            Console.WriteLine(myValue.Month);
            Console.WriteLine();

            //datetime object
            DateTime myBirthday = new DateTime(1993, 11, 04);
            Console.WriteLine("My birthday = "+myBirthday.ToShortDateString());
            Console.WriteLine();
            
            //difference between dates using timespan
            DateTime aBirthday = DateTime.Parse("04/11/1993");
            TimeSpan myAge = DateTime.Now.Subtract(aBirthday);
            Console.WriteLine("My age in days = "+myAge.TotalDays);
            

            Console.ReadLine();
        }
    }
}
