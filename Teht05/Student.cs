using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teht05
{
    class Student
    {
        string Etunimi;
        string Sukunimi;
        string Luokka;
        string age;
        string opiskelijatunnus;

        public void data()
        {
            Console.WriteLine("Enter First Name: ");
            Etunimi = Console.ReadLine();

            Console.WriteLine("Enter Family Name: ");
            Sukunimi = Console.ReadLine();
            Console.WriteLine("Enter Class: ");
            Luokka = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            age = Console.ReadLine();
            Console.WriteLine("Enter student number: ");
            opiskelijatunnus = Console.ReadLine();

        }



    }
}