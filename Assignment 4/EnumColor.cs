using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    internal class EnumColor
    {
        public void RunExample5()
        {
            Console.WriteLine("Enter a color name (Red, Green, Blue):");
            String input = Console.ReadLine();
            string colorName = input.ToLower();
            Array colorValues = Enum.GetValues(typeof(Color));
            if (Enum.TryParse<Color>(colorName, true, out Color color))
            {
                Console.WriteLine(" input color is a primary color");
            }
            else
            {
                Console.WriteLine(" input color is a not primary color");

            }

        } 
    }
}
enum Color
{
    Red,
    Green,
    Blue,
}
