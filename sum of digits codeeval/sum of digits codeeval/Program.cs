using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits_codeeval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "488";
            int length = line.Length;
            int sum = 0;
            int digit = 0;
            for (int i =0;i< length; i++)
            {
                digit = (int)Char.GetNumericValue(line[i]);
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
