using System.Linq.Expressions;

namespace _1stApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeePositiveScoresAdded_ShouldReturnPositiveSum()
        {
            //arrange
            var employee1 = new Employee("John", "Kowalski", 18);
            employee1.AddScore(1);
            employee1.AddScore(2);
            employee1.AddScore(10);
            //act
            var result = employee1.Result;
            //assert
            Assert.AreEqual(13, result);
        }
        [Test]
        public void WhenEmployeePositiveNegativeScoresAdded_ShouldReturnSum()
        {
            //arrange
            var employee2 = new Employee("Mis", "Puchatek", 6);
            employee2.AddScore(-1);
            employee2.AddScore(2);
            employee2.AddScore(10);
            //act
            var result = employee2.Result;
            //assert
            Assert.AreEqual(11, result);
        }
        [Test]
        public void WhenEmployeePositiveNegativeScoresAddedEqualZero_ShouldReturn0()
        {
            //arrange
            var employee3 = new Employee("Krol", "Macius", 1);
            employee3.AddScore(2);
            employee3.AddScore(3);
            employee3.AddScore(-5);
            //act
            var result = employee3.Result;
            //assert
            Assert.AreEqual(0, result);
        }
    }
}