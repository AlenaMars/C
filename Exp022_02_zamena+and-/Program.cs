/* **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие
отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2] */

const int length = 12;
int[] array = new int[length];

for (int i = 0; i < length; i++)
{
array[i] = new Random().Next(-9, 10);
Console.Write($"{array[i]} ");
}

for (int i = 0; i < length; i++)
array[i] *= -1;

Console.WriteLine();

for (int i = 0; i < length; i++)
Console.Write($"{array[i]} ");
