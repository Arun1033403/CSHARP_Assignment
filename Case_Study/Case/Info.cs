using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



namespace Case_Study
{
    class Info
    {
        public void Display(Student student)
        {
            Console.WriteLine($"Student ID: {student.Id}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Date of Birth: {student.DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Course ID: {student.CourseID}");
        }
    }
}