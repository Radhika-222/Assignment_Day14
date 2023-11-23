using ShapeAreaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter shape type:1.Rectangle 2.Square 3.Circle 4.Triangle ");
            string shapeType = Console.ReadLine();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            double area = 0.0;

            switch (shapeType)
            {
                case "Rectangle":
                    Console.Write("Enter l: ");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Enter b: ");
                    double b = double.Parse(Console.ReadLine());
                    area = rectangle.Area(l, b);
                    break;

                case "Square":
                    Console.Write("Enter side length: ");
                    double side = double.Parse(Console.ReadLine());
                    area = square.Area(side);
                    break;

                case "Circle":
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    area = circle.Area(radius);
                    break;

                case "Triangle":
                    Console.Write("Enter base length: ");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = double.Parse(Console.ReadLine());
                    area = triangle.Area(baseLength, height);
                    break;

                default:
                    Console.WriteLine("Invalid shape type");
                    break;
            }

            Console.WriteLine($"The area of the {shapeType} is: {area}");
            Console.ReadKey();
        }
    }
}
