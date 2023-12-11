namespace _1stApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
        public override event GradeAddedDelegate GradeAdded;
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public override void AddGrade(double grade)
        {
            float gradeInDouble = (float)grade;
            this.AddGrade(gradeInDouble);
        }

        public override void AddGrade(decimal grade)
        {
            float gradeInDecimal = (float)grade;
            this.AddGrade(gradeInDecimal);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charresult))
            {
                this.AddGrade(charresult);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeInInt = (float)grade;
            this.AddGrade(gradeInInt);
        }

        public override void AddGrade(char grade)
        {
            switch (char.ToLower(grade))
            {
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter, only A/a, B/b, C/c, D/d, or E/e can be used");
            }
        }

        public override Statistics GetStatistics()
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
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
