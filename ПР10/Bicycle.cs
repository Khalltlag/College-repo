using n10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n10
{
     class Bicycle : Vehicle
    { 
        public bool HasBell {  get; set; }

        public Bicycle(string make, string mogel, int year, bool hasbell) : base(make, mogel, year)
        {
            HasBell = hasbell;
        }
        public override void Start()
        {
            Console.WriteLine($"Велосипед {Make} {Model} {Year} начал движение ");
        }
        public override void Honk()
        {
            Console.WriteLine("механический шум шестерёнок");
        }
        public override void Stop()
        {
            Console.WriteLine($"Велосипед {Make} {Model} {Year} остановлен ");
        }
    }
}
