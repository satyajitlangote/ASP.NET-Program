using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenNumEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int no, Ecnt = 0, Ocnt = 0, Tcnt=0;
            Console.WriteLine("Enter the number \n ");
            for (int i = 0; i <= 10; i++)
            {
                no = int.Parse(Console.ReadLine());
                if (no == 0)
                {
                    Tcnt++;
                }
                else
                {
                    if (no % 2 == 0)
                    {
                        Ecnt++;
                    }
                    else
                    {
                        Ocnt++;
                    }
                }
                Console.WriteLine("\n Even Count \n ="+Ecnt+"\n Odd Count \n"+Ocnt+"2 even or odd count \n "+Tcnt);
            }

        }
    }
}
