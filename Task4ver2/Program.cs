int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int DiagSum(int[,] inArray)
{
//    int sum = 0;
//    for (int i = 0; i < inArray.GetLength(0); i++)
//    {
//        if((inArray.GetLength(1)-1) < i) break;
//        sum = sum + inArray[i, i];
//    }
//    return sum;
    int length = inArray.GetLength(0) < inArray.GetLength(1) ? inArray.GetLength(0) : inArray.GetLength(1);
    int sum = 0;
    for(int i = 0; i < length; i++)
    {
        sum+= inArray[i, i];
    }
    return sum;
}
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.Write($"Сумма элементов главной диагонали = {DiagSum(array)}");