using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFactory
{
    class Triangle : IShapes
    {
        double b;
        double h;
        public Triangle()
        {
            Console.WriteLine("Enter Base of Triangle"); // Constructor to get input from user 
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height Of Triangle");
            h = double.Parse(Console.ReadLine());
        }
        public double GetArea()
        {
            return (b * h) / 2;
        }

        public double GetCircumference()
        {
            throw new NotImplementedException();
        }
    }
}
