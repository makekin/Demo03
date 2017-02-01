using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Student
    {
        //properties
        public string Name { get; set; }
        public string Studentcode { get; set; }
        public string Class { get; set; }

        public int Age { get; set; }
       

        //method to display Student properties
        public void PrintData()
        {
            Console.WriteLine("Student data: ");
            Console.WriteLine("- Name: " + Name);
            Console.WriteLine("- Studentcode: " + Studentcode);
            Console.WriteLine("- Class: " + Class);
            Console.WriteLine("- Age: " + Age);
        }

        //destructor
        ~Student()
        {
            Console.WriteLine("Student object destroyed!");
        }
    }
}
