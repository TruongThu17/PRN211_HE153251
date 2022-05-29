
using System;

namespace GenericMethod
{
    public class MyClass
    {
        // Generics method được tạo với 2 kiểu dữ liệu 
        public void Display<T, U>(T msg, U value)
        {
            Console.WriteLine($"{msg}:{value}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // tạo object Myclass
            MyClass obj = new MyClass();
            // Gọi Generics method
            obj.Display<string, int>("Int", 2022);
            obj.Display<double, char>(1.5, 'N');
            obj.Display<float, double>(358.9F, 255.67);
            Console.ReadLine();
        }
    }
}
