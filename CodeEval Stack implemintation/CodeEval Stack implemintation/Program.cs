using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Stack_implemintation
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = ("1 2 3 4 5 6");

             string[] line2= line.Split(' ');  //splitting the line into character 
            
            Stack<string> numStack = new Stack<string>();
           

            foreach (string value in line2)  //converting and pushing each number onto the stack 
            {

                
                numStack.Push(value);
               

            }
            int x = 1;
            while (x != 0)
            {
                Console.Write(numStack.Pop() + " ");
                if (numStack.Count !=0)
                {
                    numStack.Pop();
                }
                
                x = numStack.Count();
            }
            Console.WriteLine();

        }          
    }
}
