using System;
using task01;


namespace task02
{
    public enum ShapeType
    { 
        TRIANGLE,
        RECTANGLE,
        SQUARE
    }

    class ShapeFactory
    {
        public static Shape GetShape(ShapeType type, double b, double h)
        {
            if (type == ShapeType.RECTANGLE) return new Rectangle(b, h);
            else if (type == ShapeType.SQUARE) return new Square(b);
            else if (type == ShapeType.TRIANGLE) return new Triangle(b, h);
            else return null;
        }
    }

    class MainClass
    { 
        static void Main()
        {
            Random rd = new Random();
            int t = rd.Next(0, 2);
            ShapeType type;
            if (t == 0) type = ShapeType.RECTANGLE;
            else if (t == 1) type = ShapeType.SQUARE;
            else type = ShapeType.TRIANGLE;
            double b = rd.NextDouble() * 10;
            double h = rd.NextDouble() * 10;

            double totalArea = 0;
            for (int i = 0; i < 10; i++) 
            {
                Shape shape = ShapeFactory.GetShape(type, b, h);
                totalArea += shape.GetArea();
            }

            Console.WriteLine("Total area is {0}.", totalArea);
        }
    }
}
