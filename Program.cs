using System;
using System.Collections.Generic;

namespace _1_06.List_Employees_Working_at_a_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like
            Company puppy = new Company("Puppy Ltd.", SetDateTime("01/01/2010"));

            // Create three employees and assign them to the company
            puppy.AddEmployee(new Employee("Joey", "Tribbiani", "Chief Medical Officer", SetDateTime("4/23/18")));
            puppy.AddEmployee(new Employee("Chandler", "Bing", "IT Procurements Manager", SetDateTime("11/09/11")));
            puppy.AddEmployee(new Employee("Rachael", "Green", "Chief Fashion Officer", SetDateTime("1/15/14")));

            // Iterate the company's employee list and generate the simple report shown above
            puppy.ListEmployees();
        }

        static DateTime SetDateTime( string data )
        {
            // public static bool TryParse (string s, out DateTime result);
            DateTime date = new DateTime();
            DateTime.TryParse( data, out date);
            return date;
        }
    }
}