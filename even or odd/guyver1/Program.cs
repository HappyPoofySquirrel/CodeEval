using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guyver1
{
    class Program
    {
        private static object sd;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it is even or odd");

            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)

            {

                Console.WriteLine("even");
            } 

            
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}
