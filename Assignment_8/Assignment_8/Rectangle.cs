using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFactory
{

    class Rectangle : IShapes
    {
        double L;
        double B;

        public Rectangle()
        {
            Console.WriteLine("Enter Length of Rectangle:");
            L = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Breadth of Rectangle:");
            B = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return L * B;
        }

        public double GetCircumference()
        {
            return 2 * (L + B);
        }
    }
}
