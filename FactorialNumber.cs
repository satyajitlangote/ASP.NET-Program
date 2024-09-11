using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i = 1;
            int fact = 1;
            Console.Write("\n Enter any number \n ");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.Write("\n Factorial = " + fact);
            }
            else
            {
                for (i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                Console.Write("Fact =" + fact);
            }
            Console.ReadLine();
        }
    }
}
