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
    public class UserInterface : IUserInterface
    {
        private AppEngine appEngine;
        public UserInterface(AppEngine appEngine)
        {
            this.appEngine = appEngine;
        }
      
        public void ShowFirstScreen()
        {
            Console.WriteLine("Student Managment ");
            Console.WriteLine("Who are you : \n1. Student\n2. Admin\n3. Exit");
            Console.Write("Choose an option (1, 2 or 3): ");
            int opt = Convert.ToInt32(Console.ReadLine());



            switch (opt)
            {
                case 1:
                    ShowStudentScreen();
                    break;
                case 2:
                    ShowAdminScreen();
                    break;
                case 3:
                    Console.WriteLine("Exit ");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option choose valid one . Please enter 1 or 2.");
                    ShowFirstScreen();
                    break;
            }
        }



        // Student Menu Option
        public void ShowStudentScreen()
        {
            Console.WriteLine("Student Menu:");
            Console.WriteLine("1. View All the Courses");
            Console.WriteLine("2. Register for a Course");
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
                    Console.WriteLine("Exit Student Menu.");
                    ShowFirstScreen();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a valid option (1-3).");
                    ShowStudentScreen();
                    break;
            }
        }


        public void ShowAdminScreen()
        {
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. Introduce a New Course");
            Console.WriteLine("2. View All the Students");
            Console.WriteLine("3. Enrollment Details are");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-3): ");
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
                    ShowEnrollmentsScreen();
                    break;
                case 4:
                    Console.WriteLine("Exiting Admin Menu.");
                    ShowFirstScreen();
                    break;



                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1-3).");
                    ShowAdminScreen();
                    break;
            }
        }


        public void ShowAllStudentsScreen()
        {
            string cs = ConfigurationManager.ConnectionStrings["arun"].ConnectionString;
            SqlConnection c = null;
            Console.WriteLine("List of all the Students:");
            try
            {
                using (c = new SqlConnection(cs))
                {
                    string query = "select * from student";
                    SqlCommand cmd = new SqlCommand(query, c);
                    c.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("StudentId: " + dr[0]);
                        Console.WriteLine("StudentName: " + dr[1]);
                        Console.WriteLine("Studentdob: " + dr[2]);
                        Console.WriteLine("CourseId: " + dr[3]);
                    }
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
           

                ShowAdminScreen();
        }



        // Register students and Enroll in a course
        public void ShowStudentRegistrationScreen()
        {
            string cs = ConfigurationManager.ConnectionStrings["arun"].ConnectionString;
            SqlConnection c = null;
            try
            {
                using(c = new SqlConnection(cs))
                {
                    string query = "insert into student values(@id,@name,@dob,@courseid)";
                    SqlCommand cmd = new SqlCommand(query, c);
                    c.Open();
                    Console.Write("Enter Student ID: ");
                    int studentId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Student Name: ");
                    string studentName = Console.ReadLine();
                    Console.Write("Enter Student Date of Birth (yyyy-MM-dd): ");
                    DateTime studentDob = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter Course ID: ");
                    int courseId = Convert.ToInt32(Console.ReadLine());

                    cmd.Parameters.AddWithValue("@id", studentId);
                    cmd.Parameters.AddWithValue("@name", studentName);
                    cmd.Parameters.AddWithValue("@dob", studentDob);
                    cmd.Parameters.AddWithValue("@courseid", courseId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            


            Console.WriteLine("Student has been enrolled successfully.");

            ShowStudentScreen();
        }



        // Introduce new course
        public void IntroduceNewCourseScreen()
        {
            string cs = ConfigurationManager.ConnectionStrings["arun"].ConnectionString;
            SqlConnection c = null;
            try
            {
                using(c = new SqlConnection(cs))
                {
                    string query = "insert into course values(@id,@name)";
                    SqlCommand cmd = new SqlCommand(query, c);
                    c.Open();

                    Console.Write("Enter Course ID: ");
                    int courseId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Course Name: ");
                    string courseName = Console.ReadLine();

                    cmd.Parameters.AddWithValue("@id", courseId);
                    cmd.Parameters.AddWithValue("@name", courseName);
                    cmd.ExecuteNonQuery();

                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine("Course introduced successfully.");

            ShowAdminScreen();
        }



        //Display list of all courses
        public void ShowAllCoursesScreen()
        {
            string cs = ConfigurationManager.ConnectionStrings["arun"].ConnectionString;
            SqlConnection c = null;
            Console.WriteLine("List of Courses:");
            try
            {
                using (c = new SqlConnection(cs))
                {
                    string query = "select * from course";
                    SqlCommand cmd = new SqlCommand(query, c);
                    c.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("CourseId: " + dr[0]);
                        Console.WriteLine("CourseName: " + dr[1]);
                    }
                }

                ShowStudentScreen();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }



        //list of all enrollments
        public void ShowEnrollmentsScreen()
        {
            Console.WriteLine("List of Enrollments:");
            foreach (Enrollment enrollment in appEngine.ListOfEnrollments())
            {
                Console.WriteLine($"Student ID: {enrollment.Student.Id}, Student Name: {enrollment.Student.Name}, Course ID: {enrollment.Course.CourseId},Course Name: {enrollment.Course.CourseName}, Enrollment Date: {enrollment.EnrollmentDate}");
            }

            ShowAdminScreen();
        }



    }
}