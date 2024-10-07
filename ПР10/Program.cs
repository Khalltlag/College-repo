using System;

namespace n10
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Corolla", 2020, 4);
            Bicycle myBicycle = new Bicycle("Giant", "Escape 3", 2019, true);
            Motorcycle myMotorcycle = new Motorcycle("BMW", "mottorad", 2014,"With Stroller");

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
