﻿// Задача 3. Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы. 
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max); 
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       if (i < array.Length - 1) 
       {
        Console.Write($"{array[i]}, ");
       }

       else Console.Write($"{array[i]}"); 
    }
    Console.Write("]");
}

void PrintArrayInReverse(int[] arr, int i) 
{
    if (i == 1) 
    {
        Console.Write($"{arr[i - 1]}  "); 
        return; 
    }
    Console.Write($"{arr[i - 1]}  ");  
    PrintArrayInReverse(arr, i - 1);     
}


int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);
Console.Write(" => ");
int i = arr.Length;
PrintArrayInReverse(arr, i);