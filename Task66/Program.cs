// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

Console.Write("Введите число M: ");
var M = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
var N = int.Parse(Console.ReadLine());

int IncNum(int m, int n)
{
    int sum = 0;
    if (m < n) sum = m + IncNum(m+1,n);
    else
      if (m == n) sum = m;

    return sum;
}

Console.WriteLine($"Сумма чисел от {M} до {N} = {IncNum(M,N)}");