using System;
namespace OOP_Practice
{
    // Базовый класс
    class Animal
    {
        // Свойства
        public string Name { get; set; }
        public int Age { get; set; }
        // Конструктор
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Виртуальный метод, который можно переопределить в производных классах
        public virtual void Eat() 
        {
            Console.WriteLine("Животное ест");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Животное издает звук.");
        }

        public virtual void Fetch() 
        {
            Console.WriteLine("Животное делает действие");
        }
    }
}
