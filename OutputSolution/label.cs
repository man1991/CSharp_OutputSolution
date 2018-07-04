using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class label
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;

            label:
            i++;
            j += i;
            if (i < 10)
            {
                Console.Write(i + " ");
                goto label;
            }
        }
    }
}
//1 2 3 4 5 6 7 8 9