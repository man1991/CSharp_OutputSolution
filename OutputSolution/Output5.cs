using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Output5
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int z;
            Console.WriteLine(z = ++x + y++);
            Console.WriteLine(y);
            Console.Read();
        }
    }
}
