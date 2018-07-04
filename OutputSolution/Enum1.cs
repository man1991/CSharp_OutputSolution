using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Enum1
    {
        enum color : int
        {
            red,
            green,
            blue = 5,
            cyan,
            magenta = 10,
            yellow
        }
        static void Main(String[] args)
        {
            Console.Write((int)color.green + ", ");
            Console.Write((int)color.yellow);
            Console.ReadLine();
        }
    }
}
//1 11