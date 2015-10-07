using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvilWord_to_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "one;three;seven";
           
            string[] newline = line.Split(';'); 
            Dictionary<string, int> nums = new Dictionary<string, int>();
            nums.Add("zero", 0);
            nums.Add("one", 1);
            nums.Add("two", 2);
            nums.Add("three", 3);
            nums.Add("four", 4);
            nums.Add("five", 5);
            nums.Add("six", 6);
            nums.Add("seven", 7);
            nums.Add("eight", 8);
            nums.Add("nine", 9);
            
            foreach(string number in newline)
            {
               
                Console.Write(nums[number]);
            }

            Console.WriteLine();
        }
    }
}
