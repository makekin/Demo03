using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of heater class
            Heater harvia = new Heater();
            Heater.maxheat = 100;
            harvia.PrintData();

            harvia.Heat = 20;
            harvia.Humidity = 50;
            harvia.PrintData();

            harvia.IncreaseHeat(10);
            harvia.IncreaseHumidity();
            harvia.PrintData();

            harvia.IncreaseHeat(160);

            harvia.DecreaseHeat(10);
            harvia.DecreaseHumidity();
            harvia.PrintData();



        }
    }
}
