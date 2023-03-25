// * : Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplecationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multiMatrix;
}

int[,] matrix1 = GenerateArray(5, 5);
int[,] matrix2 = GenerateArray(5, 5);
PrintArray(matrix1);
System.Console.WriteLine();
PrintArray(matrix2);
PrintArray(MultiplecationMatrix(matrix1, matrix2));