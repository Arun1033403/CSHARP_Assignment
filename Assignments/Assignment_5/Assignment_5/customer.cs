using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class customer
    {
        public static void Main()
        {
            Console.Write("Enter Customer ID: ");
            string customerId = Console.ReadLine();



            Console.Write("Enter Name: ");
            string name = Console.ReadLine();



            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());



            Console.Write("Enter Phone: ");
            long phone = Convert.ToInt32(Console.ReadLine());



            Console.Write("Enter City: ");
            string city = Console.ReadLine();




            Customer customer1 = new Customer(customerId, name, age, phone, city);
            Customer.Display(customer1);
            Customer customer2 = new Customer();
            Customer.Display(customer2);
            Console.Read();
        }
    }
    class Customer
    {
        string Customerid;
        string Name;
        int Age;
        long Phone;
        string City;



        public Customer()
        {



        }
        public Customer(string customerId, string name, int age, long phone, string city)
        {
            Customerid = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;



        }
        public static void Display(Customer customer)
        {
            Console.WriteLine("Customer ID: " + customer.Customerid);
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Age: " + customer.Age);
            Console.WriteLine("Phone: " + customer.Phone);
            Console.WriteLine("City: " + customer.City);



        }
        ~Customer()
        {
            Console.WriteLine("this customer " + Name + "is being deleted");
        }
    }
}
