static void Task1()
{
    var num = 20;
    num += 5;
    Console.WriteLine($"Variable: {num}");
}

static void Task2(int days)
{
    Console.WriteLine($"{days / 365} years, {days % 365 / 7} weeks, {days % 365 % 7} days");
}

static void Task3()
{
    var number = int.Parse(Console.ReadLine());
    Console.WriteLine($"Result: {number + number * 2}");
}

static void Task4()
{
    sbyte variable = -34;
    byte variable1 = 4;
    string name = "Hello";
    char variable3 = 'R';
    double variable4 = 23.093433222;
    int variable5 = 40000;
    bool variable6 = true;
    byte variable7 = 0;
}

static void Task5()
{
    var data = Console.ReadLine();

    var shortVariable = short.Parse(data);
    var ulongVariable = ulong.Parse(data);
    var charVariable = char.Parse(data);
    var doubleVariable = double.Parse(data);
}

static void Task6()
{
    var variable = 5 * 7;
    Console.WriteLine($"Result: {--variable}");
}


static void Task7()
{
    var number = int.Parse(Console.ReadLine());
    if (number % 2 == 0) Console.WriteLine("The number is even");
    else Console.WriteLine("The number is even");
}

static void Task8()
{
    var A = int.Parse(Console.ReadLine());
    if ((A < 50 && A != 37 && A > 32) || A is 0 or 15) Console.WriteLine("Working");
}

static void Task9()
{
    Console.WriteLine("Input: number1, number2, operation");
    var words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    switch (words[2])
    {
        case "-":
            Console.WriteLine($"Result = {float.Parse(words[0]) - float.Parse(words[1])}");
            break;
        case "*":
            Console.WriteLine($"Result = {float.Parse(words[0]) * float.Parse(words[1])}");
            break;
        case "/":
            Console.WriteLine($"Result = {float.Parse(words[0]) / float.Parse(words[1])}");
            break;
        case "+":
            Console.WriteLine($"Result = {float.Parse(words[0]) + float.Parse(words[1])}");
            break;
    }
}