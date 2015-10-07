using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Postfix_Prefix
{
    class Program
    {
        static void Main(string[] args) //if issue in code eval and not visual make sure printing the correct data type may not always be an integer 
        {
            //infix = 5+7
            //prefix = +57
            //Postfix= 57+
            //postfix use stack 
            //check for + - / or * using string 
            //push numbers onto stack. 
            //pop 2 from the stack and apply the operator
            //then push result onto stack otherwise next line 
            //prefix do in reverse. so reverse the array of characters 
            //use double not int
            string line = "+ 3 4 ";
            Stack<double> nums = new Stack<double>();
           
            string[] nums2 = line.Split(' ');
            Array.Reverse(nums2);
            double result;
            double n;
            foreach(string c in nums2)
            {
                if (double.TryParse(c, out n))
                {
                    nums.Push(n);
                }
                if (c == "+")
                {
                    double x = nums.Pop();
                    double y = nums.Pop();
                    result = x + y;
                    nums.Push(result);
                }
                if (c == "-")
                {
                    double x = nums.Pop();
                    double y = nums.Pop();
                    result = x - y;
                    nums.Push(result);
                }
                if (c== "/")
                {
                    double x = nums.Pop();
                    double y = nums.Pop();
                    result = x / y;
                    nums.Push(result);
                }
                if (c == "*")
                {
                    double x = nums.Pop();
                    double y = nums.Pop();
                    result = x * y;
                    nums.Push(result);
                }
                
            }
            Console.WriteLine(nums.Pop());

        }
    }
}
