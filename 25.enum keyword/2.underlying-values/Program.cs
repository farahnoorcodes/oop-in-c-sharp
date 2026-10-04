using System;
namespace _2.underlying_values
{
    internal class Program
    {
        //Underlying values

        //By default, each member is an int starting at 0 and increasing by 1. You can assign your own values:
        enum Status
        {
            Pending = 1,
            Approved = 2,
            Rejected = 5
        }
        //Changing the underlying type

        //The default is int, but you can choose another integral type to save memory:
        enum Level : byte
        {
            Low = 1,
            Medium = 2,
            High = 3
        }
        //what is i give one of the enum value like 111, the next value will be 112, and so on. If you give a value that is not in the enum, it will still compile, but it will not be valid.
        enum Status2
        {
            Pending = 111,
            Approved, // 112
            Rejected // 113
        }
        //what if one enum is given a -ve value, the next value will be -1, and so on. If you give a value that is not in the enum, it will still compile, but it will not be valid.
        enum Status3
        {
            Pending = -1,
            Approved, // 0
            Rejected // 1
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine((int)Status.Pending); // Output: 1

            //Converting an enum to its number requires an explicit cast, and the same goes for the reverse:
            
            Status s = (Status)5;
            Console.WriteLine(s);   // Rejected

            //different underlying type

            Console.WriteLine((byte)Level.Medium); // Output: 2
            Level l = (Level)3;
            Console.WriteLine(l);   // High

            //one enum value is given and next values are automatically assigned
            
            Console.WriteLine((int)Status2.Rejected); // Output: 113

            //-ve value is given and next values are automatically assigned

            Console.WriteLine((int)Status3.Pending); // Output: -1
            Console.WriteLine((int)Status3.Approved); // Output: 0
            Console.WriteLine((int)Status3.Rejected); // Output: 1
        }
    }
}
