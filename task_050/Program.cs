﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Чтобы задать массив вводите следующие значения:");
Console.Write("Количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

Console.WriteLine("Чтобы узнать значение элемента в массиве введите координаты его позиции!");

Console.Write("Номер строки: ");
int line = int.Parse(Console.ReadLine());

Console.Write("Номер столбца: ");
int column = int.Parse(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void MatrixUserElement(int[,] inArray, int lineNumber, int columnNumber)
{
    int i = (lineNumber - 1);
    int j = (columnNumber - 1);
    if (i < inArray.GetLength(0) && i >= 0 && j < inArray.GetLength(1) && j >= 0)
    {
        Console.WriteLine(inArray[(lineNumber - 1), (columnNumber - 1)]);
    }
    else Console.WriteLine($"{lineNumber}, {columnNumber} - числа с такими координатами в массиве нет!");
    return;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} |");
            else Console.Write($"{arr[i, j],3} |");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = CreateMatrixRndInt(m, n, min, max);
PrintMatrix(arrayResult);
MatrixUserElement(arrayResult, line, column);