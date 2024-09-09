using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;
            Console.Write("\n Enter the Number \n");
            no = int.Parse(Console.ReadLine());
            if (no % 2 == 0)
            {
                Console.Write("Even Number");
            }
            else
            {
                Console.Write("Odd Number");
            }
            Console.ReadLine();
        }
    }
}
