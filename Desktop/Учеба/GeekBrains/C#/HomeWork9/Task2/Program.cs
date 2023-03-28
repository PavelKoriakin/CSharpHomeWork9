// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int InputUser(string msg)
{
    Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNatural(int m, int n)
{
    if (m > n) return 0;
    return m + SumNatural(m + 1, n);
}
int M = InputUser("Введите значение M");
int N = InputUser("Введите значение N");
System.Console.Write($"{SumNatural(M, N)} ");
