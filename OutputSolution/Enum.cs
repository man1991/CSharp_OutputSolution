using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Enum
    {
        enum days : int
        {
            sunday = -3,
            monday,
            tuesday
        }
        static void Main(String[] args)
        {
            Console.WriteLine((int)days.sunday);
            Console.WriteLine((int)days.monday);
            Console.WriteLine((int)days.tuesday);
            Console.ReadLine();
        }       
    }
}
