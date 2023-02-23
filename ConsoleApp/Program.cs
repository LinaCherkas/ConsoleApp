static void Task1()
{
    var number = int.Parse(Console.ReadLine());
    var result = 0;
    for (var i = 0; i <= number; i++)
    {
        result += i;
    }
    Console.WriteLine($"Result = {result}");
}

static void Task2()
{
    for (var i = 1; i <= 9; i++)
    {
        Console.WriteLine($"3 * {i} = {3*i}");
    }
}

static void Task3()
{
    int[] arr = { 3, 5, 9, 8, 15 };
    var result = arr.Aggregate(1, (acc, x) => acc * x);
    Console.WriteLine($"Result = {result}");
}

static void Task4()
{
    var i = 0;
    var number = 2048;
    
    while (number>10)
    {
        number /= 2;
        i++;
    }
    Console.WriteLine($"Result = {i}");
}

static void Task5()
{
    string[] arr = { "df", "dfgfg", "dfsdfvdf", "Hello"};
    foreach (var item in arr)
    {
        if (item == "Hello")
        {
            Console.WriteLine("Labas!");
            break;
        }
    }
}

static void Task6()
{
    int[] arr = { 3, 5, 9, 8, 15 };
    Console.WriteLine($"Sum = {arr[0]+arr[^1]}");
}

static void Task7()
{
    int[] arr = { 3, 5, 9, 8, 15 };
    double max = double.NegativeInfinity, min = double.PositiveInfinity;
    for (var i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Min = {min}, Max = {max}");
}

static void Task8()
{
    int[] arr = { 18, 4, 23, 8, 2 };
    for (var i = 1; i < arr.Length; i++)
    {
        for (var j = 0; j < arr.Length - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
        }
    }

    for (var i = 1; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

static void Task9()
{
    for(var i=1; i<=10; i++)
    {
        for(var j=1; j<=10;j++)
        {
            Console.Write("{0}x{1} = {2}, ",j,i,i*j);
        }
        Console.Write("\n");
    }
}	

static void Task10()
{
    int[,] arr = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };

    for(var i=0; i<arr.GetUpperBound(0) + 1; i++)
    {
        for(var j=0; j<arr.Length/(arr.GetUpperBound(0) + 1);j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.Write("\n");
    }
}	

static int[] AppendForBeginning(int[] array, int value) {
    int[] result = new int[array.Length + 1];
    result[0] = value;
    for (int i = 0; i < array.Length; i++)
        result[i + 1] = array[i];
 
    return result;
}

static void Task11()
{
    int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    Array.Resize(ref array, array.Length + 1);
    array[^1] = 11;
    array = AppendForBeginning(array, -1);
    var newArr = new int[array.Length + 1];
    
    for (var i = 0; i < array.Length + 1; i++) {
        if (i < 3)
            newArr[i] = array[i];
        else if (i == 3)
            newArr[i] = 4;
        else
            newArr[i] = array[i - 1];
    }

    newArr = newArr.Skip(1).ToArray();

    int[] array2 = { 100, 200, 300 };
    
    int[] concatArray= newArr.Concat(array2).ToArray();
    
    for (var i = 1; i < concatArray.Length; i++)
    {
        Console.Write(concatArray[i] + " ");
    }
}	


Task11();