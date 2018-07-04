using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    public enum color
    { red, green, blue };
    class Switch
    {
            static void Main(string[] args)
            {
                color c = color.blue;
                switch (c)
                {
                    case color.red:
                        Console.WriteLine(color.red);
                        break;

                    case color.green:
                        Console.WriteLine(color.green);
                        break;

                    case color.blue:
                        Console.WriteLine(color.blue);
                        break;
                }
            }
    }
}
//blue
