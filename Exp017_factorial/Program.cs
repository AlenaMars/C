/* **Задача 28:**
Напишите программу, которая принимает на вход число N и
выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Факториал числа {a} = {Factorial(a)}");

int Factorial(int a)
{
int f = 1;
for (int i = 2; i <= a; i++)
f = f * i;
return f;
}