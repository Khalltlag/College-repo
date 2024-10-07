using System;
using System.Data.Common;
namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Бобик", 3,"Лабрадор");

            Cat myCat = new Cat("Мурка", 2);

            Bird myBird = new Bird("Пташка",2);

            Console.WriteLine($"Собака: Имя - {myDog.Name}, Возраст - {myDog.Age}, Порода - {myDog.Breed}");
            myDog.MakeSound();
            myDog.Eat();
            myDog.Fetch();
            Console.WriteLine($"Кот: Имя - {myCat.Name}, Возраст - {myCat.Age}");
            myCat.MakeSound();
            myCat.Eat();
            Console.WriteLine($"Птица: Имя - {myBird.Name}, Возраст - {myBird.Age}");
            myBird.MakeSound();
            myBird.Eat();
        }
    }
}
