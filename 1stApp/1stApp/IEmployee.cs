using System.ComponentModel;

namespace _1stApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(decimal grade);
        void AddGrade(string grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
       Statistics GetStatistics();
    }
}
