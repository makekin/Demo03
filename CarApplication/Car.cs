using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        //properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }

        //default constructor
        public Car()
        {

        }

        //constructor...default

            public Car(string model)
        {
            Model = model;
        }

        //method to give more speed
        public void Accelerate()
        {
            Speed += 10;
        }

        //method to slow down
        public void Break(int value)
        {
            Speed -= value;
        }

        //method to display car properties
        public void PrintData()
        {
            Console.WriteLine("Car data: ");
            Console.WriteLine("- Model: " + Model);
            Console.WriteLine("- Color: " + Color);
            Console.WriteLine("- Engine: " + Engine);
            Console.WriteLine("- Speed: " + Speed);
            Console.WriteLine("- FuzzyDices: " + FuzzyDices);
            Console.WriteLine("- Doors: " + DoorCount);
            Console.WriteLine("- Some static property: " + SomeProperty);
        }
        
        //destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed!");        
        }
    }
}
