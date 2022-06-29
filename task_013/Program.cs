// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6




Console.WriteLine(" Введи число ");
int Numb = Convert.ToInt32(Console.ReadLine());
string NumbText = Convert.ToString(Numb);
if (NumbText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + NumbText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}