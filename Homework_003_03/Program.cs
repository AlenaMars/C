// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out int N);
Console.Write($"Таблица кубов: ");
for (int i = 1; i <= N; i++)
{
    int c = (int)Math.Pow(i, 3);
    Console.Write($"{c} ");
}
