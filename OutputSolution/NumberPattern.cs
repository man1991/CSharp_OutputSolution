using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class NumberPattern
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 2; i >= 0; i--)
            {
                for (j = 0; j <= 2; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");

                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
