using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    delegate void del(int i, Single j);
    class Delegates
    {
        public void MyFun(int i, Single j)
        {
            Console.WriteLine("Welcome to IndiaBIX !");
        }
        static void Main(string[] args)
        {
            del d;
            Delegates s = new Delegates();
            d = new del(ref s.MyFun);
            d(10, 1.1f);
        }
    }
}
