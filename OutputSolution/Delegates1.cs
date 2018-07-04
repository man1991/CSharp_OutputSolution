using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    delegate int del1(int i);

    class Delegates1
    {
        public int MyFun(int i)
        {
            Console.WriteLine("Welcome to IndiaBIX.com !");
            return 0;
        }
        static void Main(string[] args)
        {
            del1 d;
            Delegates1 s1 = new Delegates1();
            d = new del1(ref s1.MyFun);
            d(10);
        }
    }
}
