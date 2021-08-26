using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company plumbus = new Company("Plumbus, Inc.", new DateTime(2020, 1, 1));

            // Create three employees
            Employee rick = new Employee("Rick", "Sanchez", "CTO", new DateTime(2020, 1, 1));

            Employee morty = new Employee("Morty", "Smith", "Side-Kick", new DateTime(2020, 1, 1));

            Employee beth = new Employee("Beth", "Smith", "CEO", new DateTime(2020, 1, 1));


            // Assign the employees to the company

            plumbus.Employees.Add(rick);
            plumbus.Employees.Add(morty);
            plumbus.Employees.Add(beth);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            plumbus.ListEmployees();
        }
    }
}
