using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingParameter
{
    class Program
    {
        public void Swap(ref int a,ref int b)
        {
            int temp=a;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            Program obj = new Program();
            a = 40;
            b = 20;
            Console.WriteLine("Before Swapping \n" + a + "  " + b);
            obj.Swap(ref a,ref b);
            Console.WriteLine("\n After Swapping \n");
            Console.WriteLine("A=" + a + " B= " + b);

            Console.ReadLine();

           
        }
    }
}
