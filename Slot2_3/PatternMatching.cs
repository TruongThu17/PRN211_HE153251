using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class PatternMatching
    {

        //static void Main()
        //{
        //    EX1();
        //    EX2();
        //}
        static void EX1()
        {
            Console.WriteLine("Input Data: ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n is int count && count > 0)
            {
                Console.WriteLine(new String('*', count));

            }
            else
            {
                Console.WriteLine("Data invalid.");
            }
        }
        static void EX2()
        {
            Console.WriteLine("Input data: ");
            int.TryParse(Console.ReadLine(), out int n);
            switch (n)
            {
                case int count when count > 0:
                    Console.WriteLine(new String('*', count));
                    break;
                default:
                    Console.WriteLine("Data invalid.");
                    break;
            }
        }
    }
}
