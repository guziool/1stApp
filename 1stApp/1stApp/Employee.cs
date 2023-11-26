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
            this.grades.Add(grade);
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
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;
            statistics2.Counter = this.grades.Count;
            foreach (var grade in this.grades)
            {
                statistics2.Min = Math.Min(statistics2.Min, grade);
                statistics2.Max = Math.Max(statistics2.Max, grade);
                statistics2.Average += grade;

            }
            statistics2.Average /= this.grades.Count;
            return statistics2;
        }
    }
}
