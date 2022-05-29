using System;
using System.Collections.Generic;

namespace List_EX
{
    public class Student
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() =>
            $"Name: {FirstName} {LastName},Age: {Age}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> people = new List<Student>(){
            new Student{FirstName="Thu",LastName="Truong",Age=22},
            new Student{FirstName = "Mai", LastName = "Vu", Age = 22},
            new Student{FirstName= "Hanh", LastName= "Le", Age= 19},
            new Student{FirstName = "Nam", LastName = "Hoang", Age = 16}
        };
            //đếm số item có trong List people
            Console.WriteLine("Items in list:{0}", people.Count);
            // Hiển thị từng student
            foreach (Student p in people)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
