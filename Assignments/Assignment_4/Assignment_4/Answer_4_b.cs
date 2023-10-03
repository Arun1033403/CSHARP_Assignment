using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Candidate
    {
        private int rollno;
        private string name;
        private string class_;
        private int semester;
        private string branch;
        private int[] marks = new int[5];

        public Candidate(int rollno, string name, string class_, int semester, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.class_ = class_;
            this.semester = semester;
            this.branch = branch;
        }

        public void GetMarks()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the marks {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Result()
        {
            double average = ( (marks[0] + marks[1] + marks[2] + marks[3] + marks[4]) / 5.0);

            bool failedSub = false;
            foreach (int marks in marks)
            {
                if (marks < 35)
                {
                    failedSub = true;
                    break;
                }
            }

            if (failedSub || average < 50)
            {
                Console.WriteLine("Results-FAIL");
            }
            else
            {
                Console.WriteLine("Results-PASS");
            }

            Console.WriteLine($"RollNo: {rollno}");
            Console.ReadLine();
            Console.WriteLine($"Name: {name}");
            Console.ReadLine();
            Console.WriteLine($"Class: {class_}");
            Console.ReadLine();
            Console.WriteLine($"Sem: {semester}");
            Console.ReadLine();
            Console.WriteLine($"Branch: {branch}");
            Console.ReadLine();
            Console.WriteLine($"Marks: {string.Join(", ", marks)}");
            Console.ReadLine();
            Console.WriteLine($"Average: {average}");
            Console.ReadLine();
        }
    }

    class Prg
    {
        static void Main()
        {
            Candidate student1 = new Candidate(111, "Arun", "ECE", 8, "Citech");
            student1.GetMarks();
            student1.Result();
        }
    }
}