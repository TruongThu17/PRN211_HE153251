using System;

namespace GenericInterfaces
{
    // Khai báo một interface với ràng buộc:struct(Value type)
    interface IBasic<T> where T :struct
    {
       T Add(T a, T b);
    }
    // Implement interface IBasic với kiểu int
    class MyFirstClass : IBasic<int>
    { 
        public int Add(int a, int b) => a + b;
    }
    // Implement interface IBasicvới kiểu double
    class MySecondClass : IBasic<double>
    { 
        public double Add(double a, double b) => a + b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstClass firstclass = new MyFirstClass();
            dynamic r = firstclass.Add(30, 20);
            Console.WriteLine(r);
            MySecondClass secondClass = new MySecondClass();
            r = secondClass.Add(10.5, 20.5);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
    }
