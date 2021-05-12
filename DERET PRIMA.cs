using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, a, b, bil;
            Console.Write("Batas atas bilangan prima : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deret bilangan prima :");
            for (a = 2; a <= y; a++)
            {
                bil = 0;
                for (b = 2; b < a; b++)
                {
                    if (a % b == 0)
                    {
                        bil = 1;
                    }
                }
                if (bil == 0)
                {
                    Console.WriteLine("(0)", a);
                }
            }
            Console.ReadLine();
        }
    }
}
