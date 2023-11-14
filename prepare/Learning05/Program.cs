using System;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        // Test Square
        Square square = new Square("Red", 5.0);
        Console.WriteLine($"Square - Color: {square.Color}, Area: {square.GetArea()}");

        // Test Rectangle
        Rectangle rectangle = new Rectangle("Blue", 4.0, 6.0);
        Console.WriteLine($"Rectangle - Color: {rectangle.Color}, Area: {rectangle.GetArea()}");

        // Test Circle
        Circle circle = new Circle("Green", 3.0);
        Console.WriteLine($"Circle - Color: {circle.Color}, Area: {circle.GetArea()}");

        // Add shapes to the list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate through the list and display color and area for each shape
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape - Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}