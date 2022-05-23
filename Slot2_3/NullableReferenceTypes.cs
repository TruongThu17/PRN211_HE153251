using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class NullableReferenceTypes
    {
        static void PrintFullName(string first, string? middle , string last)
        {
            Console.WriteLine(middle?.Length);
            Console.WriteLine(first + middle+ last);

        }
        //static void Main()
        //{
        //    string firstname = "Mike";
        //    string? middleName = null;
        //    string lastName = " John";
        //    PrintFullName(firstname, middleName, lastName);
        //    Console.ReadLine();
        //}

    }
}
