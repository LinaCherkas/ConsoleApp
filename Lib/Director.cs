namespace Employee;

public class Director:Employee
{
    public string ControlDepartment { get; private set; }
    public Director(int age, string firstName, string lastName, string position, string controlDepartment): 
        base(age, firstName, lastName, position)
    {
        ControlDepartment = controlDepartment;
    }

    public override void Responsibilities()
    {
        Console.WriteLine($"Be the head of {ControlDepartment} department");
    }
}