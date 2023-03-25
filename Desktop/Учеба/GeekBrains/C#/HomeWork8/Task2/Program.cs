// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

int[] SumElements(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix[i, j];
        }
        System.Console.Write($"{sum[i]} ");
    }
    System.Console.WriteLine();
    return sum;
}

int MinString(int[] sum)
{
    int min = sum[0];
    int count = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            count = i;
        }
    }
    return count;
}

int[,] matrix = GenerateArray(6, 6);
PrintArray(matrix);
System.Console.WriteLine($"Суммы ");
System.Console.WriteLine($"Минимальная сумма в строке {MinString(SumElements(matrix)) + 1}");