using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Case_Study
{
    public class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enrollment> enrollments = new List<Enrollment>();



        public AppEngine()
        {

        }



                                                                                  //Introduce a new course
        public void Introduce(Course course)
        {
            courses.Add(course);
        }



                                                                                   //Register a new Student
        public void Register(Student student)
        {
            students.Add(student);
        }




                                                                                 //fetch the list of enrollments
        public List<Enrollment> ListOfEnrollments()
        {
            return enrollments;

        }



                                                                                  //fetch the list of students
        public List<Student> ListOfStudents()
        {
            return students;
        }



                                                                                  //fetching the list of courses
        public List<Course> ListOfCourses()
        {
            return courses;
        }



                                                                                  //to enroll student in course
        public void Enroll(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now;                               
            enrollments.Add(new Enrollment(student, course, enrollmentDate));
        }


    }
}