using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot5
{
    public interface ISomeInterface
    {
        string SomeProperty { get; set; }
        string SomeMethod();
        void SomethingElse();
    }
    public class SomeClass : ISomeInterface
    {
        public string SomeProperty { get; set; }
        public string SomeMethod()
        {
            return "Hello World!";

        }
        public void SomethingElse()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
    public interface IFirst
    {
        void Print();
        void Display();

    }
    public interface ISecond
    {
        void Print();
    }
    public class MyClass : IFirst, ISecond
    {
       public void Display()
        {
            Console.WriteLine("Display Method");
        }
        void IFirst.Print()
        {
            Console.WriteLine("IFirst's Print method");
        }
        void ISecond.Print()
        {
            Console.WriteLine("ISecond's Print method");
        }
    }
    class OOP_Interface
    {
     //static void Main(string[] msg)
     //   {
     //       MyClass obj = new MyClass();
     //       obj.Display();
     //       IFirst first = obj;
     //       first.Print();
     //       ISecond second = obj;
     //       second.Print();
     //   }   
    }
}
