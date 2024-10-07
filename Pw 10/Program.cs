using Pw_10;
using System;
namespace OOP_Practice
{
class Program
{
    static void Main(string[] args)
    {
        // Создание объектов Car и Bicycle
        Car myCar = new Car("Toyota", "Corolla", 2020, 4);
        Bicycle myBicycle = new Bicycle("Giant", "Escape 3", 2019, true);
            Motorcycle myMotorcycle = new Motorcycle("Shaft", "Wernos56", 2020, false);
        // Вызов методов Start, Stop и Honk для каждого транспортного средства
        myCar.Start();
        myCar.Honk();
        myCar.Stop();
        myBicycle.Start();
        myBicycle.Honk();
        myBicycle.Stop();
            myMotorcycle.Start();
            myMotorcycle.Honk();
            myMotorcycle.Stop();
        }
}
}