using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputMultipleOutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            GetUserInput(out i, out j);
            Console.WriteLine("\nThe Addition of i is: " + i);
            Console.WriteLine("The Addition of j is: " + j);
            Console.Read();
        }

        public static void GetUserInput(out int i, out int j)
        {
            Console.Write("Enter a value for i: ");
            i = int.Parse(Console.ReadLine()); 

            Console.Write("Enter a value for j: ");
            j = int.Parse(Console.ReadLine()); 

            i += i; 
            j += j; 
        }
    }
}
