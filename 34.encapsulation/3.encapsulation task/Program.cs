using System;
namespace _3.encapsulation_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : Farah Noor\nRoll No : 25-CPE-18");
            ExamResult s1 = new ExamResult();
            Console.WriteLine("----For student 1----");
            s1.setMarks(777);
            s1.getmarks();
            ExamResult s2 = new ExamResult();
            Console.WriteLine("----For student 2----");
            s2.setMarks(87);
            s2.getmarks();
            Console.ReadKey();
        }
    }
}
