using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Solution_2
    {
        static void Main()
        {

            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Enter the letter to count: ");
            char letterToCount = Console.ReadKey().KeyChar;
            int count = CountOccurrences(inputString, letterToCount);
            Console.WriteLine($"{letterToCount} appears {count} times in the string.");
            Console.Read();
        }

        public static int CountOccurrences(string inputString, char letterToCount)
        {
            int count = 0;
            foreach (char c in inputString)
            {

                if (char.ToUpper(c) == char.ToUpper(letterToCount))
                {
                    count++;
                }

            }
            return count;
        }
    }
}
