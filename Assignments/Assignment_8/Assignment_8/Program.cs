using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Shape Type :");
            string typesofshape = Console.ReadLine().ToLower();

            IShapes cc = ShapeFactory.GetShapes(typesofshape);


            if (cc != null)
            {
                Console.WriteLine("Area is : " + cc.GetArea());
                Console.WriteLine("Circumference is" + " " + cc.GetCircumference());

            }
            else
            {
                Console.WriteLine("Invalid shape , give the correct type");
            }
            Console.Read();
        }
    }
}
