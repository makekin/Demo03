using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of Vehicle class
            Vehicle pirssi = new Vehicle();
            pirssi.PrintData();
            pirssi.Name = "Fiat Uno";

            pirssi.Speed = 10;

            pirssi.Tyres = 4;

            pirssi.PrintData();
            pirssi.Accelerate();

            


        }
    }
}
