//Write a program to find the Sum and the Average points scored by the teams in the IPL.
//Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) that takes
//no.of matches as input and accepts that many scores from the user. The function should then display
//the Average and Sum of the scores.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_test_03
{
    class Cricket
    {
        public static void PointsCalculation(int no_of_matches)

        {

            int sum = 0;
            for (int i = 1; i <= no_of_matches; i++)

            {
                Console.Write("Enter the score : " +  i + "\n");
                int score = Convert.ToInt32(Console.ReadLine());
                sum += score;

            }
            double average = (double)sum / no_of_matches;

            Console.WriteLine("Sum : {0}" , sum);
            Console.WriteLine("Average score: {0} " , average);

        }
    }
    class Sol_1
    {

        static void Main(string[] args)
        {

            Console.Write("Number of matches: ");
            int Matches = Convert.ToInt32(Console.ReadLine());

            Cricket.PointsCalculation(Matches);
            Console.Read();
        }
    }
}
