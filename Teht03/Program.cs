using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of heater class
            Televisio samsung = new Televisio();
            samsung.PrintData();
            samsung.TurnOnTv();
            samsung.Model = "Epic Screen";
            samsung.Channel = 1;
            samsung.Volume = 30;
            samsung.PrintData();

            samsung.NextChannel();
            samsung.IncreaseVolume();
            samsung.PrintData();

            
            samsung.PreviousChannel();
            samsung.DecreaseVolume();
            samsung.PrintData();



        }
    }
}
