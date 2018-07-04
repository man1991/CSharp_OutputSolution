using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Output2
    {
        static void Main(string[] args)
        {
            float x = 10.553f;
            long y = 12L;
            int z;
            z = Convert.ToInt32(x+y);
            Console.WriteLine(z);
        }
    }
}
