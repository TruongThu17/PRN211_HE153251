using System;
using System.Collections;

namespace EX1
{
    public class IntCollection
    {
        private ArrayList arInts = new ArrayList();
        // Get an int (performs unboxing) !
        public int GetInt(int pos) => (int)arInts[pos];

        // Insert an int (performs boxing) !
        public void AddInt(int n) => arInts.Add(n);
        public void ClearInts() => arInts.Clear();
        public int Count => arInts.Count;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, number;
            IntCollection collection = new IntCollection();

            collection.AddInt(10);
            collection.AddInt(20);
            collection.AddInt(30);
            for (int i = 0; i < collection.Count; i++)
            {
                number = collection.GetInt(i);

                s += number;
                Console.Write($"{number}" + $"{(i == collection.Count - 1 ? " =" : " +")}");
            }
            Console.WriteLine($"{s}");
        }
    }
}
