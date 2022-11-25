using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            int y = 10;
            int h = 1;
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < h; j++)
                {
                    Console.Write("* ");
                }
                if (h == 10)
                {
                    Console.WriteLine("");
                    Console.WriteLine("         ***");
               
                    Console.WriteLine("         ***");
                }
                Console.WriteLine();
                h++;
                y--;
                

            }
            Console.ReadKey();
        }
    }
}