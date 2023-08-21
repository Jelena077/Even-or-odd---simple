using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenorodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            if (a % 2 == 0)
            {
                    Console.WriteLine("a is even");
            }
            else 
            {
                    Console.WriteLine("a is odd");
            }
            Console.ReadLine();
            
        }
    }
}
