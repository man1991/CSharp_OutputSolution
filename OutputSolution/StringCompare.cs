using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class StringCompare
    {
        static void Main()
        {
            String s1 = "Five Star";
            String s2 = "FIVE STAR";
            int c;
            c = s1.CompareTo(s2);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }

}
