using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class var_keyword
    {
        //static void Main(string[] args)
        //{
        //    keyword();
        //}
        static void keyword()
        {
            var myInt = 0;
            var myBool = true;
            var myString = "Hello World!";
            var myDouble = 0.5;
            //Print out the underlying type;
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
            Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
            Console.ReadLine();
        }

    }
}
