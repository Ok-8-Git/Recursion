﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
// M = 8; N = 4 -> "8, 7, 6, 5, 4"

Console.WriteLine("Введите натуральное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int numberN = Convert.ToInt32(Console.ReadLine());


if (numberM <= 0 || numberN <= 0)
    {
        Console.WriteLine("Некорректный ввод!");
        return;
    }

void PrintNaturalNumbers(int num1, int num2)
{

    if (num1 < num2) 
    {
        if (num1 == num2)
        {
            Console.Write($"{num1} ");
            return;
        }    
        PrintNaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");  
    }
    else
    {
        if (num2 == num1) 
        {
            Console.Write($"{num2} "); 
            return;
        }
    Console.Write($"{num1} ");  
    PrintNaturalNumbers(num1 - 1, num2); 
    }
}

PrintNaturalNumbers(numberM, numberN);
