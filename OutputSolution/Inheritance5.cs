using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class A
    {
        public void fun()
        {
            Console.Write("Welcome");
        }
    }
    class B : A
    {
        public void fun()
        {
            base.fun();
            Console.WriteLine(" to IndiaBIX.com!");
        }
    }
    class Inheritance5
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.fun();
        }
    }
}
