using System;

public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }
}

public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Chirp! Chirp!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.MakeSound();

        Animal cat = new Cat();
        cat.MakeSound();

        Animal bird = new Bird();
        bird.MakeSound();
    }
}