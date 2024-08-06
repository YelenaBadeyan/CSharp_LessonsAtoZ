using System;
using System.Collections;
using System.Collections.Generic;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimatable<Animal> animal1 = new Animatable<Animal>();
            IAnimatable<Animal> animal2 = new Animatable<Dog>(); // Not an error due to covariance
            //IAnimatable<Dog> animal3 = new Animatable<Animal>(); // Error
            IAnimatable<Dog> animal4 = new Animatable<Dog>();
            Test(new Animatable<Animal>());
            Test(new Animatable<Dog>());
            List<Dog> animals = new List<Dog>();
            animals.Add(new Dog());
            animals.Add(new Dog());
            animals.Add(new Dog());
            MakeALotOfNoises(animals.GetEnumerator());
        }

        public static void Test(IAnimatable<Animal> o)
        {
            o.Get().MakeNoise();
        }

        public static void MakeALotOfNoises(IEnumerator<Animal> i)
        {
            while (i.MoveNext())
            {
                i.Current.MakeNoise();
            }
        }
    }


    public class Animal
    {
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal noises");
        }
    }

    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Dog noises");
        }
    }

    interface IAnimatable<out T>
    {
        public T Get();

    }

    public class Animatable<T> : IAnimatable<T> where T : new()
    {
        public T Get()
        {
            return new T();
        }

    }

}