namespace _4_internal_access_modifier
{
    internal class Program//Internal is the default for top-level types with no modifier, so class internal_student and internal class internal_student mean the same thing. Members inside a class (fields and methods) with no modifier default to private, not internal. That is why Write needed the explicit internal keyword.
    {
        static void Main(string[] args)
        {
            internal_student student = new internal_student();
            student.Write("Activated");
            logger_details logger1 = new logger_details();
            logger1.details("Farah", "password123", 18, "female");
        }
        

    }
}
