using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("             Multiplos de 3               ");
            Console.WriteLine("");

            double i = 1;
            do
            {
                if (i%3==0)
                {
                    Console.WriteLine("{0}",i);
                }

                i++;

            } while (i < 200);

            Console.ReadKey();
        }
    }
}
