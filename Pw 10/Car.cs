using System;
namespace OOP_Practice
{
    // Класс Car, производный от Vehicle
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        // Конструктор
        public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }
        // Реализация метода Start
        public override void Start()
        {
        Console.WriteLine($"Автомобиль {Make} {Model} запущен.");
        }
        public override void Honk()
        {
            Console.WriteLine("Гудок при нажатии центра руля");
        }
        // Реализация метода Stop
        public override void Stop()
        {
            Console.WriteLine($"Автомобиль {Make} {Model} остановлен.");
        }
    }
}
