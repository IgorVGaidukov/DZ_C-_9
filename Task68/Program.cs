﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
var m = int.Parse(Console.ReadLine());

Console.Write("Введите число n: ");
var n = int.Parse(Console.ReadLine());

int FuncA(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return FuncA(m - 1, 1);
    else
        return FuncA(m - 1, FuncA(m, n - 1));
}

Console.Write($"A({m},{n}) = {FuncA(m, n)}");