using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);

        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle { Width = 10, Height = 5 };
            Console.WriteLine(rectangle.CalculateArea());

            Circle circle = new Circle { Radius = 4.5};
            Console.WriteLine(circle.CalculateArea());


        }
    }
}
