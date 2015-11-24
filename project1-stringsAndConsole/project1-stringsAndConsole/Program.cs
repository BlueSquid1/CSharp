using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_stringsAndConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a bunch of numbers. (press CTRL+Z when done)");
            string line = System.Console.ReadLine();
            int total = 0;
            while (line != null)
            {
                //shows how to convert between different types
                UInt32 n = UInt32.Parse(line);
                total += (int)(n);
                line = System.Console.ReadLine();
            }
            
            //output an answer
            System.Console.Write("total={0}\n", total);
            System.Console.ReadLine();
        }
    }
}
