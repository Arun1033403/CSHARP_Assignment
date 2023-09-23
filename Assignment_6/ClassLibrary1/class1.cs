using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assignment_6
{
    public class Concession

    {
        public void CalculateConcession(string name , int age)

        {
            if (age == 5)
            {

                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age >= 60)
            {
                double fare = 500 * 0.7; // 30% concession on 500

                Console.WriteLine("Senior Citizen - Calculated Fare: " + fare);
            }
            else
            {
                Console.WriteLine("Ticket Booked - Fare: 500");
            }
        }
    }
}