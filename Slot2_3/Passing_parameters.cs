using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class Passing_parameters
    {
        static void MyMethod(int a, ref int b, out int c)
        {
            a = 3;
            b = 4;
            c = 5;
        }
        static void SumArray(out int s, params int[] list)
        {
            int i;
            s = 0;
            for (i = 0; i < list.Length; i++)
            {
                s += list[i];
            }
        }
        //static void Main(string[] msg)
        //{
            //ex1
            //int x = 1, y = 2, z;
            //MyMethod(x, ref y, out z);
            //Console.WriteLine($"x: {x},y:{y}, z:{z}");
            //Console.ReadLine();

            // ex2
            //int s;
            //SumArray(out s, 1, 2, 3, 4);
            //Console.WriteLine($"s = {s}");
            //int[] myIntArray = { 5, 6, 7, 8, 9 };
            //SumArray(out s, myIntArray);
            //Console.WriteLine($"s = {s}");
            //SumArray(out s);
            //Console.WriteLine($"s = {s}");
            //Console.ReadLine();
        //}
    }

}
