using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes
{
  public class Company
  {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    public List<Employee> Employees { get; set; }

    public Company(string name, DateTime createdOn) {
      Name = name;
      CreatedOn = createdOn;
      Employees = new List<Employee>();
    }

    public void ListEmployees()
    {
      if(Employees.Count() == 0){
        Console.WriteLine("Hire some people!");
      }
      else
      {
        foreach(Employee Employee in Employees)
        {
          Console.WriteLine($"{Employee.FullName} works for {Name} as {Employee.Title} since {Employee.StartDate}");
        }
      }
    }

    // Create a public property for holding a list of current employees

    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties

    */
  }
}
