using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Pesukone
    {
        //field
        private int heat;
        private const int MaxHeat = 90;

        //properties
        public string Model { get; set; }
        public bool Power { get; set; }
        public int Heat
        {
            get { return heat; }

            set
            {
                if (value <= MaxHeat) heat = value;
                else heat = MaxHeat;
            }
        }

        public int Kierrokset { get; set; }

        public static int Maxheat { get; set; }

        //default constructor
        public Pesukone()
        {

        }
        //constructor with model

        public Pesukone(string model)
        {
            Model = model;
        }

        //method to give more heat
        public void IncreaseHeat(int value)
        {
            if (Power != true)
            {
                Heat += value;
            }
        }

        //method to lower temperature
        public void DecreaseHeat(int value)
        {
            if (Power != true)
            {
                Heat -= value;
            }
            Heat -= value;
        }

        //method to give more kierroksia
        public void IncreaseKierrokset()
        {
            Kierrokset += 10;
        }

        //method to lower kierroksia
        public void DecreaseKierrokset()
        {
            Kierrokset -= 10;
        }

        //method to display pesukone properties
        public void PrintData()
        {
            Console.WriteLine("Pesukone data: ");
            Console.WriteLine("- Model: " + Model);
            Console.WriteLine("- Heat: " + Heat);
            Console.WriteLine("- so called linkousnopeus: " + Kierrokset);
            Console.WriteLine("- Max Temperature: " + MaxHeat);

        }

        //destructor
        ~Pesukone()
        {
            Console.WriteLine("Pesukone goes boom!");
        }
    }
}

