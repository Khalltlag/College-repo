using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n10
{
    abstract class Vehicle
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year) 
        { 
            Make = make;
            Model = model;
            Year = year;
        }

        public abstract void Start();
        public abstract void Honk();
        public abstract void Stop();
    }
}
