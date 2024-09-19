using System;

namespace MyCutomDictionary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myDict = new Dictionary<string, Student>();
            myDict.Add("John", new Student{Grade = 85, Id = 1, Name = "John" });
            myDict.Add("Alice", new Student { Grade = 90, Id = 2, Name = "Alice" });
            myDict.Add("Bob", new Student { Grade = 78, Id = 3, Name = "Bob" });
        

            foreach (var item in myDict)
            {
                Console.WriteLine($"Name: {item.Value.Name}, Id: {item.Value.Id}, Grade: {item.Value.Grade}");
            }
        }
    }
}