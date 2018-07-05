using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class StringFind
    {
        static void Main()
        {
            String str = "She sells sea shells on the sea-shore";
            //to find out the index of the second 's' in the string
            int i, j;
            i = str.IndexOf("S");
            j = str.IndexOf("s", i + 1);

            //OR
            //i = str.IndexOf("S");
            //j = str.IndexOf("s", i);

            //OR

            //i = str.IndexOf("s");

            Console.WriteLine(j);
        }
    }
}
