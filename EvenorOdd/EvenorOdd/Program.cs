using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number \n");
            int no = int.Parse(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else 
            {
                Console.WriteLine("Odd Number ");
            }
            Console.ReadLine();

        }
    }
}