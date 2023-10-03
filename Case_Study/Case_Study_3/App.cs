using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Case_study_1;   // Takes Reference of the classes from CaseStudy1
using Case_Study_2;   // Takes Reference of the classes from CaseStudy2



namespace Case_Study_3
{
    public interface IUserInterface
    {
        void ShowFirstScreen();
        void ShowStudentScreen();
        void ShowAdminScreen();
        void ShowAllStudentsScreen();
        void ShowStudentRegistrationScreen();
        void IntroduceNewCourseScreen();
        void ShowAllCoursesScreen();
    }

    public class UserInterface : IUserInterface
    {
        private AppEngine appEngine = new AppEngine();

        public void ShowFirstScreen()
        {
            Console.WriteLine("Welcome to SMS (Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin\n3. Exit");
            Console.Write("Enter the choice either (1 or 2 or 3): ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                case 3:
                    Console.WriteLine("Exit the program");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("choice is Invalid. enter 1 or 2.");
                    ShowFirstScreen();
                    break;
            }
        }

        public void ShowStudentScreen()
        {
            Console.WriteLine("Student Menu:");
            Console.WriteLine("1. View All the Courses");
            Console.WriteLine("2. Register to a Course");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAllCoursesScreen();
                    break;
                case 2:
                    ShowStudentRegistrationScreen();
                    break;
                case 3:
                    Console.WriteLine("Exiting Student Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("choice is Inavalid.enter a valid choice (1-3).");
                    ShowStudentScreen();
                    break;
            }
        }

        public void ShowAdminScreen()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Introduce a New Course");
            Console.WriteLine("2. View All the Students");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    IntroduceNewCourseScreen();
                    break;
                case 2:
                    ShowAllStudentsScreen();
                    break;
                case 3:
                    Console.WriteLine("Exiting Admin Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("choice is Inavalid.enter a valid choice (1-3).");
                    ShowAdminScreen();
                    break;
            }
        }

        public void ShowStudentRegistrationScreen()
        {
            Console.Write("Enter the Student ID: ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Student Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter the Student DOB (yyyy-MM-dd): ");
            DateTime studentDob = Convert.ToDateTime(Console.ReadLine());

            // Register the student
            appEngine.Register(new Student(studentId, studentName, studentDob));
            Console.WriteLine("Student registration done successfully.");
            Console.WriteLine("Press Enter to go back to the previous menu.");
            Console.ReadLine();
            ShowStudentScreen();
        }
        public void ShowAllStudentsScreen()
        {
            Console.WriteLine("List of Students:");
            foreach (Student student in appEngine.ListOfStudents())
            {
                Console.WriteLine($"Student ID: {student.Id}, Name: {student.Name}, Date of Birth: {student.DateOfBirth.ToShortDateString()}");
            }
            Console.WriteLine("Press Enter to go back to the previous menu.");
            Console.ReadLine();
            ShowAdminScreen();
        }


        public void IntroduceNewCourseScreen()
        {
            Console.Write("Enter the Course ID: ");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Course Name: ");
            string courseName = Console.ReadLine();

            // Introduce a new course
            appEngine.Introduce(new Course(courseId, courseName));
            Console.WriteLine("Course introduced successfully.");
            Console.WriteLine("Press Enter to go back to the previous menu.");
            Console.ReadLine();
            ShowAdminScreen();
        }

        public void ShowAllCoursesScreen()
        {
            Console.WriteLine("List of Courses:");
            foreach (Course course in appEngine.ListOfCourses())
            {
                Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
            }
            Console.WriteLine("Press Enter to go back to the previous menu.");
            Console.ReadLine();
            ShowStudentScreen();
        }
    }

    public class App
    {
        static void Main(string[] args)
        {
            new UserInterface().ShowFirstScreen();
        }
    }
}