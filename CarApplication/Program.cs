using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Fiat Uno";
            car.Color = "punaisehko";
            car.Engine = 1.1;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            Car.SomeProperty = 123;
            car.PrintData();
            car.Accelerate();
            Console.WriteLine("speed = " + car.Speed);
            car.Break(5);
            Console.WriteLine("speed = " + car.Speed);

            //create a new instance from Car class
            Car nascar = new CarApplication.Car("Speedster");
            nascar.PrintData();
            nascar.Color = "Black";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = false;
            nascar.PrintData();


        }
    }
}
