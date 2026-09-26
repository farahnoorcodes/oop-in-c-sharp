using System;
namespace assignment_2
{
    internal class Program
    {
        static void Main()
        {Console.WriteLine("overloading of add method\n\n");
            Class1 Add = new Class1();
            Console.WriteLine("Addition of 2 Integer: " + Add.add(10, 20));
            Console.WriteLine("Addition of 3 Integer: " + Add.add(10, 20, 30));
            Console.WriteLine("Addition of 2 Double: " + Add.add(10.5, 20.3));
            Console.WriteLine("Addition of 3 Double: " + Add.add(10.5, 20.5, 30.33));
            Console.WriteLine("Addition of 2 String: " + Add.add("Hello, ", "World!"));
            Console.WriteLine("\n\noverloading of print method\n\n");
            Class2 PrintValues = new Class2();
            Console.Write("Printing an integer value:");
            PrintValues.Print(42);
            Console.Write("Printing a double value: ");
            PrintValues.Print(3.14);
            Console.Write("Printing a string value: ");
            PrintValues.Print("Hello, World!");
            Console.WriteLine("Printing a string value with repetition: ");
            PrintValues.Print("Hello, World!", 3);
            Console.Write("Printing the sum of two integer values: ");
            PrintValues.Print(10, 20);
            Console.WriteLine("\n\noverloading of multiply method\n\n");
            Class3 multiply = new Class3();
            Console.WriteLine("Multiplication of 2 Integer: " + multiply.Multiply(5, 10));
            Console.WriteLine("Multiplication of 2 Double: " + multiply.Multiply(5.5, 10.8));
            Console.WriteLine("Multiplication of 3 Integer: " + multiply.Multiply(2, 3, 4));
            Console.WriteLine("Multiplication of Integer and Double: " + multiply.Multiply(5, 10.4));
            Console.WriteLine("Multiplication of 4 Integer: " + multiply.Multiply(2, 3, 4, 5));


        }
    }
}
