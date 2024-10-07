﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР9
{
    internal class rectangle : shape
    {
        public double Width {  get; set; }
        public double Height { get; set; }

        public rectangle(double width, double height) 
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width*Height;
        }
        public override double GetPerimeter()
        {
            return 2*(Width * Height);
        }
    }
}
