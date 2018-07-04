using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class maths
    {
        public int fact(int n)
        {
            int result;
            if (n == 1)
                return 1;
            result = fact(n - 1) * n;
            return result;
        }
    }
    class Output6
    {
        static void Main(String[] args)
        {
            maths obj = new maths();
            //Console.WriteLine(obj.fact(4) * obj.fact(2));
            Console.WriteLine(obj.fact(1));
            Console.ReadLine();
        }
    }
}
