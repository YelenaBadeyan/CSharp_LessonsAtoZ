namespace University;

public class Employee : Person
{
    public double Salary { get; private set; }

    public Employee(string name, int id, double salary) : base(name, id)
    {
        Salary = salary;
    }
}