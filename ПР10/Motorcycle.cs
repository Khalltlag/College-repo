using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n10
{
    class Motorcycle : Vehicle
    {
        public string HasSidecar { get; set; }

        public Motorcycle(string make, string mogel, int year, string hassidecar) : base(make, mogel, year)
        {
            HasSidecar = hassidecar;
        }
        public override void Start()
        {
            Console.WriteLine($"мотоцикл {Make} {Model} {Year} {HasSidecar} начал движение ");
        }
        public override void Honk()
        {
            Console.WriteLine("громкий шум двигателя мотоцикла");
        }
        public override void Stop()
        {
            Console.WriteLine($"мотоцикл {Make} {Model} {Year} {HasSidecar} остановлен ");
        }
    }
}
