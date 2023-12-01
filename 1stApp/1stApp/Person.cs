namespace _1stApp
{
    public abstract class Person
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person(string name, string surname, int age, char gender)
            :this(name, surname )
        {
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public char Gender { get; private set; }
    }
    
}
