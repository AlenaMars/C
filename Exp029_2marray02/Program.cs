// задайте 2 мерный массив Найдите элементы у которых индексы четные и замените эти элементы на их квадраты

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

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i%2 != 0 && j%2 != 0)
        {
            array[i, j] *= array[i,j];
        }
        Console.Write($"{array[i, j]} ");
        
    }
    Console.WriteLine();
}
