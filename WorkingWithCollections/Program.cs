using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        //used Collections (dictionaries and lists)
        static void Main(string[] args)
        {
            //object initialization shorthand.
            Car car1 = new Car {Make = "Oldcar", Model = "Rusty",VIN = "A123"};

            Car car2 = new Car();
            car2.Make = "Newcar";
            car2.Model = "Fancy";
            car2.VIN = "B123";

            Book book1 = new Book();
            book1.Title = "Humming bird";
            book1.Author = "John Wick";
            book1.ISBN = "0-000-12345-6";

            //using a list to print out the car models.
            //List<T>
            /*
            List<Car> carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);
            */

            //a simplified version if objects are already initialized
            List<Car> carList = new List<Car>
            {
                car1,
                car2
            };

            foreach (Car c in carList)
            {
                Console.WriteLine(c.Model);
            }

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B123"].Make);


            //Collection initializer. (With objects defined inside)
            List<Car> myList = new List<Car>()
            {
                new Car{Make = "BMW", VIN = "E3", Model = "Hopper"},
                new Car{Make = "Merc", VIN = "E4", Model = "Jumper"}
            };

            foreach(Car car in myList)
            {
                Console.WriteLine(car.Make);
            }

            Console.ReadLine();


        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
