using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    public class sample
    {
        public static int x = 100;
        public static int y = 150;

    }
    class Inheritance6 : sample
    {
        new public static int x = 1000;
        static void Main(string[] args)
        {
            Console.WriteLine(sample.x + "  " + sample.y + "  " + x);
        }
    }
}
