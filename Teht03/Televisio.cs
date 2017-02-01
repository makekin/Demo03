using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Televisio
    {       
        //properties
        public string Model { get; set; }
        public bool Power { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }
            

        //default constructor
        public Televisio()
        {

        }
        //constructor with model

        public Televisio(string model)
        {
            Model = model;
        }

        //method to change to turn on tv
        public void TurnOnTv()
        {
            Power = true;
        }

        //method to change to turn Off tv
        public void TurnOffTv()
        {
            Power = false;
        }

        //method to change to next channel
        public void NextChannel()
        {
            if (Power == true)
            {
                Channel += 1;
            }
        }

        //method to change to previous channel
        public void PreviousChannel()
        {
            if (Power == true)
            {
                Channel -= 1;
            }  
        }

        //method to change to any channel
        public void ChangeChannel(int value)
        {
            if (Power == true)
            {
                Channel = value;
            }
        }

        //method to increase volume
        public void IncreaseVolume()
        {
            Volume += 10;
        }

        //method to lower volume
        public void DecreaseVolume()
        {
            Volume -= 10;
        }

        //method to display Televisio properties
        public void PrintData()
        {
            Console.Write("The tv is: "); 
            if (Power=true)
            { Console.Write("On"); }
            else { Console.Write("Off"); }
            Console.WriteLine("Televisio data: ");
            Console.WriteLine("- Model: " + Model);
            Console.WriteLine("- Channel: " + Channel);
            Console.WriteLine("- Volume: " + Volume);
        }

        //destructor
        ~Televisio()
        {
            Console.WriteLine("TV has been destroyed! ohnoes");
        }
    }
}

