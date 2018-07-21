using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCar = new List<Car>()
            {
                new Car() {VIN="A1", Make="BMW", Model="550i", StickerPrice=55000, Year= 2015},
                new Car() {VIN="B2", Make="MERC", Model="Eclass", StickerPrice=25000, Year= 2012},
                new Car() {VIN="C3", Make="BMW", Model="M3", StickerPrice=43000, Year= 2009},
                new Car() {VIN="D4", Make="FORD", Model="Focus", StickerPrice=15000, Year= 2006},
                new Car() {VIN="E5", Make="BMW", Model="X5", StickerPrice=59000, Year= 2017}         
            };

            //LINQ query
            //example 1 using &&
            var bmw1 = from car in myCar
                       where car.Make == "BMW" && car.StickerPrice > 50000
                       select car;
            //example 2, sorting by descending
            var bmw2 = from c in myCar
                       orderby c.Year descending
                       select c;
            
            foreach (var car in bmw1)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
            Console.WriteLine("//between foreach");
            foreach (var car in bmw2)
            {
                Console.WriteLine("{0} {1} {2}",car.Year, car.Model, car.VIN);
            }

            //------------


            Console.WriteLine(" staring linq method section");
            //LINQ method / lambda expressions  ( => given each item in the collection , do x/orderby x / others)
            var bmwA = myCar.Where(p => p.Make == "BMW" && p.Year==2017);

            Console.WriteLine("//descending");
            var bmwB = myCar.OrderByDescending(p => p.Year);

            foreach (var car in bmwA)
            {
                Console.WriteLine("{0} {1}",car.Model, car.VIN);
            }

            Console.WriteLine("//descending");
            foreach (var car in bmwB)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }

            Console.WriteLine("");

            //multiple lambda in one
            var firstBMW = myCar.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine("FIRST " + firstBMW.VIN);

            //inline

            Console.WriteLine("is this true for all the items in my list? = "+myCar.TrueForAll(p => p.Year > 2000));

            //subtract from price
            myCar.ForEach(p => p.StickerPrice -= 3050);
            myCar.ForEach(p => Console.WriteLine("{0} {1:C}",p.VIN, p.StickerPrice));

            //check if exists
            Console.WriteLine(myCar.Exists(p => p.Model == "Focus"));
            //add sum
            Console.WriteLine(myCar.Sum(p => p.StickerPrice));

            //select new, puts into anonymous type
            var newCars = from car in myCar
                       where car.Make == "BMW" && car.StickerPrice > 50000
                       select new{car.Make, car.Model};
            Console.WriteLine(newCars.GetType());


            Console.ReadLine();
            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

}
