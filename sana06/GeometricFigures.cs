using System;

namespace Sana06
{
   
    public class Circle : Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r > 0 ? r : 1;
        }

        public override double CalculateArea() => Math.PI * radius * radius;
        public override double CalculatePerimeter() => 2 * Math.PI * radius;

        public override void GetInfo()
        {
            Console.WriteLine($"Фігура: Коло | Радіус: {radius}");
            Console.WriteLine($"Площа: {CalculateArea():F2} | Периметр: {CalculatePerimeter():F2}");
            Console.WriteLine(new string('-', 40));
        }
    }

   
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h)
        {
            width = w > 0 ? w : 1;
            height = h > 0 ? h : 1;
        }

        public override double CalculateArea() => width * height;
        public override double CalculatePerimeter() => 2 * (width + height);

        public override void GetInfo()
        {
            Console.WriteLine($"Фігура: Прямокутник | {width} x {height}");
            Console.WriteLine($"Площа: {CalculateArea():F2} | Периметр: {CalculatePerimeter():F2}");
            Console.WriteLine(new string('-', 40));
        }
    }

 
    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA; b = sideB; c = sideC;
        }

        public override double CalculatePerimeter() => a + b + c;

        public override double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Фігура: Трикутник | Сторони: {a}, {b}, {c}");
            Console.WriteLine($"Площа: {CalculateArea():F2} | Периметр: {CalculatePerimeter():F2}");
            Console.WriteLine(new string('-', 40));
        }
    }
}