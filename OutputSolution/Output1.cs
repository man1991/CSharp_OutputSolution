using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Output1
    {
        static void Main(string[] args)
        {
            int a = 1;
            float b = 2.4f;
            short c = 1;
            Console.Write((float) a + b * c - (a += (short) b));
            Console.Read();
        }
    }
}
