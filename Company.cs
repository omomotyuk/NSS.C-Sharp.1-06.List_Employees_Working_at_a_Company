using System;
using System.Collections.Generic;

namespace _1_06.List_Employees_Working_at_a_Company
{
    public class Company
    {
        /*
            Create a custom type for Company. A company has the following properties.
            Date founded (DateTime)
            Company name (string)
            Employees (List<Employee>)
        */
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }
        // Create a public property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
        public Company( string name, DateTime date )
        {
            Name = name;
            CreatedOn = date;
        }
        public void AddEmployee( Employee employee )
        {
            Employees.Add(employee);
        }
        //The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
        public void ListEmployees()
        {
            foreach( Employee employee in Employees )
            {
                Console.Write(
                    $"{employee.FirstName} {employee.LastName} works for {Name} " +
                    $"as {employee.Title} since {employee.StartDate.ToShortDateString()}\n"
                );
            }
        }
    }
}