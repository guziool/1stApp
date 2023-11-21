using _1stApp;

Employee employee1 = new Employee("Bartosz", "Zmarzlik", 30);
Employee employee2 = new Employee("Janusz", "Kolodziej", 40);
Employee employee3 = new Employee("Patryk", "Dudek", 25);

employee1.AddScore(5);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(7);

employee2.AddScore(5);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(1);

employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(7);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

List<Employee> employees2 = new List<Employee>();

int maxValue = -1;
Employee maxScoredEmployee = null;




foreach (var emp in employees)
{
    if (emp.Result > maxValue)
    {
        maxScoredEmployee = emp;
        maxValue = emp.Result;
        employees2.Clear();
    }
    if ( emp.Result == maxValue)
    {
        employees2.Add(emp);
    }
}
int counter = employees2.Count;

if (counter > 1) 
{
    Console.WriteLine("We have winners:");
    foreach (var emp2 in employees2)
    {
        Console.WriteLine($"{emp2.Name} {emp2.Surname} age: {emp2.Age}");
    }
    Console.WriteLine("With highest score: " + maxValue);
} 
else
Console.WriteLine($"The highest scored employee is {maxScoredEmployee.Name} {maxScoredEmployee.Surname} Age: {maxScoredEmployee.Age} with score: {maxScoredEmployee.Result}");
