using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Do_While
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i += 1;
            } while (i <= 10);
            //The same above do-while can also be written in form of For Loop as
            //int i;
            //for (i = 0; i <= 10; i++)
            //    Console.WriteLine(i);
        }
        
    }
}
//0
//1
//2
//3
//4
//5
//6
//7
//8
//9
//10