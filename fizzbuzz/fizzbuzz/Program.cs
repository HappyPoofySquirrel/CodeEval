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
  /*          Console.WriteLine("enter a value for Fizz");
            int fizz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value for buzz");
            int buzz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what number do you want to count to?");
            int count = Convert.ToInt32(Console.ReadLine());

            //int[] fb = new int[count];

            int a;
            for (a = 1; a <= count; a++)
            {
                if (a % fizz == 0 && a % buzz == 0)
                { 
                    Console.Write(" FB ");
                }

                else if (a % fizz == 0)
                {
                    Console.Write(" F ");
                }
                else if (a % buzz == 0)
                {
                    Console.Write(" B ");
                }

                else
                {
                    Console.Write(a);
                }
     */
                   // entering in code eval
                    string line= "3 5 20";
            string[] myVals = line.Split(' ');
                int x=int.Parse(myVals[0]);
                int y =int.Parse(myVals[1]);
                int  n =int.Parse(myVals[2]);
                
                
                
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
