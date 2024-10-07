using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_10
{
     class Motorcycle : Vehicle
     {
        public bool HasSidecar { get; set; }

        public Motorcycle(string make, string model, int year, bool hassidecar) : base(make, model, year)
        {
            HasSidecar = hassidecar;
        }

        public override void Start()
        {
            Console.WriteLine($"Мотоцикл {Make} {Model} запущен.");
        }
        public override void Honk() 
        {
            Console.WriteLine("Шум от запуска двигателя мотоцикла");
        }
        public override void Stop()
        {
            Console.WriteLine($"Мотоцикл {Make} {Model} остановлен.");
        }
    }
}
