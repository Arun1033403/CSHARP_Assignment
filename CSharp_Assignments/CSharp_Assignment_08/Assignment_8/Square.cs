using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFactory
{
    class Square : IShapes
    {
        double l;
        public Square()
        {
            Console.WriteLine("Enter Length / Breadth of Sqaure");
            l = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return l * l;
        }

        public double GetCircumference()
        {
            return 4 * l;
        }
    }
}
