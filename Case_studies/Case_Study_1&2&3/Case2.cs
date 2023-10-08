using System;
using Case_study_1; // Reference the Student class from CaseStudy1 namespace
using System.Collections.Generic;
using System.Linq;

namespace Case_Study_2
{
    public class Enroll
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            Student = student;
            Course = course;
            EnrollmentDate = enrollmentDate;
        }
    }
    public class AppEngine
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Enroll> enrollments = new List<Enroll>();

        public void Introduce(Course course)
        {
            courses.Add(course);
        }

        public void Register(Student student)
        {
            students.Add(student);
        }

        public Student[] ListOfStudents()
        {
            return students.ToArray();
        }

        public Course[] ListOfCourses()
        {
            return courses.ToArray();
        }

        public void Enroll(Student student, Course course)
        {
            DateTime enrollmentDate = DateTime.Now; // Assuming enrollment date is the current date
            enrollments.Add(new Enroll(student, course, enrollmentDate));
        }

        public Enroll[] ListOfEnrollments()
        {
            return enrollments.ToArray();
        }
    }
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }
    }

    public class App
    {
        static void Main(string[] args)
        {
            AppEngine appEngine = new AppEngine();

            Console.WriteLine("The Course Enrollment System");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Introduce Course");
                Console.WriteLine("2. Register Student");
                Console.WriteLine("3. Enroll Student in Course");
                Console.WriteLine("4. List Students");
                Console.WriteLine("5. List Courses");
                Console.WriteLine("6. List Enrollments");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice (1-7): ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the Course ID: ");
                            int courseId = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Course Name: ");
                            string courseName = Console.ReadLine();
                            appEngine.Introduce(new Course(courseId, courseName));
                            Console.WriteLine("Course have been introduced successfully.");
                            break;
                        case 2:

                            Console.WriteLine("\nScenario for student registration has to be choosen:");
                            Console.WriteLine("1. Scenario 1 (CaseStudy1)");
                            Console.WriteLine("2. Scenario 2 (CaseStudy1)");
                            Console.Write("Enter your choice (1-2): ");

                            if (int.TryParse(Console.ReadLine(), out int scenarioChoice))
                            {
                                if (scenarioChoice == 1 || scenarioChoice == 2)
                                {

                                    // student details to be entered
                                    Console.Write("Enter the Student ID: ");
                                    int studentId = int.Parse(Console.ReadLine());
                                    Console.Write("Enter Student Name: ");
                                    string studentName = Console.ReadLine();
                                    Console.Write("Enter Student Date of Birth (yyyy-MM-dd): ");
                                    DateTime studentDob = DateTime.Parse(Console.ReadLine());

                                    // Registering the student from CaseStudy1
                                    if (scenarioChoice == 1)
                                    {
                                        Case_study_1.App.Scenario1();
                                        Console.WriteLine("Student registration done successfully with Scenario 1.");
                                    }
                                    else if (scenarioChoice == 2)
                                    {
                                        Case_study_1.App.Scenario2();
                                        Console.WriteLine("Student registration done successfully with Scenario 2.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice.select a valid choice (1-2).");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid option.enter a numerical choice.");
                            }
                            break;

                        case 3:
                            Console.Write("Enter the Student ID: ");
                            int enrollStudentId = int.Parse(Console.ReadLine());
                            Console.Write("Enter the Course ID: ");
                            int enrollCourseId = int.Parse(Console.ReadLine());
                            Student enrollStudent = appEngine.ListOfStudents()
                                .FirstOrDefault(s => s.Id == enrollStudentId);
                            Course enrollCourse = appEngine.ListOfCourses()
                                .FirstOrDefault(c => c.CourseId == enrollCourseId);
                            if (enrollStudent != null && enrollCourse != null)
                            {
                                appEngine.Enroll(enrollStudent, enrollCourse);
                                Console.WriteLine("Student enrollment in the course done successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Student / course not found.register Student / course first.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("\nList of the Students:");
                            foreach (var student in appEngine.ListOfStudents())
                            {
                                Console.WriteLine("Student ID:" + student.Id, "Name:" + student.Name);
                            }
                            break;
                        case 5:
                            Console.WriteLine("\nList of Courses:");
                            foreach (var course in appEngine.ListOfCourses())
                            {
                                Console.WriteLine($"Course ID: {course.CourseId}, Name: {course.CourseName}");
                            }
                            break;
                        case 6:
                            Console.WriteLine("\nList of Enrollments:");
                            foreach (var enrollment in appEngine.ListOfEnrollments())
                            {
                                Console.WriteLine($"Student ID: {enrollment.Student.Id}, Course ID: {enrollment.Course.CourseId}, Enrollment Date: {enrollment.EnrollmentDate}");
                            }
                            break;
                        case 7:
                            Console.WriteLine("Exit the program.");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("choice is Invalid.select a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("input is Invalid.enter a numerical choice.");
                }
            }
            Console.ReadLine();
        }
    }
}