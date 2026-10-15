using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task__4
{
    internal class Student
    {
        // Private data
        private string name;
        private int rollNo;
        private double marks;

        // Constructor
        public Student(string name, int rollNo, double marks)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.marks = marks;
        }

        // Getter and setter for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Getter and setter for RollNo
        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        // Getter and setter for Marks
        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Marks: " + marks);
        }
    }
}
