using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class refLocals_refreturns
    {
        static int[] numbers = { 1, 2, 3, 4, 5 };
        static ref int findNumber(int target)
        {
            bool flag = true;
            ref int value = ref numbers[0];
            for (int i = 0; i < numbers.Length && flag == true; i++)
            {
                if (numbers[i] == target)
                {
                    value = ref numbers[i];
                    flag = false;
                }
            }
            return ref value;
        }
        //static void Main()
        //{
        //    Console.WriteLine("Original sequence: ");
        //    Console.WriteLine(String.Join(" ", numbers));
        //    ref int value = ref findNumber(3);
        //    value *= 2;
        //    Console.WriteLine("New sequence: ");
        //    Console.WriteLine(String.Join(" ", numbers));
        //}
    }
}
