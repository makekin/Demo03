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
            Console.WriteLine("Pesuohjelman valinta on heikoille.");
            // create one instance of Pesukone class
            Pesukone upo = new Pesukone();
            upo.PrintData();

            upo.Model = "Superpesuri";
            upo.Heat = 40;
            upo.Kierrokset = 400;
            upo.PrintData();

            upo.IncreaseHeat(10);
            upo.IncreaseKierrokset();
            upo.PrintData();

            upo.IncreaseHeat(160);

            upo.DecreaseHeat(0);
            upo.DecreaseKierrokset();
            upo.PrintData();



        }
    }
}
