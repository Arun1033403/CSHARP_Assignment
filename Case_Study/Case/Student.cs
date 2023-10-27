using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Case_Study
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int CourseID { get; set; }



        public Student(int id, string name, DateTime dateOfBirth, int courseid)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            CourseID = courseid;
        }
    }
}