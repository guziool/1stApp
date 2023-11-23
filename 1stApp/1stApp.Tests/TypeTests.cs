namespace _1stApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenComparingReferencaVariables_ShouldReturnNotEqal()
        {
            //arrange
            var employee1 = GetEmployee("Reksio", 20);
            var employee2 = GetEmployee("Bonifacy", 30);
            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
        [Test]
        public void WhenComparingObjectsIntegerValues_ShouldReturnEqal()
        {
            //arrange
            var employee1 = GetEmployee("Reksio", 20);
            var employee2 = GetEmployee("Bonifacy", 20);
            int number = 20;
            //assert
            Assert.AreEqual(employee1.Age, employee2.Age, number);
        }
        [Test]
        public void WhenComparingObjectStringValues_ShouldReturnEquale()
        {
            //arrange
            var employee1 = GetEmployee("Reksio", 30);
            var employee2 = GetEmployee("Reksio", 20);
            string Name = "Reksio";
            //assert
            Assert.AreEqual(employee1.Name, employee2.Name, Name);
        }
            private Employee GetEmployee(string name, int age)
        {
            return new Employee(name,age);
        }
    }
}
