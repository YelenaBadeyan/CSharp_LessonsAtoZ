using System;
using System.Collections.Generic;

public class PeopleRepository
{
    private List<Person> people;

    public PeopleRepository()
    {
        people = new List<Person>
        {
            new Person("Ani", 30, "263759394"),
            new Person("Hasmik", 25, "737462392"),
            new Person("Armen", 45, "77472849482"),
            new Person("Robert", 45, "77472849482"),
            new Person("Hayk", 45, "77472849482"),
            new Person("Lilith", 45, "77472849482")
        };
    }

    public void AddPerson(Person person)
    {
        people.Add(person);
        Console.WriteLine($"{person.Name} added to the repository.");
    }

    public void ListPeople()
    {
        Console.WriteLine("Listing all people in the repository:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}
