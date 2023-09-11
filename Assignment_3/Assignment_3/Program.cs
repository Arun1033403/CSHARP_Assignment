using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            len();

            //2.
            //Console.WriteLine("Enter a string");
            //string input = Console.ReadLine();

            ////to reverse

            //string rev = revstr(input);
            //Console.WriteLine($"reverse word is {rev}");
            //Console.ReadLine();

            //3.
            //equal();

        }


        static void len()
        {
            Console.WriteLine("Enter a word:");
            string Input = Console.ReadLine();

            // to check length
            int length = Input.Length;
            Console.WriteLine($"length is {length}");
            Console.ReadLine();
        }

        static string revstr(string input)
        {
            StringBuilder reversed = new StringBuilder();



            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }



            return reversed.ToString();
        }
        static void equal()
        {
            Console.WriteLine("enter a word 1");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter a word 2");
            string word2 = Console.ReadLine();

            bool check = string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase);

            if (check)
            {
                Console.WriteLine("Words entered are equal");

            }
            else
            {
                Console.WriteLine("Words entered are not equal");

            }
            Console.ReadLine();
        }
    }
}
