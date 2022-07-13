// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Double[] arrayNumbers = new Double[5];
for (int i = 0; i < arrayNumbers.Length; i++)

{
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
}

Double maxNumber = arrayNumbers[0];
Double minNumber = arrayNumbers[0];

for (int i = 1; i < arrayNumbers.Length; i++)
{
    if (maxNumber < arrayNumbers[i])
    {
        maxNumber = arrayNumbers[i];
    }
    if (minNumber > arrayNumbers[i])
    {
        minNumber = arrayNumbers[i];
    }
}

Double decision = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine($"разница между между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами: {decision}");


// Не удается неявно преобразовать тип "double" в "int". 
// Существует явное преобразование (возможно, пропущено приведение типов)-не смог решить эту проблему!
// метод NextDouble  не работает, выводит ошибку : Ни одна из перегрузок метода "NextDouble" не принимает 2 аргументов.

// решение получилось с целыми числами 