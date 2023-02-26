namespace Employee;

public class Employee
{
    public Employee(int age, string firstName, string lastName, string position)
    {
        Age = age;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
    }

    public int Age { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Position { get; }

    public void PrintInfo()
    {
        Console.WriteLine($"Age: {Age}, First name: {FirstName}, Last name: {LastName}, Position: {Position}");
    }

    public void PerformingSomeWork()
    {
        Console.WriteLine("I'm working...");
    }
}