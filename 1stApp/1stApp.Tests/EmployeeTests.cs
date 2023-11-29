using System.Linq.Expressions;

namespace _1stApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenCalculatingStatisticsMax_ShouldReturnMax()
        {
            //arrange
            var employee1 = new Employee();
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(-10);
            //act
            var statistcs = employee1.GetStatistics();
            //assert
            Assert.AreEqual(2, statistcs.Max);
        }
        [Test]
        public void WhenCalculatingStatisticsMin_ShouldReturnMin()
        {
            //arrange
            var employee1 = new Employee("John", "Kowalski");
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(10);
            //act
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void WhenCalculatingStatisticsAverage_ShouldReturnAverage()
        {
            //arrange
            var employee1 = new Employee("John", "Kowalski");
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            //act
            var statistics = employee1.GetStatistics();
            //assert
            Assert.AreEqual(2, statistics.Average);
            Assert.That(statistics.Average, Is.EqualTo(2));
        }
        [Test]
        public void WhenUsingAddGradeMethodWithCharSwitch_ShouldReturnCorrectStatistics()
        {
            //arrange
            var employee1 = new Employee();
            employee1.AddGrade('a');
            employee1.AddGrade('B');
            employee1.AddGrade('C');
            employee1.AddGrade('d');
            employee1.AddGrade('E');
            //act
            var statistics = employee1.GetStatistics();
            //assert
            Assert.That(statistics.Average, Is.EqualTo(60));
        }
        [Test]
        public void WhenUsingStatisticsWithAverageLetter_ShouldReturnCorrectFinalGrade()
        {
            //arrange
            var employee1 = new Employee();
            employee1.AddGrade('a');
            employee1.AddGrade(10);
            employee1.AddGrade('R');
            employee1.AddGrade(20);
            employee1.AddGrade(-10);
            //act
            var statistics = employee1.GetStatistics();
            //assert
            Assert.That(statistics.AverageLetter, Is.EqualTo('C'));
        }
    }
}