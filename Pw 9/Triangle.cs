using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_9
{
    class Triangle : Shape
    {
        public double LeftSide { get; set; }
        public double RightSide { get; set; }
        public double TopRight { get; set; }
        public double Perimetr { get; set; }

        public Triangle(double leftSide, double rightSide, double topRight, double perimetr)
        {
            LeftSide = leftSide;
            RightSide = rightSide;
            TopRight = topRight;
            Perimetr = perimetr;
        }
        public override double GetPerimeter()
        {
            return (LeftSide + RightSide + TopRight) / 2;
        }
        public override double GetArea()
        {
            return Math.Sqrt(Perimetr * (Perimetr - LeftSide) * (Perimetr - RightSide) * (Perimetr - TopRight));
        }
        public override double GetInfo()
        {
            Console.WriteLine("Сторона 1: " + LeftSide);
            Console.WriteLine("Сторона 2: " + RightSide);
            Console.WriteLine("Сторона 3: " + TopRight);
            Console.WriteLine("Периметр: " + Perimetr);
            return 0;
        }
    }
}
