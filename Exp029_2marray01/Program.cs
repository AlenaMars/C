// Задать двумерный массив m n, каждый элемент которого будет произведением m n

int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength; j++)
    {
        array[i, j] = i + j;
        Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
}