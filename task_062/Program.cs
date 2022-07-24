// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 01 02 03 04

// 12 13 14 05

// 11 16 15 06

// 10 09 08 07



Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива: ");
int max = int.Parse(Console.ReadLine());

int[,] GetSpireMatrix(int n) 
{
    int[,] in_array = new int[m, n];
    int number = 1;
    for (int count = 0; count < n; count++)
    {
        for (int j = 0 + count; j < n - count; j++)
        {
            in_array[0 + count, j] = number;
            number++;
        }
        number--;
        for (int i = 0 + count; i < m - count; i++)
        {
            in_array[i, n - 1 - count] = number;
            number++;
        }
        number--;
        for (int j = n - 1 - count; j >= 0 + count; j--)
        {
            in_array[m - 1 - count, j] = number;
            number++;
        }
        number--;
        for (int i = m - 1 - count; i >= 1 + count; i--)
        {
            in_array[i, 0 + count] = number;
            number++;
        }
    }
    number--;
    return in_array;
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

int[,] arrayResult = GetSpireMatrix(n);
PrintMatrix(arrayResult);