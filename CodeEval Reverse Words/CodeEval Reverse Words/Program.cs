using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEval_Reverse_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = " my dog like milkshakes";

            
            string[] words = line.Split(' ');
            Array.Reverse(words);
            for (int i = 0; i < words.Length - 1; i++)              
            {
                Console.Write(words[i] + " ");
            }
            Console.WriteLine(words[words.Length - 1]);


        }
    }
}
