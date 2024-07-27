using System;

namespace Casting
{
    public class Vehicle
    {
        public int Year { get; set; }
        public string Mark { get; set; }

        public Vehicle( int year, string mark)
        {
            Year = year;
            Mark = mark;
        }
        public virtual void Description()
        {
            Console.WriteLine("This is a Vehicle and the parameters are" +  ' ' + this.Mark + ' ' + this.Year);
        }
    }

    public class Car : Vehicle
    {
        public int  Speed { get; set; }

        public Car(int year, string mark, int speed) : base(year, mark)
        {
            this.Speed = speed;
        }

        public override void Description()
        {
            Console.WriteLine("This is a Car and the parameters are" +' '+this.Speed + ' ' + this.Mark + ' ' + this.Year);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(2024, "Test");
            Console.WriteLine("This is a base class instance result");
            vehicle.Description();

            Car car = new Car(2023, "Test2", 6);
            Console.WriteLine("This is a child class instance result");
            car.Description();

            Console.WriteLine("After casting Car to Vehicle");
            Vehicle newVehicle = car;
            newVehicle.Description();

            Console.WriteLine("After casting Vehicle to Car");
            Car newCar = (Car)vehicle;
            newCar.Description();

        }
    }
}