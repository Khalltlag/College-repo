using System;
using System.ComponentModel;
using ПР9;

namespace ПР9
{
    class Program
    {
        public static void Main(string[] args)
        {
            shape[] shapes = new shape[]
            {
                new circle(5),
                new rectangle(4,6),
                new circle(10),
                new triangle(4,6,9),
            };
            foreach (shape shape in shapes) 
            {
                Console.WriteLine($"Shape Type:{shape.GetType().Name}");
                Console.WriteLine($"Perimeter:{shape.GetPerimeter()}");
                Console.WriteLine($"Area:{shape.GetArea()}");
                Console.WriteLine($"");
            }
        }
    }
}
