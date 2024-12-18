﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit type casting
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            double doubleNum = num; // Implicit casting
            Console.WriteLine("\nImplicit Casting:");
            Console.WriteLine("Integer value: " + num);
            Console.WriteLine("Casted to Double Value: " + doubleNum);

            // Explicit type casting
            Console.Write("\nEnter a double value: ");
            double decimalNumber = double.Parse(Console.ReadLine());
            int intNum = (int)decimalNumber; // Explicit casting
            Console.WriteLine("\nExplicit Casting:");
            Console.WriteLine("Double Value: " + decimalNumber);
            Console.WriteLine("Casted to Integer Value: " + intNum);

            Console.Read();
        }
    }
}
