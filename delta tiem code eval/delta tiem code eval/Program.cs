using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delta_tiem_code_eval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "14:01:57 12:47:11";// looking for absolute value so = or minus each   
            string[] line2 = line.Split(' ');
            DateTime endTime = DateTime.Parse(line2[0]);
            DateTime startTime = DateTime.Parse(line2[1]);
            TimeSpan diff =endTime - startTime;
            Console.WriteLine(diff.Duration()); //duration makes abolsute value so if first number is larger than second or vice versa
            
        }
    }
}
