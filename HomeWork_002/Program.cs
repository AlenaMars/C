/*
Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

int a = new Random().Next(100,999);
int b = int.Parse(int.Parse(a.ToString().Remove(0, 1)).ToString().Remove(1, 1));
Console.WriteLine($"{a} -> {b}");

