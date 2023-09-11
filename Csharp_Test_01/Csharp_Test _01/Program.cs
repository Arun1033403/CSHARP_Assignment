using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Test__01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q1");



            Console.WriteLine(RemoveCharacter("Python", 1));
            Console.WriteLine(RemoveCharacter("Python", 0));
            Console.WriteLine(RemoveCharacter("Python", 4));
        



            Console.WriteLine("Q2");



            Console.WriteLine("Enter the numbers : ");
            int num = Convert.ToInt32(Console.ReadLine());



            Multiplication(num);



            Console.ReadLine();
        }



        public static string RemoveCharacter(string input, int position)
        {

            if (position < 0 || position >= input.Length)
            {
                return input;
            }



            string result = input.Remove(position, 1);



            return result;
        }





        public static void Multiplication(int number)
        {

            Console.WriteLine($"Multiplication Table for {number}:");



            for (int i = 0; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
    }
}