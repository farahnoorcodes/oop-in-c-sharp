namespace _2.MyDll
{
    public class Class1
    {
        public string name;
        public string roll_number;
        public int age;
        public void detail(string name_1, string roll_number_1,int age_1)
        {
            name = name_1;
            roll_number = roll_number_1;
            age = age_1;
            Console.WriteLine($"Name of the studend: {name}");
            Console.WriteLine($"Roll number of the studend: {roll_number}");
            Console.WriteLine($"Age of the studend: {age}");
            if (age >= 18)
            {
                Console.WriteLine("Not A Minor");

            }
            else if (age < 18 && age > 0)
            {
                Console.WriteLine("Student Is A Minor");
            }
        }
    }
}
