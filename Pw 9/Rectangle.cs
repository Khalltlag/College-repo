using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_9
{
    class Rectangle : Shape
    {
        public double Width  { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height) 
        {
            Width = width;
            Height = height;
        }
        // Переопределение метода для расчета площади
        public override double GetArea()
        {
            return Width * Height;
        }
        // Переопределение метода для расчета периметра
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
        
        public override double GetInfo() 
        {
            Console.WriteLine("Ширина: " + Width);
            Console.WriteLine("Высота: " + Height);
            return 0;
        }

    }
}
