﻿// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();


void PrintString(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

System.Console.Write("Введите размер массива - ");
int n = int.Parse(Console.ReadLine());
string[] array = new string[n];

for (int i = 0; i < n; i++)
{
    System.Console.Write($"Введите элемент {i}: ");
    array[i] = Console.ReadLine();
}

System.Console.Write("Задан Массив: ");
PrintString(array);