using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value for Fizz");
             int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value for buzz");
             int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what number do you want to count to?");
             int n = Convert.ToInt32(Console.ReadLine());

        
                int a;
            for (a = 1; a <= n; a++)
            {
                if (a % x == 0 && a % y == 0)
                { 
                    Console.Write("FB ");
                }

                else if (a % x == 0)
                {
                    Console.Write("F ");
                }
                else if (a % y == 0)
                {
                    Console.Write("B ");
                }

                else
                {
                    Console.Write(a+ " ");
                }
                
            

            }
            Console.WriteLine();
        }
    }
}
