using System;
using System.Threading;//threading in c# is the ability to run multiple pieces of code at the same time within  one program, using the system.threading namespace.
                       //Thread: args single path of execution inside a program.
//multithreading: runnung 2 or more threads concurrently
//Thread safe : code that works correctly when several threads use it at once.
namespace _1.threading
{
    internal class Program
    {
        static void sayhello()
        {
            Console.WriteLine("hello from the new thread");//
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(sayhello);//create a thread that will run a sayhello method
            t.Start();//begings running it
            t.Join();//make the main wait until the thread finishes
            Console.WriteLine("main thread is done");
        }
    }
}
