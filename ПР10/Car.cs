using n10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n10
{
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string make, string mogel, int year, int numberofdoors) : base(make, mogel, year)
        {
            NumberOfDoors = numberofdoors;
        }
        public override void Start()
        {
            Console.WriteLine($"Автомобиль {Make} {Model} {Year} запущен");
        }
        public override void Honk()
        {
            Console.WriteLine("шум двигателя автомобиля");
        }
        public override void Stop()
        {
            Console.WriteLine($"Автомобиль {Make} {Model} {Year} Остановлен");
        }

    }
}
