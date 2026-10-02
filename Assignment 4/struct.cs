using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_4
{
    internal class PersonStruct 
    {
        public void RunExample()
        { 
            // 2-Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.
            //Then, write a C# program to display the details of all the persons in the array.

            Person[] people =
            {
                new Person { Name = "John", Age = 25 },
                new Person { Name = "Jane", Age = 30 },
                new Person { Name = "Bob", Age = 35 }
            };
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Name}, {p.Age}");
            }

        }

    }
}

    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

