using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class NullAbleValueTypes
    {
        double? pi = 3.14;
        char? letter = 'a';
        int m2 = 10;
        //int? m = m2;
        bool? flag = null;
        // an arrray of a nullable value type;
        int?[] arr = new int?[10];
        //static void Main(string[] msg)
        //{
        //    int? a = null;
        //    if(a is null)
        //    {
        //        Console.WriteLine("a does not have a value");
        //        a = 2022;
        //    }
        //    if(a is int valueOfA)
        //    {
        //        Console.WriteLine($"a is {valueOfA}");
        //    }
        //}
    }
}
