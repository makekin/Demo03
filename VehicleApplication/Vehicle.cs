using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Vehicle
    {
        //properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }


        //method to give more speed
        public void Accelerate()
        {
            Speed += 10;
        }

        //method to slow down
        public void Break()
        {
            Speed -= 10;
        }

        //method to display Vehicle properties
        public void PrintData()
        {
            Console.WriteLine("Vehicle data: ");
            Console.WriteLine("- Name: " + Name);
            Console.WriteLine("- Speed: " + Speed);
            Console.WriteLine("- Tyre count: " + Tyres);

        }

        //method to display Vehicle properties in one string
        public void ToOneString()
        {
         //   Console.WriteLine(obj.ToString());

        }

        //destructor
        ~Vehicle()
        {
            Console.WriteLine("Vehicle object was destroyed!");
        }
    }
}
