using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class Numeric_Literal_Syntax
    {
        //static void Main()
        //{
        //    numericLiteralSyntax();
        //}
        static void numericLiteralSyntax()
        {
            Console.WriteLine("*** Use Digit Separators ***");
            Console.WriteLine("Integer: ");
            Console.WriteLine(123_456);
            Console.WriteLine("Double: ");
            Console.WriteLine(123_456.12);
            Console.WriteLine("Hex: ");
            Console.WriteLine(0x_00_00_FF);
            Console.WriteLine("*** Use Binary Literals ***");
            Console.WriteLine("Sixteen: {0}", 0b_0001_0000);
            Console.WriteLine("Thirty two: {0}", 0b_0010_0000); 
            Console.WriteLine("Sixty Four: {0}", 0b_0100_0000);
            Console.ReadLine();
        }
    }
}
