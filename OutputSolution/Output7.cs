using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class MyProgram 
    {
        int i;
        Single j;
        public void SetData(int i, Single j)
        {
            this.i = i;
            this.j = j;
        }
        public void Display()
        {
            Console.WriteLine(i + " " + j);
        }
    }
    class Output7
    {
        static void Main(string[] args)
        {
            MyProgram s1 = new MyProgram();
            s1.SetData(36, 5.4f);
            s1.Display();
        }
    }
}
