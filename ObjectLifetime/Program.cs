using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        //calls static method for no reason
        //create myCar object, and peint out onto screen.
        //make otherCar object and set = to myCar. both have same refs now.
        //changing one changes the other.
        //setting one to null removes it but other stays.
        //create third car using overloaded constructor.


        static void Main(string[] args)
        {
            Car.myMethod(); //static method in the car class
            Car myCar = new Car();

            

            ///*
            myCar.Make = "batmancar";
            myCar.Model = "BMW";
            myCar.Year = 1993;
            myCar.Color = "Silver";
            //*/
            Car otherCar;
            otherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                otherCar.Make,
                otherCar.Model,
                otherCar.Year,
                otherCar.Color);

            otherCar.Make = "supercar";

            Console.WriteLine("{0}", myCar.Make);
            Console.WriteLine("{0}", otherCar.Make);
            Console.WriteLine("{0}", otherCar.Year);

            myCar.Make = "oldone";
            Console.WriteLine("{0}", otherCar.Make);

            otherCar = null;
            
            /*
            Console.WriteLine("{0} {1} {2} {3}",
                otherCar.Make,
                otherCar.Model,
                otherCar.Year,
                otherCar.Color);
                */

            myCar = null;
            //thrid car using overloaded constructor.
            Car thirdCar = new Car("makename", "modelname", 1993, "colorname");

            Console.ReadLine();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
                
        //constuctor
        public Car()
        {
            //can load from config file or database
            //so it's immediately useable.
            this.Make = "Nissan";

        }

        //overloaded constructor.
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void myMethod()
        {
            Console.WriteLine("called the static myMethod(does nothing for now)");
            //below gives error.
            //Console.WriteLine(Make);
        }

    }
}
