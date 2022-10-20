/* Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины. */
int length = new Random().Next(3, 3);
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
array[i] = new Random().Next(10);
Console.Write($"{array[i]} ");
}
Console.WriteLine();

int a = array[0];
int b = array[1];
int c = array[2];


if (a + b > c && a + c > b && b + c > a)
Console.Write($"Такой треугольник существует");
else
Console.Write($"Такого треугольника не существует");