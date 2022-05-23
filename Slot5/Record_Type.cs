using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot5
{
    public record Customer
    {
        public string Name { get; init; } = "New customer";
        public int Age { get; init; } = 20;
        public void Print()
        {
            Console.WriteLine($"Name: {Name} , Age: {Age}");
        }
    }
    class Record_Types
    {

        static void Main(string[] args)
        {
            Customer customer01 = new Customer { Name = "Jack", Age = 25 };
            customer01.Print();
            Customer customer02 = customer01 with { Name = "John" };
            customer02.Print();
            Customer customer03 = new();
            customer03.Print();
            Console.ReadLine();
        }
    }
}
