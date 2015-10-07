using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Sumofint2CEvil
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\line.txt"); //to use must add using system.IO
            using (reader)  //closes reader when done 
            {
                int sum=0;   //must declare before loop to use outside loop to print. must assign value to use 
                string line = reader.ReadLine();   //assigning line the first line to string line 
                while (line!=null) //loops untill line is empty 
                {
                    int line1 = int.Parse(line); //converting string to int 
                    sum += line1; //adding numbers of each line together 

                    line =reader.ReadLine(); //making line equal to the nest line in readline 
                    
                }
                Console.WriteLine(sum);
            }
        }
    }
}
