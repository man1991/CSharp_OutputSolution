using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Base
    {
        public void f1()
        {
            Console.WriteLine("In Base : f1()");
        }
        public virtual void f2()
        {
            Console.WriteLine("In Base : f2()");
        }
        public virtual void f3()
        {
            Console.WriteLine("In Base : f3()");
        }
    }
    class derived :Base
    {
        new public void f1()
        {
            Console.WriteLine("In Derived : f1()");
        }
        public override void f2()
        {
            Console.WriteLine("In Derived : f2()");
        }
        public new void f3()
        {
            Console.WriteLine("In Derived : f3()");

        }
    }
    class Inheritance7
    {
        static void Main(string[] args)
        {
            Base b = new derived();
            b.f1();
            b.f2();
            b.f3();
        }
    }
}
