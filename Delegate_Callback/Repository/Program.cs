public class Program
{
    public static void Main(string[] args)
    {
        PeopleRepository repository = new PeopleRepository();

        Person person1 = new Person("Ani", 30, "263759394");
        Person person2 = new Person("Hasmik", 25, "737462392");
        Person person3 = new Person("Armen", 45, "77472849482");
        Person person4 = new Person("Robert", 45, "77472849482");
        Person person5 = new Person("Hayk", 45, "77472849482");
        Person person7 = new Person("Lilith", 45, "77472849482");


        repository.AddPerson(person1);
        repository.AddPerson(person2);
        repository.AddPerson(person3);


        repository.ListPeople();
    }
}