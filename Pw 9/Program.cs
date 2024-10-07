using Pw_9;
using System;

namespace OOP_Practice
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Массив объектов базового типа Shape
            Shape[] shapes = new Shape[]
            {
              new Circle(5),
              new Triangle(7, 6, 8, 9),
              new Rectangle(4, 6), 
              new Circle(3), 
              new Rectangle(2, 3) 
            };
            
           // Вывод информации о каждой фигуре
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Тип фигуры: {shape.GetType().Name}");
                Console.WriteLine($"Радиус: {shape.GetInfo()}");
                Console.WriteLine($"Площадь: {shape.GetArea():F2}");
                Console.WriteLine($"Периметр: {shape.GetPerimeter():F2}");
                Console.WriteLine();
            }
        }
    }
}
