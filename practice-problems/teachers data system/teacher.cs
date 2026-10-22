using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teachers_data_system
{
    internal class teacher
    {
        private string name;
        private string subject;
        private int yearsOfExperience;
        internal teacher(string name,string subject,int years){
            this.name = name;
            this.subject = subject;
            this.yearsOfExperience = years;
        }
        public string seniorOrJunior(int years)
        {
            if (yearsOfExperience > 10)
            {
                return "senior";
            }
            else
            {
                return "junoir";
            }
        }
        public void display()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Years of Experience : {yearsOfExperience}");
            Console.WriteLine($"Status : {seniorOrJunior(yearsOfExperience)}");
        }
    }
}
