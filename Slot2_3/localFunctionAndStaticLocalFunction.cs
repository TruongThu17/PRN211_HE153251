using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot2_3
{
    internal class localFunctionAndStaticLocalFunction
    {
        //static void Main()
        //{
            // ex1
            //Ex1();
            //ex2
            //Ex2();
       // }
        static void Ex1()
        {
            // Variables of main method
            int x = 1;
            int y = 2;
            //local function
            void AddValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is : " + b);
                Console.WriteLine("Value of x is : " + x);
                Console.WriteLine("Value of y is : " + y);
                Console.WriteLine("Sum: {0}", a + b + x + y);

            }
            AddValue(3, 4);
            AddValue(5, 6);
            Console.ReadLine();
        }
        static void Ex2()
        {
            void AreOfCircle(double a)
            {
                double ar;
                Console.WriteLine("Radius of the circle: "+a);
                ar = 3.14 * a * a;
                Console.WriteLine("Area of circle: "+ ar);
                //Calling static local function
                Circumference(a);
                void Circumference(double a)
                {
                    double cr;
                    cr = 2 * 3.14 * a;
                    Console.WriteLine($"Circumference of the circle is: {cr:N2}");
                }

            }// end AreofCircle
            //Calling function
            AreOfCircle(10);
            Console.ReadLine();
            // end main
        }
    }
}
