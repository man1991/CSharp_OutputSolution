using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    public class Generic<T>
    {
        public T Field;
        public void TestSub()
        {
            //T i = Field + 1;
        }
    }
    class Generics
    {
        static void Main(String[] args)
        {
            Generic<int> gen = new Generic<int>();
            gen.TestSub();
        }
    }
}
//Compiler will report an error: Operator '+' is not defined for types T and int.