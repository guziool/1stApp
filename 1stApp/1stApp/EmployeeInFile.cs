using System.Reflection.Metadata.Ecma335;

namespace _1stApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        private List<float> grades = new List<float>();
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }
        public override event GradeAddedDelegate GradeAdded;
        public  virtual void ClearContent()
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    if (GradeAdded != null)
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
            var result = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                        result.Average = grades.Average();
                        result.Max = grades.Max();
                        result.Min = grades.Min();
                        result.Counter = this.grades.Count;
                        switch (result.Average)
                        {
                            case var average when average >= 80:
                                result.AverageLetter = 'A';
                                break;
                            case var average when average >= 60:
                                result.AverageLetter = 'B';
                                break;
                            case var average when average >= 40:
                                result.AverageLetter = 'C';
                                break;
                            case var average when average >= 20:
                                result.AverageLetter = 'D';
                                break;
                            default:
                                result.AverageLetter = 'E';
                                break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
