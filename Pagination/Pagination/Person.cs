namespace Pagination
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }

        public Person(int id, string name, int age, string ssn)
        {
            Id = id;
            Name = name;
            Age = age;
            SSN = ssn; 
        }

    }
}