using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class Tuples
    {
        //static void Main()
        //{
            //ex1
            //Ex1();
            //ex2
            //Ex2();
        //}
        static void Ex1()
        {
            //Create tuples
            (string MyString, int MyNumber) myValues = ("Hello Word!", 2022);
            Console.WriteLine($"MyString: {myValues.MyString}");
            Console.WriteLine($"MyNumber: {myValues.MyNumber}");
        }
        static void Ex2()
        {
            int[] numbers = { 2, 1, 5, 6, 3, 4, 7, 8, 10, 9 };
            var (sum,count) = MyMethod(numbers);
            Console.WriteLine($"Sum: {sum}, count: {count}");

        }
        static (int sum , int count) MyMethod(int[] values)
        {
            //declare a tuple
            var r = (sum: 0, count: 0);
            for (int i = 0; i < values.Length; i++)
            {
                if (IsEvenNumber(values[i])){
                    r.sum += values[i];
                    r.count++;
                }
            }
            return r;
            bool IsEvenNumber(int n)
            {
                return n % 2 == 0;
            }
        }
    }
}
