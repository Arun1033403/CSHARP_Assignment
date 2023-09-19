using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_test_02
{
    public class Product

    {

        public int Productid { get; set; }
        public string Productname { get; set; }
        public decimal Price { get; set; }

    }
    public class Program
    {
        public static void Main(string[] args)

        {
            List<Product> prod = new List<Product>();
            for (int i = 1; i <= 10; i++)            //10 iterations
            {
                Product product = new Product();
                Console.Write($"Enter the details of Product {i}:");
                Console.Write("Product_iD: ");
                product.Productid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Product_name: ");
                product.Productname = Console.ReadLine();
                Console.Write("Price: ");
                product.Price = Convert.ToDecimal(Console.ReadLine());
                prod.Add(product);

            }
            prod.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

            Console.WriteLine("Sorted list of the Products are:"); // list prints in a sorted way
            foreach (Product product in prod)
            {
                Console.WriteLine($"Product_id: {product.Productid}, Product_name: {product.Productname}, Price: {product.Price}");
                Console.ReadLine();
            }

        }

    }
}