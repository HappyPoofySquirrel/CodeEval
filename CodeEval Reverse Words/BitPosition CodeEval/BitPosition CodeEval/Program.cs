using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitPosition_CodeEval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "125,1,2"; //test input
            
            string[] splitLine = line.Split(','); //split line into string[] "splitLine"
            int[] ints = new int[splitLine.Length]; //new empty int[] "ints"
            
                       for (int i = 0; i <= splitLine.Length - 1; i++)
                                 {
                ints[i] = Convert.ToInt32(splitLine[i]); //convert strings to ints and fill int[] "ints"
                                 }
            
            string binary = Convert.ToString(ints[0], 2); //convert int[0] to binary string
            
            char[] binaryToReverse = binary.ToCharArray(); //convert binary string to char array
            
            Array.Reverse(binaryToReverse); //reverse char array to read right-left 
            
            string reversedBinary = new string(binaryToReverse); //new string "reversedBinary"
            
            int positionOne = ints[1] - 1; //because positions are 1-based, not 0-based 
            int positionTwo = ints[2] - 1;
            
                      if (reversedBinary[positionOne] == reversedBinary[positionTwo])
           {
                Console.WriteLine("true");
            }
            
                        else
                {
                Console.WriteLine("false");
                }

        }
    }
}
