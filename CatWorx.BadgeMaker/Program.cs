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
  class Program
  {
    // Main is the entry point of a C# application. It is the first method that is called when the program is run.
    // In order for Main() to be recognized as the program's entry point, the following syntax guidelines must be followed:
    // Main() must be nested in a class.
    // There can only be one entry point to a program.
    // The keyword void signifies that the return of this executable method will be void.
    // The keyword static implies that the scope of this method is at the class level, not the object level, and can thus 
    // be invoked without having to first create a new class instance. Hence the Main() method can be run as soon as the program runs.
    static void Main(string[] args)
    {
        // string greeting = "Hello, World!";
        // greeting = greeting + " I am a C# programmer now!";
        // Console.WriteLine("greeting: {0}", greeting);

        // float side = 3.14f;
        // float area = side * side;
        // Console.WriteLine($"The Area of the square is: {area}, the side is: {side}, and the type is: {side.GetType()}");

        // bool isCold = true;
        // Console.WriteLine(isCold ? "drink" : "add ice");  // output: drink
        // Console.WriteLine(!isCold ? "drink" : "add ice");  // output: add ice

        // string Num = "2";
        // int intNum = Convert.ToInt32(Num);
        // Console.WriteLine(intNum);


        // dictionary by listing the key-value pairs in a function call.
        // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
        //     { "firstInning", 10 },
        //     { "secondInning", 20},
        //     { "thirdInning", 30},
        //     { "fourthInning", 40},
        //     { "fifthInning", 50}
        // };

        // Console.WriteLine("----------------");
        // Console.WriteLine("  Scoreboard");
        // Console.WriteLine("----------------");
        // Console.WriteLine("Inning |  Score");
        // Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
        // Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
        // Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
        // Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
        // Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);


        // To declare an array in C#, we must declare the data type and size, as shown in the following code block:
        // Thus, just as in JavaScript, we can access the array using [] and the array's index.
        // string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
        // string firstFood = favFoods[0];
        // string secondFood = favFoods[1];
        // string thirdFood = favFoods[2];
        // Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);


        //lists
        List<string> employees = new List<string>() { "adam", "amy" };
        employees.Add("barbara");
        employees.Add("billy");
        for (int i = 0; i < employees.Count; i++) 
        {
        Console.WriteLine(employees[i]);
        }
    }
  }
}