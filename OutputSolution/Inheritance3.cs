using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Baseclass2
    {
        int i;
        public Baseclass2(int ii)
        {
            i = ii;
            Console.Write("Base ");
        }
    }
    class Derived3 : Baseclass2
    {
        public Derived3(int ii) : base(ii)
        {
            Console.Write("Derived ");
        }
    }
    class Inheritance3
    {
        static void Main(string[] args)
        {
            Derived3 d = new Derived3(10);
        }
    }
}
