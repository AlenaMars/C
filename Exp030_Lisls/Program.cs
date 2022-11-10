/* **Задача 53:** Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2 */

List<List<int>> array = new List<List<int>>();

for (int i = 0; i < 3; i++)
{
array.Add(new List<int>());
for (int j = 0; j < 4; j++)
{
array[i].Add(new Random().Next(10));
Console.Write($"{array[i][j]} ");
}
Console.WriteLine();
}
Console.WriteLine();
int lastIndex = array.Count - 1;

List<int> temp = array[0];
array[0] = array[lastIndex];
array[lastIndex] = temp;

for (int i = 0; i < 3; i++)
{
for (int j = 0; j < 4; j++)
Console.Write($"{array[i][j]} ");
Console.WriteLine();
}