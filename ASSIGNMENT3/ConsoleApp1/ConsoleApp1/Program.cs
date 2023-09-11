
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int[] a = new int[10];
        public static void input()
        {
            WriteLine("enter the input marks:.........\n ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine("array sorted in asending order:.........\n");
            System.Array.Sort(a);
            for (int j = 0; j < a.Length; j++)
                WriteLine($"    {a[j]}  ");
            WriteLine("array in desending order..............\n");
            System.Array.Reverse(a);
            for (int k = 0; k < a.Length; k++)
                WriteLine($" {a[k]} ");

        }
        public static void total()
        {
            int tt = 0;
            for (int k = 0; k < a.Length; k++)
                tt = tt + a[k];
            WriteLine($" total value {tt}");
            WriteLine($" the maximum value={a.Max()}");
            WriteLine($" the minimum value={a.Min()}");
            WriteLine($" the Average of marks={a.Average()}");
        }
        public static void Main(string[] args)
        {
            int[] arry = new int[10];
            input();
            total();
            Read();
            //
            // WriteLine($"Maximum of array {arry.Max}");
            //WriteLine($"Minimum of array {arry.Min}");

        }
    }
}

