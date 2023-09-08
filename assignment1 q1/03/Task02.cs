using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Task02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number > 0)
            {
                Console.WriteLine($"{number} is a positive");
            }
           else if(number < 0)
            {
                Console.WriteLine($"{number} is a negative");
            }
            Console.ReadLine();
            
 
        }
    }
}
