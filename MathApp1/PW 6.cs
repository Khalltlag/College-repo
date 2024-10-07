using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("toyoto", "corolla", 2006, 50000, 60);
            Console.WriteLine(myCar);

            myCar.Drive(200);

            Console.WriteLine(myCar); 
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}