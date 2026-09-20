using System;
namespace _3_protected_access_modifier
{
     public class protected_student//This is the base class. Both fields are protected, so they can be accessed inside protected_student and inside any class derived from it, but not from unrelated classes such as Program.
    {
        protected string student_id;//A protected member is accessible within its own class and within any class derived from it, but not from unrelated classes.
        protected string student_cnic;
    }
    public class protected_student_details : protected_student//this is how we make derived class . protected members of the base class are accessible in the derived class.
    {
        public void set_student_details(string id, string cnic)//This public method stores values in the inherited protected fields. It is allowed because the code is inside a derived class.
        {
            student_id = id;
            student_cnic = cnic;
        }
        public void get_student_details()//This public method prints the values. Program cannot read the fields directly, so it calls this method instead.
        {
            Console.WriteLine("Student ID: " + student_id);
            Console.WriteLine("Student CNIC: " + student_cnic);
        }
    }
}
