using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class index
    {
        protected int count;
        public index()
        {
            count = 0;
        }
    }
    class index1 : index
    {
        public void increment()
        {
            count = count + 1;
        }
    }
    class Inheritance4
    {
        static void Main(string[] args)
        {
            index1 i = new index1();
            i.increment();
        }
    }
}
