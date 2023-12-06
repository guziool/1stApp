using _1stApp;
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
//var employee1 = new Employee("Jan", "Kowalski");
var supervisor1 = new Supervisor("Ala", "Kot");
Console.Write("Type the supervisor's grade: ");
var firstinput = Console.ReadLine();
try
{
    supervisor1.AddGrade(firstinput);
}
catch (Exception exep)
{
    Console.WriteLine($"Processing failed: {exep.Message}");
}
while (true)
{
    Console.Write("Type the next supervisor's grade or quit program by typing q: ");
    var input = Console.ReadLine();
    if (input.ToLower() == "q")
    {
        break;
    }
    try
    {
        supervisor1.AddGrade(input);
    }
    catch(Exception exep)
    {
        Console.WriteLine($"Processing failed: {exep.Message}");
    }
};
var statistcs = supervisor1.GetStatistics();
Console.WriteLine();
Console.WriteLine("Supervisor evaluation results: ");
Console.WriteLine("##################################################");
Console.WriteLine($"No of grades: {statistcs.Counter}");
Console.WriteLine($"AVG: {statistcs.Average}");
Console.WriteLine($"Max: {statistcs.Max}");
Console.WriteLine($"Min: {statistcs.Min}");
Console.WriteLine("##################################################");
Console.WriteLine($"Final Grade: {statistcs.AverageLetter}");

