using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class EmptyForLoop
    {
        static void Main(string[] args)
        {
            int i = 20;
            for (;;)
            {
                Console.Write(i + " ");
                if (i >= -10)
                    i -= 4;
                else
                    break;
            }
        }
    }
}
//20 16 12 8 4 0 -4 -8 -12

