namespace _1stApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)

        {
            this.Surname = surname;
            this.Name = name;
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
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
        public void AddGrade(char grade)
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
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    this.AddGrade(95);
                    break;
                case "5+":
                case "+5":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5-":
                case "-5":
                    this.AddGrade(75);
                    break;
                case "4+":
                case "+4":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "4-":
                case "-4":
                    this.AddGrade(55);
                    break;
                case "3+":
                case "+3":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3-":
                case "-3":
                    this.AddGrade(35);
                    break;
                case "2+":
                case "+2":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2-":
                case "-2":
                    this.AddGrade(15);
                    break;
                case "1+":
                case "+1":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
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
                        throw new Exception("Wrong grade, it's out of scope");
                    }
                    break;
            }
        }
        public Statistics GetStatistics()
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
                    ;
            }
            return statistics;
        }
    }
}
