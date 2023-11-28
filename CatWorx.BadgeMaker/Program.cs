//  C# is a statically typed language. This means that the data type is explicitly labeled when a variable is declared.

// using directive lets us use the corresponding namespace (System) without needing to qualify its use 
// when using one of its members. For example, without this naming shortcut, every time Console is used, 
// it would need to be preceded by System and a period.
// The System namespace is part of the .NET framework. It is a collection of commonly used methods, 
// data types, and data structures, which are the essential building blocks of a C# application.
using System;
// To use a dictionary, you must first import the System.Collections.Generic namespace.
// lists are located in the System.Collections.Generic
using System.Collections.Generic;


// setting called implicit usings, which allows us to use the System namespace without the using directive.
// These are included in that setting using System; using System.IO; using System.Collections.Generic; 
// using System.Linq; using System.Net.Http; using System.Threading; using System.Threading.Tasks;
// Even though these directives are implicitly included with the default settings, they will be 
// included in the code snippets. This inclusion will be for reference and so that if you change 
// this setting your code will still work.


// A namespace is a collection of classes, interfaces, structs, enums, and delegates.
// Namespaces are used to organize and provide a level of separation in the code
// Common C# conventions are to use a company name for the root namespace in order to ensure that it is unique.
namespace CatWorx.BadgeMaker
{
    // A class is a blueprint for an object. It defines the data and behavior of the object.
    // Program is a class containing the program’s Main() entry point method
 class Program
{
  
  static List<Employee> GetEmployees()
  {
    List<Employee> employees = new List<Employee>();
    while (true)
    {

      Console.WriteLine("Please enter a name: (leave empty to exit): ");

      // change input to firstName
      string firstName = Console.ReadLine() ?? "";

      if (firstName == "")
      {
        break;
      }

      // add a Console.ReadLine() for each value
      Console.Write("Enter last name: ");
      string lastName = Console.ReadLine() ?? "";
      Console.Write("Enter ID: ");
      int id = Int32.Parse(Console.ReadLine() ?? "");
      Console.Write("Enter Photo URL:");
      string photoUrl = Console.ReadLine() ?? "";
      Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
      employees.Add(currentEmployee);
    }
    return employees;
  }

  //any method that does not return a value must be defined to return void.
  static void PrintEmployees(List<Employee> employees)
  {
    //  (argument {0}), the id, to be left-aligned and padded to at least 10 characters, so we enter {0,-10}. 
    //  Then we want to print a tab character (\t). We want the next argument ({1}), the name, to be left-aligned and padded to 20 characters—hence {1,-20}.
    //  Next, we want to print another tab character (\t). And finally, we want to print the last argument ({2}), the photo URL, with no formatting: {2}.
    for (int i = 0; i < employees.Count; i++) 
    {
      string template = "{0,-10}\t{1,-20}\t{2}";
      Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
    }
  }

  

  static void Main(string[] args)
  {
    List<Employee> employees = GetEmployees();
    PrintEmployees(employees);
  }
}
}