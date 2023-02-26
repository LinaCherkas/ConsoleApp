namespace ConsoleApp.Task5;

public class Task5Runner
{
    public static void Runner()
    {
        Employee.Employee employee1 = new(24, "sda", "wewe", "ews");
        Employee.Employee employee2 = new(25, "sda2", "wewe2", "ews2");
        var employees = new List<Employee.Employee> { employee1, employee2 };
        
        Factory factory = new ("Name", employees);
        factory.AddNewEmployee(26, "sdfgfgdgf", "dfgdfg", "ews");
        factory.DisplayAllEmployees();
        factory.DisplayEmployeesByPosition("ews");
        
    }
}