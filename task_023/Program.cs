// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.WriteLine("Введите число:");
int numb = Convert.ToInt32(Console.ReadLine());
int p = 1;
while (p <= numb) 
{
    Console.WriteLine($"{p}   |   {p * p * p}");
    p++;
}



