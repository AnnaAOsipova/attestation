// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());


    if (n > 13 || m > 3)
{
    Console.WriteLine("Вычисления функции Аккермана при введенных значениях слишком большие. Задайте меньшие значения m и n");
}
if (m < 0 || n < 0)
{
    Console.WriteLine("Для вычисления функции Аккермана числа m и n должны быть положительными");
}

int result = Ackermann(m, n);
int Ackermann(int m, int n)
{
    if (m == 0 && n > 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        return 0;
    }
}
Console.WriteLine($"Результат функции Аккерамана для чисел m = {m} и n = {n}: {result}");

