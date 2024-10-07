using Pw_8;
using System;
namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Dog
            Dog myDog = new Dog("Бобик", 3, "Лабрадор");
            // Создание объекта класса Cat
            Cat myCat = new Cat("Мурка", 2);
            Bird myBird = new Bird("Попуга", 4);
            // Вывод информации и вызов метода MakeSound для собаки
            Console.WriteLine($"Собака: Имя - {myDog.Name}, Возраст - {myDog.Age},Порода - { myDog.Breed}");
            myDog.MakeSound();
            myDog.Eat();
            myDog.Fetch();
            // Вывод информации и вызов метода MakeSound для кота
            Console.WriteLine($"Кот: Имя - {myCat.Name}, Возраст - {myCat.Age}");
            myCat.MakeSound();
            myCat.Eat();
            Console.WriteLine($"Птица: Имя - {myBird.Name}, Возраст - {myBird.Age}");
            myBird.MakeSound();
            myBird.Eat();
        }
    }
}
