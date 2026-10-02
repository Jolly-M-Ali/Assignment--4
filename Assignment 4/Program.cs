using System;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person3 ObjectPerson = new person3();
            ObjectPerson.RunExample6(); 

            StructPoint ObjectPoint = new StructPoint();
            ObjectPoint.RunExample6();

            EnumColor ObjectColor =new EnumColor();
            ObjectColor.RunExample5();  

            //permissions example 4
            PermissionsEnum input = new PermissionsEnum();
            input.RunExample4();
            // 1. إنشاء كائن (Object) من الكلاس `@struct`
            // ملاحظة: استخدمنا الرمز @ لأن اسم الكلاس محجوز أو يبدأ بحرف خاص، والأفضل دائماً تسمية الكلاسات بأسماء واضحة مثل PersonExample
            PersonStruct exampleObj = new PersonStruct();

            // 2. استدعاء الدالة من خلال الكائن
            exampleObj.RunExample();

            SeasonEnum ExamleSeason = new SeasonEnum();
            ExamleSeason.RunExample();



            // 1- Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then,
            // write a C# program that prints out all the days of the week using this enum.

            
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((Days)i);
            }
        }
    }
}
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    




