using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("blue", 5);
        Circle c1 = new Circle("red", 3);
        Rectangle r1 = new Rectangle("green", 4, 6);
        shapes.Add(s1);
        shapes.Add(c1);
        shapes.Add(r1);
        foreach (Shape shape in shapes) {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of  {shape.GetArea()}");
        }
    }
}
