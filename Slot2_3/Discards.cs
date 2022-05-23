using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class Discards
    {
        //static void Main()
        //{
        //    Ex();
        //    EX2();
        //}
        static void Ex()
        {
            string[] stringarray = { "12", "Hello", "3.14", "20" };
            for (int i = 0; i < stringarray.Length; i++)
            {
                if (int.TryParse(stringarray[i], out _))
                {
                    Console.WriteLine($"{stringarray[i]}: valid");
                }
                else
                {
                    Console.WriteLine($"{stringarray[i]}: invalid");
                }
            }
        }
        static(string first, string middle , string last) SplitNames(string fullName)
        {
            string[] strArray = fullName.Split(' ');
            return (strArray[0], strArray[1], strArray[2]);

        }
        static void EX2()
        {
            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first}:{last}");
        }
    }
}
