using System;

namespace _1_06.List_Employees_Working_at_a_Company
{
    public class Employee
    {
        /*
            Create a custom type for Employee. An employee has the following properties.
            First name (string)
            Last name (string)
            Title (string)
            Start date (DateTime)
        */
        public string FirstName {get;}
        public string LastName {get;}
        public string Title {get;}
        public DateTime StartDate {get;}
        public Employee( string firstName, string lastName, string title, DateTime startDate )
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = startDate;
        }
    }
}
