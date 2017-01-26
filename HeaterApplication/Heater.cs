using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Heater
    {
        //field
        private int heat;
        private const int MaxHeat = 100;

        //properties
        public string Model { get; set; }
        public bool Power { get; set; }
        public int Heat {
            get { return heat; }

            set {
                if (value <= MaxHeat) heat = value;
                else heat = MaxHeat;
            }
        }

        public double Humidity { get; set; }
        
        public static int maxheat { get; set; }

        //default constructor
        public Heater()
        {

        }
        //constructor with model

        public Heater(string model)
        {
            Model = model;
        }

        //method to give more heat
        public void IncreaseHeat(int value)
        {
            if (Power == true)
            {
                Heat += value;
            }
        }

        //method to lower temperature
        public void DecreaseHeat(int value)
        {
            Heat -= value;
        }

        //method to give more humidity
        public void IncreaseHumidity()
        {
            Humidity += 10;
        }

        //method to lower humidity
        public void DecreaseHumidity()
        {
            Humidity -= 10;
        }

        //method to display kiuas properties
        public void PrintData()
        {
            Console.WriteLine("Heater data: ");
            Console.WriteLine("- Model: " + Model);
            Console.WriteLine("- Heat: " + Heat);
            Console.WriteLine("- Humidity: " + Humidity);
            Console.WriteLine("- Max Temperature: " + MaxHeat);
           
        }

        //destructor
        ~Heater()
        {
            Console.WriteLine("Teh Kiuas was destroyed!");
        }
    }
}

