﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Cat : Animal //Задание 3
    {
        public Cat(string name, int age) : base( name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Кот мяукает");
        }
        public override void Eat()
        {
            Console.WriteLine("кушает рыбу");
        }
    }

}
