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
        }
    }
}
