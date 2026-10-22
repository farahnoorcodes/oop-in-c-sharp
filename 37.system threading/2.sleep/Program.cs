using System;
using System.Threading;

namespace _2.sleep
{
    internal class Program
    {
        static void work()
        {
            Console.WriteLine("worker started!!!");
            Thread.Sleep(4000);//about 4 second.
            Console.WriteLine("worker finished!!");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(work);
            t.Start();
            Console.WriteLine("main wait for the worker ");
            t.Join();
            Console.WriteLine("main:done");
            
        }
    }
}
