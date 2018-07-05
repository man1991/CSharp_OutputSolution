using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class IfElse
    {
        static void Main(string[] args)
        {
            int i = 30;
            int j = 25 % 25;
            if (Convert.ToBoolean(Convert.ToInt32(i = j)))
            {
                Console.WriteLine("In if");
            }
            else
            {
                Console.WriteLine("In else");
            }
            Console.WriteLine("In main");
            Console.ReadLine();
        }
    }
}
