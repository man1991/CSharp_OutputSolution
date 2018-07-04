using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class IncrementOperator
    {
        static void Main()
        {
            int i, j = 1, k;
            for (i = 0; i < 5; i++)
            {
                k = j++ + ++j;
                Console.Write(k + " ");
            }
            Console.ReadLine();
        }
    }
}
//4 8 12 16 20
