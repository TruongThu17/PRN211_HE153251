using System;
using System.Collections.Generic;

namespace SortedSet
{

    class Program
    {
        static void Main(string[] args)
        {
            
            SortedSet<int> mySet = new SortedSet<int>() { 8, 7, 9, 1, 3 };
            // Add thêm các phần tử vào mySet
            mySet.Add(5);
            mySet.Add(4);
            mySet.Add(6);
            mySet.Add(2);
            Console.WriteLine("Elements of mySet:\n");
            // Truy cập các phần tử của SortedSet bằng vòng lặp foreach
            foreach (var val in mySet)
            {
                Console.Write($"{val,3}");
            }
            Console.ReadLine();
        }
    }
}
