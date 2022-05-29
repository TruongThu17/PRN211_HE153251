using System;
using System.Collections;

namespace Lab1_Prn211
{
    public class Program
    {
        public class IntCollection
        {
            // Tạo một arraylist
            private ArrayList arInts = new ArrayList();
            // Lấy ra một int
            public int GetInt(int pos) => (int)arInts[pos];
            // insert vào một int
            public void AddInt(int n) => arInts.Add(n);
            public void ClearInts() => arInts.Clear();
            public int Count => arInts.Count;
        }
        static void Main(string[] args)
        {
            int s = 0,number;
            IntCollection collection = new IntCollection();
            collection.AddInt(20);
            collection.AddInt(20);
            collection.AddInt(40);
            for (int i = 0; i < collection.Count; i++)
            {
                number = collection.GetInt(i);
                s += number;
                Console.Write($"{number}" +
                    $"{(i == collection.Count - 1 ? " = " : " + ")}");
            }
                      

                Console.WriteLine($"{s}");
            }

        }
    

}
