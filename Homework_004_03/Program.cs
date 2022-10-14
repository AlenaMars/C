// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = CreateArray();
foreach (var item in array)
Console.Write($"{item} ");
Console.Write($"]");

int[] CreateArray()
{
Console.Write($"[ ");
int[] _array = new int[8];
for (int i = 0; i < _array.Length; i++)
_array[i] = new Random().Next(0, 100);
return _array;
}