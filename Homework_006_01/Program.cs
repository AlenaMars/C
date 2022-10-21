// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



Console.Write($"Введите количество чисел, которое собираетесь ввести:\t");
int Count = int.Parse(Console.ReadLine()!);

int[] Array = new int[Count];

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите число {i+1}:\t");
    Array[i] = int.Parse(Console.ReadLine()!);
}
int count = 0;
foreach (var item in Array)
{
if (item > 0)
count++;
}

Console.Write($"\nКоличество чисел больше нуля:  {count} ");

Console.ReadLine();

