using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_9
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        // Переопределение метода для расчета площади
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        // Переопределение метода для расчета периметра
        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override double GetInfo() 
        {
            return Radius;
        }

    }
}
