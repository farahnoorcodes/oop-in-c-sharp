using System;
namespace _1.using_a_breakpoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open  the c# program in visual studio
            //click beside the required line number.
            //a red breakpoint symbol will appear.
            //run the program using start debugging or F5.
            //the program will stop at the breakpoint and you can inspect the variables and step through the code.
            Console.WriteLine("Name : Farah Noor\nRoll No : 2025-CPE-18");
            int quantity = 5;
            int price = 200;
            int total = quantity * price;
            Console.WriteLine("Total cost = " + total);
            Console.ReadKey();
        }
    }
}
