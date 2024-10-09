using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Animal //Задание 1
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Eat()
        {
        Console.WriteLine("Животное кушает");
        }


        public virtual void MakeSound() //Самост 1
        {
            Console.WriteLine("Животное издает звук");
        }

        public virtual void Fetch()
        {
            Console.WriteLine("Делает действие");
        }
    }
}
