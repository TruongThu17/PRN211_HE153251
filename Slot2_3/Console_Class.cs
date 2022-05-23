using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class Console_Class
    {
        //static void Main()
        //{
        //    ConsoleClass();
        //}
        static void ConsoleClass()
        {
            double d;
            int i;
            string s;
            DateTime date;
            Console.WriteLine("***** Data Type Parsing *****");
            Console.WriteLine("Enter a String value:");
            s = Console.ReadLine();
            Console.WriteLine("Enter a Double value:");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an Integer value:");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Date value:");
            date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"Value of s:{s}, i:{i}, d:{d}, date:{date:dd/MM/yyyy}");
            Console.WriteLine();

        }
    }
}
