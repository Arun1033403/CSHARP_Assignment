//Write a class Box that has Length and breadth as its members. Write a function that adds 2 box objects
//and stores in the 3rd. Display the 3rd object details. Create a Test class to execute the above.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_test_03
{
    class box
    {
        public double Length;
        public double Breadth;
        public box(double length, double breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }
        public static box operator +(box box1, box box2)
        {
            double sumLength = box1.Length + box2.Length;
            double sumBreadth = box1.Breadth + box2.Breadth;

            return new box(sumLength, sumBreadth);
        }
        public void Displayobject3()
        {
            Console.WriteLine("Length of 3rd Box is: {0}", Length);
            Console.WriteLine("Breadth of 3rd Box is: {0}", Breadth);
        }
    }

    class Sol_2
    {
        public static void Main()
        {
            Console.WriteLine("Length and Breadth For Box 1 ");
            Console.WriteLine("Enter the length of box 1 ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length  : " + length1);
            Console.WriteLine();
            Console.WriteLine("Enter the Breadth of box 1 ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Breadth  : " + breadth1);

            Console.WriteLine("Length and Breadth For Box 2 ");
            Console.WriteLine("Enter the length of box 2 ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Length  : " + length2);
            Console.WriteLine();
            Console.WriteLine("Enter the Breadth of box 2 ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Breadth  : " + breadth2);

            box box1 = new box(length1, breadth1);
            box box2 = new box(length2, breadth2);
            box box3 = box1 + box2;
            Console.WriteLine("\nLength and Breadth of Box 3 is: ");
            box3.Displayobject3();
            Console.ReadLine();


        }

    }
}