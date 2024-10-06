using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Constructor Inheritance
namespace ConsoleApp1
{
    //Creating a class Person with properties like FirstName, LastName, and Age
    class Person
    {
        //properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            FirstName = name;
            LastName = name;
            Age = age;
        }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string JobTitle { get; set; }

        //useing the base class person  constructor to initialize First name and Last name
        public Employee(string name, int age, int employeeId , string jobTitle) : base(name, age)
        {
            EmployeeId = employeeId;
            JobTitle = jobTitle;
        }
    }
}
