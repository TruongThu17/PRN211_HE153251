
using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerableInterface
{
    public class Student 
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() =>
            $"Name: {FirstName} {LastName},Age: {Age}";
    }
    public class MyCollection<T> : IEnumerable where T:class,new ()
    {
        private List<T> myList = new List<T>();
        public void AddItem(params T[] item) => myList.AddRange(item);
        IEnumerator IEnumerable.GetEnumerator() => myList.GetEnumerator();
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection<Student> collection = new MyCollection<Student>();
            var s1 = new Student { FirstName = "Thu", LastName = "Truong", Age = 22 };
            var s2 = new Student { FirstName = "Mai", LastName = "Vu", Age = 22 };
            var s3 = new Student { FirstName = "Hanh", LastName = "Le", Age = 19 };
            var s4 = new Student { FirstName = "Nam", LastName = "Hoang", Age = 16 };
            collection.AddItem(s1, s2, s3, s4);
            foreach (var s in collection)
            {
                Console.WriteLine(s);
            }
        }
    }
}
