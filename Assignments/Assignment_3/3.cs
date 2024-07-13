using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment3
{
    using System;

    public class Shapes
    {
        // Method to calculate the area of a rectangle
        public double Area(double length, double width)
        {
            return length * width;
        }

        // Method to calculate the area of a triangle
        public double Area(double baseLength, double height, bool isTriangle)
        {
            if (isTriangle)
            {
                return 0.5 * baseLength * height;
            }
            throw new ArgumentException("Invalid parameters for triangle area calculation.");
        }

        // Method to calculate the area of a circle
        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate the area of a square
        public double Area(int sideLength)
        {
            return sideLength * sideLength;
        }
    }

    class three
    {
        static void Main(string[] args)
        {
            Shapes shapes = new Shapes();

            // Area of a rectangle
            double rectangleArea = shapes.Area(5.0, 3.0);
            Console.WriteLine($"Area of the rectangle: {rectangleArea}");

            // Area of a triangle
            double triangleArea = shapes.Area(4.0, 6.0, true);
            Console.WriteLine($"Area of the triangle: {triangleArea}");

            // Area of a circle
            double circleArea = shapes.Area(7.0);
            Console.WriteLine($"Area of the circle: {circleArea}");

            // Area of a square
            double squareArea = shapes.Area(4);
            Console.WriteLine($"Area of the square: {squareArea}");
        }
    }

}
