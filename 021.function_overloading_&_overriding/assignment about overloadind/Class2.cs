using System;
namespace assignment_2
{
    internal class Class2
    {
        public void Print(int value)
        {
            Console.WriteLine("Integer: " + value);
        }

        public void Print(double value)
        {
            Console.WriteLine("Double: " + value);
        }

        public void Print(string text)
        {
            Console.WriteLine("String: " + text);
        }

        public void Print(string text, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        public void Print(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }
    }
}
