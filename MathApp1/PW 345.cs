using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using StringLibrary;

//namespace MathApp1
//{
//    internal class Program1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter first number: ");
//            double num1 = double.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the second number: ");
//            double num2 = double.Parse(Console.ReadLine());
//            
//            Console.WriteLine($"Power of numbers: {MathOperations.Power(num1, num2)}");
//            Console.WriteLine("Enter the third number: ");
//            double num3 = double.Parse(Console.ReadLine());
//            Console.WriteLine($"Number root is: {MathOperations.Sqrt(num3)}");
//
//            Console.WriteLine("Write any word: ");
//            string ser = Console.ReadLine();
//            Console.WriteLine($"Reversed: {StringOperations.Rever(ser)}");
//            Console.WriteLine($"It's palindrome?: {StringOperations.palindrome(ser)}");
//
//            Console.WriteLine("Enter an array of numbers:");
//            int[] array = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
//
//            Console.WriteLine($"The average of this array is: {MathOperations.averege(array)}");
//
//            Console.WriteLine("Press any key to exit...");
//            Console.ReadKey();
//        }
//
//    }
//}