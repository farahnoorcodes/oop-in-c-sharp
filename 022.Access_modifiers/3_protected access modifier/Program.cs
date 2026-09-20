using System;
namespace _3_protected_access_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            protected_student_details s1 = new protected_student_details();// This is the derived class. It inherits from protected_student, so it can
                                                                           // access the protected fields (student_id and student_cnic) directly.
                                                                           // Code outside the class hierarchy, such as Program, cannot access them.
                                                                           // For this reason, the derived class provides public methods that Program
                                                                           // can call to set and display the values.
                                                                           // s1.student_id = "BZU-101";   // ERROR CS0122: inaccessible due to its protection level
            s1.set_student_details("2025_CPE_18", "12345-6789012-3");
            s1.get_student_details();
            protected_student_details s2 = new protected_student_details();
            s2.set_student_details("2024_CPE_16", "12345-6789012-4");
            s2.get_student_details();
        }
    }
}

