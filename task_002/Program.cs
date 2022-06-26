// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3




int a = 9;
int b = 7;
int max = b;
int min = a;
if (a > max) max = a;
if (b < min) min = b;
Console.WriteLine(max);
Console.WriteLine(min);