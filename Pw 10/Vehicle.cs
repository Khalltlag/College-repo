using System;
namespace OOP_Practice
{
    // Абстрактный класс Vehicle
    abstract class Vehicle
    {
        // Свойства
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        // Конструктор
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        // Абстрактные методы
        public abstract void Start();
        public abstract void Stop();
        public abstract void Honk();
    }
}
