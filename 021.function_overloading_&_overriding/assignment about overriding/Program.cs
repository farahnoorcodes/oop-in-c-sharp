using System;
namespace assignment_about_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\noverrided display function\n");

            parent display = new parent();
            display.display();

            child display2 = new child();
            display2.display();

            sub_child display3 = new sub_child();
            display3.display();

            sub_sub_child display4 = new sub_sub_child();
            display4.display();

            Console.WriteLine("\noverrideed add function\n");

            parent parentAdd = new parent();
            Console.WriteLine(parentAdd.add(23, 56));

            child childAdd = new child();
            Console.WriteLine(childAdd.add(45, 56));

            sub_child subChildAdd = new sub_child();
            Console.WriteLine(subChildAdd.add(4, 78));

            sub_sub_child subSubChildAdd = new sub_sub_child();
            Console.WriteLine(subSubChildAdd.add(58, 67));

            Console.WriteLine("\noverrided power method\n");

            parent parentPower = new parent();
            Console.WriteLine(parentPower.power(4, 7));

            child childpower = new child();
            Console.WriteLine(childpower.power(7, 3));

            sub_child subchildpower = new sub_child();
            Console.WriteLine(subchildpower.power(2, 6));

            sub_sub_child subsubchildpower = new sub_sub_child();
            Console.WriteLine(subsubchildpower.power(9, 4));

            Console.WriteLine("\noverrided concatenation method\n");

            parent con1 = new parent();
            Console.WriteLine(con1.concatenation("Farah", "Noor"));

            child con2 = new child();
            Console.WriteLine(con2.concatenation("Computer ", "Engineering"));

            sub_child con3 = new sub_child();
            Console.WriteLine(con3.concatenation("Roll No: ", "18-CPE-2025"));

            sub_sub_child con4 = new sub_sub_child();
            Console.WriteLine(con4.concatenation("Batch: ", "2k25"));

            Console.WriteLine("\noverrided roundoff method\n");

            parent rf1 = new parent();
            Console.WriteLine(rf1.roundoff(3.687));

            child rf2 = new child();
            Console.WriteLine(rf2.roundoff(2.34));

            sub_child rf3 = new sub_child();
            Console.WriteLine(rf3.roundoff(567.555));

            sub_sub_child rf4 = new sub_sub_child();
            Console.WriteLine(rf4.roundoff(65.32));
        }
    }
}
