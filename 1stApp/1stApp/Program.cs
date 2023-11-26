using _1stApp;

var employee1 = new Employee("Stefan", "Kowalski");
employee1.AddGrade(1);
employee1.AddGrade(2);
employee1.AddGrade(-10);
//employee1.AddGrade(3);
var statistics = employee1.GetStatistics();
var statistics2 = employee1.GetStatistics2();
Console.WriteLine($"Tatal number of grades: {statistics.Counter}, secondary methed: {statistics2.Counter}" );
Console.WriteLine($"Average: {statistics.Average:N2}, secondary method: {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}, secondary method: {statistics2.Max}");
Console.WriteLine($"Min: {statistics.Min}, secondary method: {statistics2.Min}");
