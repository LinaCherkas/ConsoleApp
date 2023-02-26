namespace Employee;

public class Worker: Employee
{
    public string Department { get; private set; }
    public Worker(int age, string firstName, string lastName, string position, string department): 
        base(age, firstName, lastName, position)
    {
        Department = department;
    }

    public override void Responsibilities()
    {
        Console.WriteLine($"Work in {Department} department");
    }

}