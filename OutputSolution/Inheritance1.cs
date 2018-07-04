using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Baseclass1
    {
        public void fun()
        {
            Console.WriteLine("Hi" + " ");
        }
        public void fun(int i)
        {
            Console.Write("Hello" + " ");
        }
    }
    class Derived : Baseclass1
    {
        public void fun()
        {
            Console.Write("Bye" + " ");
        }
    }
    class Inheritance1
    {
        static void Main(string[] args)
        {
            Derived d;
            d = new Derived();
            d.fun();
            d.fun(77);
        }
    }
}
