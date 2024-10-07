using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР9
{
    internal class triangle : shape
    {
        public triangle(double side, double side0, double side1)
        {
            Side = side;
            Side0 = side0;
            Side1 = side1;
        }

        public double Side { get; set; }
        public double Side0 { get; set; }
        public double Side1 { get; set; }

        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p*(p-Side)*(p-Side0)*(p-Side1));
        }
        public override double GetPerimeter()
        {
            return Side + Side0 + Side1;
        }
    }
}
