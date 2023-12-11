using _1stApp;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
Console.WriteLine("##################################################");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.WriteLine("#   Welcome to the employee evaluation program   #");
Console.WriteLine("#                                                #");
Console.WriteLine("#                                                #");
Console.WriteLine("##################################################");
Console.WriteLine();
var employee1 = new EmployeeInFile("Jan", "Kowalski");
employee1.ClearContent();
employee1.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("New grade added!");
}

Console.Write("Type the employee's grade: ");
var firstinput = Console.ReadLine();
try
{
    employee1.AddGrade(firstinput);
}
catch (Exception exep)
{
    Console.WriteLine($"Processing failed: {exep.Message}");
}

while (true)
{
    Console.Write("Type the next employee's grade or quit program by typing q: ");
    var input = Console.ReadLine();
    if (input.ToLower() == "q")
    {
        break;
    }
    try
    {
        employee1.AddGrade(input);
    }
    catch (Exception exep)
    {
        Console.WriteLine($"Processing failed: {exep.Message}");
    }
};
//employee1.AddGrade("A");
//employee1.AddGrade('b');
//employee1.AddGrade(80);
//employee1.AddGrade(100);
//employee1.AddGrade(90);
//employee1.AddGrade(5f);
//employee1.AddGrade(5);
var statistcs = employee1.GetStatistics();
Console.WriteLine();
Console.WriteLine("Employee evaluation results: ");
Console.WriteLine("##################################################");
Console.WriteLine($"No of grades: {statistcs.Counter}");
Console.WriteLine($"AVG: {statistcs.Average:N2}");
Console.WriteLine($"Max: {statistcs.Max}");
Console.WriteLine($"Min: {statistcs.Min}");
Console.WriteLine("##################################################");
Console.WriteLine($"Final Grade: {statistcs.AverageLetter}");

