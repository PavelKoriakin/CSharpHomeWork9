// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputUser(string msg)
{
    Console.Write($"{msg} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int first, int second)
{
    if (first == 0) return second + 1;
    else if (second == 0 && first > 0) return Ackerman(first - 1, 1);
    else return Ackerman(first - 1, Ackerman(first, second - 1));
}

int m = InputUser("Введите первое число");
int n = InputUser("Введите второе число");
Console.WriteLine(Ackerman(m, n));