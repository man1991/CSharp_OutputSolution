using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class csharp
    { 
        int x, y, z;
        public csharp()
        {

        }
        public csharp(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
        }
        public static csharp operator -(csharp s1)
        {
            csharp t = new csharp();
            t.x = -s1.x;
            t.y = -s1.y;
            t.z = -s1.z;
            return t;
        }
        public void display()
        {
            Console.WriteLine(x + "  " + y + "  " + z);
        }
        class Overload_Operator
        {
            static void Main(String[] args)
            {
                csharp s1 = new csharp(5, 6, 8);
                csharp s3 = new csharp();
                s3 = -s1;
                s3.display();
            }
        }
    }
}
