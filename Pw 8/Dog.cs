using System;
namespace OOP_Practice
{
    // Производный класс Dog
    class Dog : Animal
    {
        // Новое свойство для породы
        public string Breed { get; set; }
        // Конструктор, вызывающий конструктор базового класса
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        // Переопределение метода MakeSound
        public override void MakeSound()
        {
            Console.WriteLine("Собака лает.");
        }
        public override void Eat()
        {
            Console.WriteLine("Собака ест корм");
        }
        public virtual void Fetch()
        {
            Console.WriteLine("Cобака приносит мячик");
        }
    }
}
