// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputUser(string msg)
{
    Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

void Natural(int m, int n)
{
    if (m > n) return;
    else if (m % 2 == 0) System.Console.Write($"{m} ");
    Natural(m + 1, n);
}
int M = InputUser("Введите значение M");
int N = InputUser("Введите значение N");
Natural(M, N);