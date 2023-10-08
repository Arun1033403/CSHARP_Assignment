using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Assignment_1
    {
        static void Main(string[] args)
        {
            Solution_1_1();
            Solution_1_2();
            Solution_1_3();
            Console.Read();
        }

        static void Solution_1_1()
        {
            Console.WriteLine("Solution 1_1");
            Console.WriteLine("Input First Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second number : ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal");
            }
        }

        static void Solution_1_2()
        {
            Console.WriteLine("Solution 1_2");
            Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"{number} is a positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a negative");
            }
        }

        static void Solution_1_3()
        {
            Console.WriteLine("Solution 1_3");
            Console.WriteLine("Enter the first number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double additionResult = num1 + num2;
            double subtractionResult = num1 - num2;
            double multiplicationResult = num1 * num2;

            Console.WriteLine($"Addition: {num1} + {num2} = {additionResult}");
            Console.WriteLine($"Subtraction: {num1} - {num2} = {subtractionResult}");
            Console.WriteLine($"Multiplication: {num1} * {num2} = {multiplicationResult}");

            if (num2 != 0)
            {
                double divisionResult = num1 / num2;

                Console.WriteLine($"Division: {num1} / {num2} = {divisionResult}");
            }

            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

        }

    }
}
