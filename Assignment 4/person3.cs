using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_4
{
    internal class person3
    {
        public void RunExample6()
        
        {

            // the first person
            Console.WriteLine("input the name of first person details ");
            string name1 = Console.ReadLine();
            Console.WriteLine("input the age of first person details ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            ThreePerson person1 = new ThreePerson(name1, age1);

            // the second person
            Console.WriteLine("input the name of second person details ");
            string name2 = Console.ReadLine();
            Console.WriteLine("input the age of second person details ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            ThreePerson person2 = new ThreePerson(name2, age2);

            // the third person
            Console.WriteLine("input the name of third person details");
            string name3 = Console.ReadLine();
            Console.WriteLine("input the age of third person details");
            int age3 = Convert.ToInt32(Console.ReadLine ());
            ThreePerson person3 = new ThreePerson(name3, age3);

            if (age1 > age2 && age1 > age3)
            {
                Console.WriteLine(name1 + " " + age1);
            }
            else if (age2 > age1 && age2 > age3)
            {
                Console.WriteLine(name2 + " " + age2);
            }
            else
            {
                Console.WriteLine(name3 + " " + age3);
            }



        }

    }
}


public struct ThreePerson
{

    public string name;
    public int age;
    public ThreePerson(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
