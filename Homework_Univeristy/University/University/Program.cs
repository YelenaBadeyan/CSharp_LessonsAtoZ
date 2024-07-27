using System;
using System.Data;

namespace Casting

{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string Name, int age)
        {
            this.Name = Name;
            Age = age;
        }

        public Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Yelena", 34);
            Console.WriteLine(person.Name);

            Person personClone = person.Clone();
            person.Name = "Armen";
            Console.WriteLine(personClone.Name);


        }
    }
}

