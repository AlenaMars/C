/* **Задача 39:** Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */
int length = new Random().Next(6, 10);
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
array[i] = new Random().Next(10);
Console.Write($"{array[i]} ");
}
Console.WriteLine();


for (int i = 0; i < length / 2; i++)
{
int temp = array[i];
array[i] = array[length - i - 1];
array[length - i - 1] = temp;
}


Console.WriteLine();
for (int i = 0; i < length; i++)
{
Console.Write($"{array[i]} ");
}