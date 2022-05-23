using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    class Boxing_and_Unboxing
    {
        //static void Main(string[] args)
        //{
        //    main1();
        //    main2();
        //}
        public static void main1()
        {
            int i = 123;
            // Boxing copies the values of i into object o.
            object o = i;
            i = 456;
            // the change in i doesn't affect the values stored in o;
            Console.WriteLine("The value-type = {0}", i);
            Console.WriteLine("The object-type value = {0}", o);
            Console.ReadLine();
        }
        public static void main2()
        {
            int i = 123;
            object o = i;
            int j = (int)o;
            Console.WriteLine("i = {0} , o = {1} , j = {2}", i, o, j);
            Console.ReadLine();
        }
    }
}
