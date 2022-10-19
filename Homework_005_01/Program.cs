// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

const int size = 4;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(100, 999);
Console.Write($"{array[i]} ");
}

int N = 0;
for (int i = 0; i < size; i++)
{
    if (array[i]%2 == 0)
    N += 1;
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве -> {N}");