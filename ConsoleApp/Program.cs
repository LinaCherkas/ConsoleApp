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
    var name = "Hello";
    var variable3 = 'R';
    var variable4 = 23.093433222;
    var variable5 = 40000;
    var variable6 = true;
    byte variable7 = 0;
}

static void Task5()
{
    var data = Console.ReadLine();

    short shortVariable = short.Parse(data);
    ulong ulongVariable = ulong.Parse(data);
    char charVariable = char.Parse(data);
    double doubleVariable = double.Parse(data);
}

static void Task6()
{
    int variable = 5*7;
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
    if ((A<50&&A!=37&&A>32)||A is 0 or 15) Console.WriteLine("Working");
}

static void Task9()
{
    Console.WriteLine("Input: number1, number2, operation");
    String[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    switch (words[2])
    {
        case "-": Console.WriteLine($"Result = {float.Parse(words[0]) - float.Parse(words[1])}");
            break;
        case "*": Console.WriteLine($"Result = {float.Parse(words[0]) * float.Parse(words[1])}");
            break;
        case "/": Console.WriteLine($"Result = {float.Parse(words[0]) * float.Parse(words[1])}");
            break;
        case "+": Console.WriteLine($"Result = {float.Parse(words[0]) * float.Parse(words[1])}");
            break;
    }
    
}