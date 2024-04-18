﻿// Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29
// m = 11, n = 3 -> A(m,n) = 16381


Console.WriteLine("Введите число m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int numberN = Convert.ToInt32(Console.ReadLine());

int Ack(int n, int m)
{
    if (n == 0) return m + 1;
    
    if (m == 0) return Ack(n - 1, 1);

    return Ack(n - 1, Ack(n, m - 1));
}

int result = Ack(numberN, numberM);
Console.WriteLine(result);
