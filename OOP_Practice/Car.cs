using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public double FuelLevel { get; set; }

        public Car(string brand, string model, int year, double mileage, double fuelLevel)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            FuelLevel = fuelLevel;
        }
        public void Drive(double distance)
        {
            if (FuelLevel > distance * 0.09)
            {
                FuelLevel -= distance * 0.09;
                Mileage += distance;
            }
            else
            {
                Console.WriteLine("not enough fuel");
            }

        }
        public override string ToString()
        {
            return $"Марка: {Brand}, Модель: {Model}, Год: {Year}, Пробег: {Mileage}, Топливо: {FuelLevel}";
        }
    }
}