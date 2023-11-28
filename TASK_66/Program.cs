// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());


if (M < 1 || N < 1)
{
Console.WriteLine("Одно или оба введенных числа не являются натуральными");
}

int sum (int start, int end)
{    
    if ( start == end || start > end)
    {
    return 0;
    }
 return start + sum (start+1, end);
}
Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum(M+1,N)}");



