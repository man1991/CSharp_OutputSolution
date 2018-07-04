using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Output3
    {
        static void Main(string[] args)
        {
            int x = 22;
            long y = 44;
            double z = 1.406;
            y = x;
            z = x;
            //x = y;//Invalid:Implicit conversion Long To Int Not Possible
            //y = z;//Invalid:Implicit conversion Double To Long Not Possible
        }
    }
}
//