using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Csharp_Test_2
{

    public abstract class Student
    {
        public string Student_Name;
        public int Student_Id;
        public double Student_Grade;



        public abstract bool IsPassed(double grade);
    }
    // 2 Child classes 
    public class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    public class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details of Undergraduate student:");
            Undergraduate undergraduateStudent = UndergraduateDetails();

            Console.WriteLine("\nEnter details of Graduate student:");
            Graduate graduateStudent = GraduateDetails();

            Console.WriteLine("Result for Undergraduate ");
            Console.WriteLine("\nName: " + undergraduateStudent.Student_Name);
            Console.WriteLine("Student ID: " + undergraduateStudent.Student_Id);
            bool UndergraduatePassed = undergraduateStudent.IsPassed(undergraduateStudent.Student_Grade);
            Console.WriteLine("Passed: " + UndergraduatePassed);


            Console.WriteLine("Result ");
            Console.WriteLine("\nName: " + graduateStudent.Student_Name);
            Console.WriteLine("Student ID: " + graduateStudent.Student_Id);
            bool GraduatePassed = graduateStudent.IsPassed(graduateStudent.Student_Grade);
            Console.WriteLine("Passed: " + GraduatePassed);



            Console.ReadLine();
        }



        public static Undergraduate UndergraduateDetails()
        {
            Undergraduate student = new Undergraduate();
            Console.Write(" Name: ");
            student.Student_Name = Console.ReadLine();
            Console.Write(" Student ID: ");
            student.Student_Id = int.Parse(Console.ReadLine());
            Console.Write(" Grade: ");
            student.Student_Grade = double.Parse(Console.ReadLine());
            return student;
        }



        static Graduate GraduateDetails()
        {
            Graduate student = new Graduate();



            Console.Write("Enter Name: ");
            student.Student_Name = Console.ReadLine();

            Console.Write(" Student ID: ");
            student.Student_Id = int.Parse(Console.ReadLine());



            Console.Write(" Grade: ");
            student.Student_Grade = double.Parse(Console.ReadLine());



            return student;
        }
    }
}