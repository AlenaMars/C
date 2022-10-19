/* **Задача 35:** Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

const int length = 123;
int[] array = new int[length];

for (int i = 0; i < length; i++)
{
array[i] = new Random().Next(150);
Console.Write($"{array[i]} ");
}

int count = 0;

foreach (var item in array)
{
if (item >= 10 && item <= 99)
count++;
}

Console.Write($"\nAnswer = {count} ");