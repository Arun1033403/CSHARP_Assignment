using System;

using System.Collections.Generic;

using System.Linq;



class Emp

{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string DOB { get; set; }
    public string DOJ { get; set; }
    public string City { get; set; }

}



class Solution_3

{

    static void Main(string[] args)

    {

        // Create a List of Employee objects and populate it

        List<Emp> empList = new List<Emp>

        {

            new Emp { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = "16/11/1984", DOJ = "8/6/2011", City = "Mumbai" },

            new Emp { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984", DOJ = "7/7/2012", City = "Mumbai" },

            new Emp { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = "14/11/1987", DOJ = "12/4/2015", City = "Pune" },

            new Emp { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = "3/6/1990", DOJ = "2/2/2016", City = "Pune" },

            new Emp{ EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = "8/3/1991", DOJ = "2/2/2016", City = "Mumbai" },

            new Emp { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = "7/11/1989" , DOJ = "8/8/2014", City = "Chennai" },

            new Emp { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = "2/12/1989", DOJ = "1/6/2015", City = "Mumbai" },

            new Emp { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = "11/11/1993", DOJ = "6/11/2014", City = "Chennai" },

            new Emp { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = "12/8/1992" , DOJ = "3/12/2014", City = "Chennai" },

            new Emp { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = "12/4/1991", DOJ = "2/1/2016", City = "Pune" }

        };



                         // a. Displaying the details of all employees

        Console.WriteLine("a. Details of all employees:");

        foreach (var emp in empList)

        {

            Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");

        }



                         // b. Display the details of all the employees whose location is not Mumbai

        Console.WriteLine("\nb. Details of employees whose location is not Mumbai:");

        var employeesNotInMumbai = empList.Where(emp => emp.City != "Mumbai");

        foreach (var emp in employeesNotInMumbai)

        {

            Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");

        }



                         // c. Displaying the details of all the employees whose title is AsstManager

        Console.WriteLine("\nc. Details of employees whose title is AsstManager:");

        var asstManagers = empList.Where(emp => emp.Title == "AsstManager");

        foreach (var emp in asstManagers)

        {

            Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");

        }

        Console.WriteLine("\nd. Details of the employees where Last Name starts with S:");

        var employeesWithLastNameStartingWithS = empList.Where(emp => emp.LastName.StartsWith("S", StringComparison.OrdinalIgnoreCase));

        foreach (var emp in employeesWithLastNameStartingWithS)

        {

            Console.WriteLine($"Employee ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, DOB: {emp.DOB}, DOJ: {emp.DOJ}, City: {emp.City}");

        }
        Console.ReadLine();

    }

}
