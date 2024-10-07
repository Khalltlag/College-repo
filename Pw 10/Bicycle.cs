using System;
namespace OOP_Practice
{
    // Класс Bicycle, производный от Vehicle
    class Bicycle : Vehicle
    {
        public bool HasBell { get; set; }
        // Конструктор
        public Bicycle(string make, string model, int year, bool hasBell)
        : base(make, model, year)
        {
            HasBell = hasBell;
        }
        // Реализация метода Start
        public override void Start()
        {
            Console.WriteLine($"Велосипед {Make} {Model} начал движение.");
        }
        public override void Honk()
        {
            Console.WriteLine("Звон при нажатии на звонок");
        }
        // Реализация метода Stop
        public override void Stop()
        {
            Console.WriteLine($"Велосипед {Make} {Model} остановлен.");
        }
    }
}
