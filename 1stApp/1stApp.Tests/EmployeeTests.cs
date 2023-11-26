using System.Linq.Expressions;

namespace _1stApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenCalculatingStatisticsMax_ShouldReturnMax()
        {
            //arrange
            var employee1 = new Employee("John", "Kowalski");
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
            employee1.AddGrade(-10);
            //act
            //var statistics = employee1.GetStatistics();
            var statistics2 = employee1.GetStatistics2();
            //assert
            Assert.AreEqual(-10, statistics2.Min);
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
    }
}