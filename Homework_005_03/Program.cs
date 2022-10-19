// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

int[] array = CreateArray();
foreach (var item in array)
Console.Write($"{item} ");

int[] CreateArray()
{
int[] _array = new int[8];
for (int i = 0; i < _array.Length; i++)
_array[i] = new Random().Next(0, 40);
return _array;
}

int FindM(int[] arraymy)
{
int max = 0;
for (int i = 0; i < arraymy.Length; i++)
{
    if (max < arraymy[i]) max = arraymy[i];
    
}
int min = max;
for (int i = 0; i < arraymy.Length; i++)
{
    if (min >= arraymy[i]) min = arraymy[i];
      
}
return max - min;
}
Console.WriteLine();
Console.WriteLine($"Разница максимального и минимального:  " + (FindM(array)));