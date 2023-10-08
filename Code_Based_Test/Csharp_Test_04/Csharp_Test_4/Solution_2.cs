using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
delegate int CalculatorDelegate(int a, int b);



class Program

{
    static int Addition(int a, int b)

    {
        return a + b;
    }
    static int Subtraction(int a, int b)
    {
        return a - b;
    }
    static int Multiplication(int a, int b)
    {
        return a * b;
    }
    static void Main()
    {
        CalculatorDelegate addDelegate = Addition;

        CalculatorDelegate subtractDelegate = Subtraction;

        CalculatorDelegate multiplyDelegate = Multiplication;

        Console.Write("Enter the first number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

                                        // Performing calculations using delegates

        int addResult = addDelegate(x, y);

        int subResult = subtractDelegate(x, y);

        int mulResult = multiplyDelegate(x, y);

        Console.WriteLine("Addition:" + addResult);
        Console.WriteLine("Subtraction:" + subResult);
        Console.WriteLine("Multiplication:" + mulResult);
        Console.ReadLine();
    }
}