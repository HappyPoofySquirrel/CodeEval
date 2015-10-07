using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "([)]";
            
            char[] line2 =  line.ToCharArray();
            Stack<char> stack = new Stack<char>();
            foreach (char c in line2)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (stack.Count() != 0)
                {
                    char x = c;
                    char y = stack.Peek();
                  switch (x)
                    {
                        case ')':
                            if (y == '(')
                            {
                                stack.Pop();
                            }
                            break;
                        case ']':
                            if (y == '[')
                            {
                                stack.Pop();
                            }
                            break;
                        case '}':
                            if (y == '{')
                            {
                                stack.Pop();
                            }
                            break;
                            default:
                            break;
                       
                            
                    }
                }
                else
                {
                    continue;
                }
                    
                
            }

                if (stack.Count() > 0)
                {
                    Console.WriteLine(false);
                }
                else
                {
                    Console.WriteLine(true);
                }



            




        }   
        
    }
}
