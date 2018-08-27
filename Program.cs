using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company myCompany = new Company("Ducks", new DateTime(1990, 1, 1));

            myCompany.Employees.Add(new Employee()
            {
                FirstName = "Goose",
                LastName = "Silver",
                Title = "Captain",
                StartDate = new DateTime(1990, 1, 1)
            });

            myCompany.Employees.Add(new Employee()
            {
                FirstName = "John",
                LastName = "Tuck",
                Title = "FirstMate",
                StartDate = new DateTime(1993, 1, 1)
            });

            myCompany.Employees.Add(new Employee()
            {
                FirstName = "French",
                LastName = "Made",
                Title = "Grunt",
                StartDate = new DateTime(1998, 3, 10)
            });

            myCompany.listEmployees();


        }
    }

    class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }
    }

    class Company
    {
        public Company(string name, DateTime founded)
        {
            this.FoundedDate = founded;
            this.CompanyName = name;
            this.Employees = new List<Employee>();
        }
        public DateTime FoundedDate { get; }

        public string CompanyName { get; }

        public List<Employee> Employees { get; set; }

        public void listEmployees()
        {
            Employees.ForEach(employee =>
            {
                Console.WriteLine($"The {employee.Title}, {employee.FirstName} {employee.LastName}, has been working for {CompanyName} since {employee.StartDate}.");
            });

        }

    }
}
