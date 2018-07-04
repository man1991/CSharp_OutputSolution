using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    public class Generic1<T>
    {
        public T Field;
    }
    class Generics2
    {
        static void Main(string[] args)
        {
            Generic1<String> g = new Generic1<String>();
            g.Field = "Hello";
            Console.WriteLine(g.Field);
        }
    }
}
