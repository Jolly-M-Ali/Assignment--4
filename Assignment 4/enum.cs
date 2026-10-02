using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}


namespace Assignment_4
{
    internal class SeasonEnum
    {
        //  3 -Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program
        //that takes a season name as input from the user and displays the corresponding month range for that season.
        // Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        public void RunExample()
        {   
            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();
            switch (input.ToLower() )
            {
                case "spring":
                    Console.WriteLine("March to May");
                    break;
                case "summer":
                    Console.WriteLine("June to August");
                    break;
                case "autumn":
                    Console.WriteLine("September to November");
                    break;
                case "winter":
                    Console.WriteLine("December to February");
                    break;
                default:
                    Console.WriteLine("Invalid season name.");
                    break;
            }
        }

    }  
}


