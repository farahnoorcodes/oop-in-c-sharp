using System;
namespace @enum
{//enum is a value type that is used to define a set of named constants. It is a special "class" that represents a group of constants (unchangeable/read-only variables).
    //A value type is a type whose variable holds the actual data directly. When you copy it, you get a completely independent copy.
    //
    internal class Program
    {
        enum day
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday,

        }
        static void Main(string[] args)
        {
            day d1 = day.monday;
            Console.WriteLine(d1);
            day d2 = day.friday;
            Console.WriteLine(d2);

        }
    }
}
