using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class LogicalOperator
    {
        static void Main()
        {
            int i = 2, j = 1;
            if (Convert.ToBoolean((i | j & 5) & (j - 25 * 1)))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
