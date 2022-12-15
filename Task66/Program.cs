// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
var M = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
var N = int.Parse(Console.ReadLine());

int sum = 0;

int Summa(int m, int n)
{
    if (m + 1 < n)
    {
        return m + Summa(m + 1, n);
    }
    else return 0;
}

System.Console.WriteLine(Summa(M, N));