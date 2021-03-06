﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputSolution
{
    class ExceptionHandling3
    {
        static void Main(string[] args)
        {
            int index;
            int val = 44;
            int[] a = new int[5];
            try
            {
                Console.Write("Enter a number:");
                index = Convert.ToInt32(Console.ReadLine());
                a[index] = val;
            }
            catch (FormatException e)
            {
                Console.Write("Bad Format");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("Index out of bounds");
            }
            Console.Write("Remaining program");
        }
    }
}
