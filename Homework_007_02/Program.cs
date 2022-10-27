// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.




int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int a;
Console.Write($"Введите позицию i: ");
int.TryParse(Console.ReadLine()!, out a);
int b;
Console.Write($"Введите позицию j: ");
int.TryParse(Console.ReadLine()!, out b);
if (a <= array.GetLength(0) || b <= array.GetLength(0)) Console.Write($"{array[a, b]}");
if (a > array.GetLength(0) && b > array.GetLength(0)) Console.Write($"Такой позиции нет");
