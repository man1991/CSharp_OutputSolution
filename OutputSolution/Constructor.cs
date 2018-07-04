using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Sample
    {
        public int func()
        {
            return 1;
        }
        //public Single func() //Single type is the same as the float type
        //{
        //    return 2.4f;
        //}
    }
    class Constructor
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();
            int i;
            i = s1.func();
            Single j; //Single type is the same as the float type
            j = s1.func();
            Console.WriteLine("Value of: i= {0} & j= {1}", i, j); // 
            Console.ReadLine();
        }
    }
}
