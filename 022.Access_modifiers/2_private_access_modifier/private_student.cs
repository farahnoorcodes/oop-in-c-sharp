public class private_student
{
    private int marks;//marks is private, so only code inside the Student class can read or change it. Program.cs cannot touch it directly.

    public void SetMarks(int value)//SetMarks is a public method, so it is the controlled way to change marks. The if acts as a guard: the value is stored only if it is between 0 and 100. Otherwise nothing happens and marks keeps its old value.
    {
        if (value >= 0 && value <= 100)
        {
            marks = value;
        }
    }

    public int GetMarks()//GetMarks is a public method that returns the current value, so other classes can read marks without being able to change it directly. This idea is called encapsulation: the data is hidden, and access goes through methods that enforce rules.
    {
        return marks;
    }
}