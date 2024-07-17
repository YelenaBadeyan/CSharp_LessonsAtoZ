namespace University;

public class Student : Person
{
    public double TestScore { get; private set; }
    public bool HasDiploma { get; private set; }

    public Student(string name, int id, double testScore) : base(name, id)
    {
        TestScore = testScore;
        HasDiploma = false;
    }

    public void AssignDiploma()
    {
        HasDiploma = true;
    }
}