using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
     class Dog : Animal //задание 2
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed; 
        }
        
        public override void MakeSound()
        {
            Console.WriteLine("собака лает");
        }
        public override void Eat()
        {
            Console.WriteLine("кушает мясо");
        }
        public override void Fetch() //Самост 2
        {
            Console.WriteLine("приносит мячик");
        }
    }
}
