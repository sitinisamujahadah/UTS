using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DERETAN_BILANGAN_FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, agk, k = 1, x = 0;
            Console.Write("Masukkan batas deret :");
            agk = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < agk; i++)
            {
                if (x >= 0 && x <= agk)
                {
                    Console.Write("{0}   ", x);
                }
                x = x + k;
                k = x - k;
            }
            Console.ReadLine();
        }
    }
}
