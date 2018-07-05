using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Mod
    {
        static void Main()
        {
            int a = 0;
            String res;
            if ( a % 2 == 0)
                res = "Even";
            else
                res = "Odd";
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
