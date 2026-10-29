using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.encapsulation_task
{
    internal class ExamResult
    {
        private int marks { get; set; }
        public void setMarks(int m)
        {
            
            if (m < 0 || m > 100)
            {
                Console.WriteLine("invalid marks entered");
            }
            else
            {
                marks = m;
            }
        }
        public void getmarks (){
            Console.WriteLine($"marks = {marks}");
        }
    }
}
