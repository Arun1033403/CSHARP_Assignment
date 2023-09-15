//Create a Class Program which would be used to accepts two  Strings
//- FirstName and LastName and call the static method Display()
//that displays the first name in one line and the LastName in the
//second line after converting the same to upper case.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Program
    {

        static void display()
        {
            Console.WriteLine("enter first name");
            string f = Console.ReadLine();
            Console.WriteLine("enter last name");
            string l = Console.ReadLine();
            Console.WriteLine("name in upper case");
            Console.WriteLine(f.ToUpper() + "\n" + l.ToUpper());



        }

        static void Main(string[] args)
        {

            display();
            Console.ReadLine();
        }
    }
}
