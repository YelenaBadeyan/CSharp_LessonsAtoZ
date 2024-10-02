public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public string SSN {  get; set; }

    public Person(string name, int age, string SSN )
    {
        Name = name;
        Age = age;
        this.SSN = SSN;
    }

}
