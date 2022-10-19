// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int size = 4;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(-20, 20);
Console.Write($"{array[i]} ");
}

int sum = 0;
for (int i = 0; i < size; i++)
{
    if ( i % 2 != 0 )
sum += array[i];
}


Console.Write($"\nСумма элементов = {sum}");