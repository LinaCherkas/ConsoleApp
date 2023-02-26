namespace ConsoleApp.Task5;

public class Factory
{
    public Factory(string name, List<Employee.Employee> employees)
    {
        Name = name;
        Employees = employees;
    }

    private string Name { get; }
    private List<Employee.Employee> Employees { get; }

    public int EmployeeCount()
    {
        return Employees.Count;
    }

    public void AddNewEmployee(int age, string firstName, string lastName, string position)
    {
        Employee.Employee employee = new(age, firstName, lastName, position);
        Employees.Add(employee);
    }

    public void DisplayAllEmployees()
    {
        Console.WriteLine("All employees:");
        foreach (var item in Employees) Console.WriteLine($"First Name: {item.FirstName}, " +
                                                          $"Last Name: {item.LastName}");
    }

    public void DisplayEmployeesByPosition(string position)
    {
        Console.WriteLine($"Employees on {position} position:");
        foreach (var item in Employees.Where(x => x.Position == position))
            Console.WriteLine($"First Name: {item.FirstName}, Last Name: {item.LastName}");
    }
}