using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    public class TestIndiaBix
    {
        public void TestSub<M>(M arg)
        {
            Console.Write(arg);
        }
    }
    class Generics1
    {
        static void Main(string[] args)
        {
            TestIndiaBix bix = new TestIndiaBix();
            bix.TestSub("IndiaBIX ");
            bix.TestSub(4.2f);
        }
    }
}
