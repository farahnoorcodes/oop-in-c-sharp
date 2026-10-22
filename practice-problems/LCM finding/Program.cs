using System;
namespace LCM_finding
{
    internal class Program
    {
        static int gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int lcm(int a, int b)
        {
            return (a / gcd(a, b) * b);
        }

        static void Main(string[] args)
        {
            int number = 0;

        start2:
            try
            {
            start1:
                try
                {
                    Console.Write("how much number you have to calculate LCM :");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("enter a valid number!!");
                    goto start1;
                }

                int[] lcmnumber = new int[number];

                for (int i = 0; i < number; i++)
                {
                    Console.Write($"enter {i + 1} number: ");
                    lcmnumber[i] = Convert.ToInt32(Console.ReadLine());
                }

                int result = lcmnumber[0];
                for (int i = 1; i < number; i++)
                {
                    result = lcm(result, lcmnumber[i]);
                }

                Console.WriteLine("LCM is " + result);
            }
            catch (Exception)
            {
                Console.WriteLine("please Enter a valid number:");
                goto start2;
            }
        }
    }
}