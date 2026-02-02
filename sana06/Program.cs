using Sana06;
using System;
using System.Text;

namespace Sana06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

          
            Shape[] shapes = new Shape[5];

            shapes[0] = new Circle(4.0);
            shapes[1] = new Rectangle(5.0, 10.0);
            shapes[2] = new Triangle(3.0, 4.0, 5.0);
            shapes[3] = new Circle(2.5);
            shapes[4] = new Rectangle(7.0, 7.0);

            Console.WriteLine("=== Всі фігури ===\n");

            foreach (var s in shapes)
            {
                s.GetInfo();
            }

           
            Shape maxShape = shapes[0];
            foreach (var s in shapes)
            {
                if (s.CalculateArea() > maxShape.CalculateArea())
                    maxShape = s;
            }

            Console.WriteLine("\n=== Фігура з найбільшою площею ===");
            maxShape.GetInfo();

            Console.ReadLine();
        }
    }
}