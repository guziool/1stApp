using System.Runtime.CompilerServices;

namespace _1stApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(long grade)
        {
            float gradeInLong = (float)grade;
            this.AddGrade(gradeInLong);
        }
        public void AddGrade(double grade)
        {
            float gradeInDouble = (float)grade;
            this.AddGrade(gradeInDouble);
        }
        public void AddGrade(int grade)
        {
            float gradeInInt = (float)grade;
            this.AddGrade(gradeInInt);
        }
        public void AddGrade(decimal grade)
        {
            float gradeInDecimal = (float)grade;
            this.AddGrade(gradeInDecimal);
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Counter = this.grades.Count;
            statistics.Max = this.grades.Max();
            statistics.Min = this.grades.Min();
            statistics.Average = this.grades.Average();
            return statistics;
        }
        public Statistics GetStatistics2()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Counter = this.grades.Count;
            foreach (var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;

            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
