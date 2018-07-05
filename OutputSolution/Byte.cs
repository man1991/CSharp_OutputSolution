using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class Byte
    {
        static void Main()
        {
            byte b1 = 0xAB;
            byte b2 = 0x99;
            byte temp;

            temp = (byte) ~b2;
            Console.Write(temp + " ");

            temp = (byte) (b1 << b2);
            Console.Write(temp + " ");

            temp = (byte)(b1 >> b2);
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
