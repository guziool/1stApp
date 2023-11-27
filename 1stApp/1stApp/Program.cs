using _1stApp;

var employee1 = new Employee("Stefan", "Kowalski");
employee1.AddGrade("Adam");
employee1.AddGrade("101");
employee1.AddGrade(10);
employee1.AddGrade(100);
employee1.AddGrade(0.004);
var statistics = employee1.GetStatistics();
Console.WriteLine($"Tatal number of grades: {statistics.Counter}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
