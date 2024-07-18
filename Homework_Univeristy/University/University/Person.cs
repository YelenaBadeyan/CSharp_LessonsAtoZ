namespace University;

public class Person
{
    public string Name { get; private set; }
    public int ID { get; private set; }

    public Person(string name, int id)
    {
        Name = name;
        ID = id;
    }
}