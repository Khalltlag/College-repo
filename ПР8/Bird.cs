using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
     class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Птичка чирикает");
        }
        public override void Eat()
        {
            Console.WriteLine("кушает семечки");
        }
    }
}
