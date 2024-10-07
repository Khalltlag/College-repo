using OOP_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw_8
{
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) 
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Птица чирикает");
        }
        public override void Eat()
        {
            Console.WriteLine("Птица клюет семечки");
        }
    }
}
