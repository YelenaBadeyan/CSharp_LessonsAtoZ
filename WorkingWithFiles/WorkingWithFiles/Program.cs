using System;
using System.IO;

class Person : IDisposable
{
    public string Name { get; set; }
    public int Age { get; set; }
    private StreamWriter _writer;
    private string _filePath;

    public Person(string name, int age, string filePath)
    {
        Name = name;
        Age = age;
        _filePath = filePath;
        _writer = new StreamWriter(_filePath, true);
    }

    public void SaveToFile()
    {
        string personInfo = $"Name: {Name}, Age: {Age}";
        _writer.WriteLine(personInfo);
        Console.WriteLine($"Person saved: {personInfo}");
    }

    public void Dispose()
    {
        if (_writer != null)
        {
            _writer.Dispose();
            Console.WriteLine("File stream closed.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // the custom path for the file
        string customPath = @"C:\Users\Yelena.Badeyan\Downloads\Person.txt";

        using (Person person1 = new Person("Mery", 30, customPath))
        {
            person1.SaveToFile();
        }

        using (Person person2 = new Person("Jane", 25, customPath))
        {
            person2.SaveToFile();
        }

        Console.WriteLine("All persons' information saved.");

        //second part

        Console.WriteLine("Reading from the file");

        using (var file = File.OpenText(customPath))
        {
            var fileContent = file.ReadToEnd();
            Console.WriteLine(fileContent);
        }
    }
}
