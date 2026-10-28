using System;
namespace task_5
{
    internal class Teacher:person
    {
        public string subject;
        public void DisplayTeacher()
        {
            displayPerson();
            Console.WriteLine($"subject: {subject}");
        }
    }
}
