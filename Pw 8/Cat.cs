using System;
namespace OOP_Practice
{
    // Производный класс Cat
    class Cat : Animal
    {
        // Конструктор
        public Cat(string name, int age) : base(name, age)
        {
        }
        // Переопределение метода MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Кот мяукает.");
        }
        public override void Eat()
        {
            Console.WriteLine("Кот Кушает рыбу");
        }
    }
}
